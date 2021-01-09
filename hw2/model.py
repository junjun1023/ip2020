import torch
import numpy as np
import os
import cv2
import matplotlib.pyplot as plt
import json
import pandas as pd

from torch.utils.data import DataLoader


import albumentations as albu
import segmentation_models_pytorch as smp

DEVICE = 'cuda'
CLASSES = ["CT", "FT", "MN"]

model = torch.load("best_0108.pth")
model.eval()


# helper function for data visualization
def visualize(**images):
    """PLot images in one row."""
    n = len(images)
    plt.figure(figsize=(16, 5))
    for i, (name, image) in enumerate(images.items()):
        plt.subplot(1, n, i + 1)
        plt.xticks([])
        plt.yticks([])
        plt.title(' '.join(name.split('_')).title())
        plt.imshow(image)
    plt.show()


def stackmask(predicted, source, colors=[(255, 0, 0), (0, 0, 255), (255, 255, 0)]):

    scale = 1
    delta = 0
    ddepth = cv2.CV_16S

    rets = []

    for s in range(source.shape[2]):

        ret = source.copy()[:, :, s]
        ret = cv2.cvtColor(ret, cv2.COLOR_GRAY2RGB)

        for channel in range(predicted.shape[2]):
            gray = predicted[:, :, channel]
            grad_x = cv2.Sobel(gray, ddepth, 1, 0, ksize=3, scale=scale, delta=delta, borderType=cv2.BORDER_DEFAULT)
            grad_y = cv2.Sobel(gray, ddepth, 0, 1, ksize=3, scale=scale, delta=delta, borderType=cv2.BORDER_DEFAULT)

            abs_grad_x = cv2.convertScaleAbs(grad_x)
            abs_grad_y = cv2.convertScaleAbs(grad_y)

            grad = cv2.addWeighted(abs_grad_x, 0.5, abs_grad_y, 0.5, 0)

            # Find contours
            contours, hierarchy = cv2.findContours(grad, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)
            # Draw contours

            for i in range(len(contours)):
                ret = cv2.drawContours(ret, contours, i, colors[channel], 1, cv2.LINE_8, hierarchy, 0)

        rets.append(ret)

    return rets


def get_training_augmentation():
    train_transform = [

        albu.HorizontalFlip(p=0.5),

        albu.ShiftScaleRotate(scale_limit=0.5, rotate_limit=0, shift_limit=0.1, p=1, border_mode=0),

        albu.PadIfNeeded(min_height=320, min_width=320, always_apply=True, border_mode=0),
        albu.RandomCrop(height=320, width=320, always_apply=True),

        albu.OneOf(
            [
                albu.GridDistortion(),
                albu.ElasticTransform()
                # albu.RandomContrast(p=1),
                # albu.HueSaturationValue(p=1),
            ],
            p=0.5,
        ),
    ]
    return albu.Compose(train_transform)


def get_validation_augmentation():
    """Add paddings to make image shape divisible by 32"""
    test_transform = [
        albu.PadIfNeeded(1216, 512)
    ]
    return albu.Compose(test_transform)


def to_tensor(x, **kwargs):
    return x.transpose(2, 0, 1).astype('float32')


def get_preprocessing():
    """Construct preprocessing transform

    Args:
        preprocessing_fn (callbale): data normalization function
            (can be specific for each pretrained neural network)
    Return:
        transform: albumentations.Compose

    """

    _transform = [
        # albu.Lambda(image=preprocessing_fn),
        albu.Lambda(image=to_tensor, mask=to_tensor),
    ]
    return albu.Compose(_transform)


def my_predict(nth, dataset):

    imgs, masks = dataset[nth]

    _img = torch.from_numpy(imgs).to(DEVICE).unsqueeze(0)
    _msks = torch.from_numpy(masks).to(DEVICE).unsqueeze(0)

    # Calculate fscore
    predicted = model.predict(_img)
    predicted = predicted.detach()



    dices = []
    for channel in range(predicted.shape[1]):
        tmp_pr = torch.index_select(predicted, 1, torch.tensor([channel]).to(predicted.device) )
        tmp_gt = torch.index_select(_msks, 1, torch.tensor([channel]).to(_msks.device) )

        dice = smp.utils.metrics.Fscore()(tmp_pr, tmp_gt)

        dices.append(dice.cpu().item())
        print(CLASSES[channel], "dice: ", dice.cpu().item())


    predicted = predicted.squeeze().cpu().numpy()


    # 2, 0, 1
    imgs = np.transpose(imgs, (1, 2, 0))
    masks = np.transpose(masks, (1, 2, 0))
    predicted = np.transpose(predicted, (1, 2, 0))

    # source = cv2.cvtColor(imgs, cv2.COLOR_GRAY2RGB)
    stacks = stackmask(predicted=predicted, source=imgs)
    # print(stacks.shape)


    inputs = []
    for i in range(imgs.shape[2]):
        tmp = cv2.cvtColor(imgs[:,:, i], cv2.COLOR_GRAY2RGB)
        inputs.append(tmp)


    predicts = []
    for i in range(predicted.shape[2]):
        tmp = cv2.cvtColor(predicted[:,:, i], cv2.COLOR_GRAY2RGB)
        predicts.append(tmp)


    gts = []
    for i in range(masks.shape[2]):
        tmp = cv2.cvtColor(masks[:,:, i], cv2.COLOR_GRAY2RGB)
        gts.append(tmp)


    return inputs, gts, predicts, stacks, dices

    # CLASSES = ["CT", "FT", "MN"]
    # visualize(
    #     t1 = inputs[0],
    #     t2 = inputs[1],
    #     gt_ct = gts[0],
    #     gt_ft = gts[1],
    #     gt_mn = gts[2],
    #     pr_ct = predicts[0],
    #     pr_ft = predicts[1],
    #     pr_mn = predicts[2],
    #     contour = stacks[0]
    #
    # )
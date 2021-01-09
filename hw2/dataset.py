from torch.utils.data import Dataset as BaseDataset

import os
import cv2
import numpy as np

class Dataset(BaseDataset):
    images_fps = []
    masks_fps = []

    def __init__(
            self,
            dir,
            img_dir_names=["T1", "T2"],
            mask_dir_names=["CT", "FT", "MN"],
            augmentation=None,
            preprocessing=None):

        _dir = os.path.join(dir, img_dir_names[0])
        _ids = os.listdir(_dir)

        _ids.sort()
        self.ids = _ids

        for _id in _ids:
            t1 = os.path.join(dir, "T1", _id)
            t2 = os.path.join(dir, "T2", _id)
            ct = os.path.join(dir, "CT", _id)
            ft = os.path.join(dir, "FT", _id)
            mn = os.path.join(dir, "MN", _id)

            imgs = [t1, t2]
            masks = [ct, ft, mn]

            self.images_fps.append(imgs)
            self.masks_fps.append(masks)

        # self.class_values = [mask_dir_names.index(cls) for cls in mask_dir_names]
        self.augmentation = augmentation
        self.preprocessing = preprocessing

    def __getitem__(self, i):

        # read input image
        imgs = [cv2.imread(img, cv2.IMREAD_GRAYSCALE) for img in self.images_fps[i]]
        blank_img = np.zeros(shape=imgs[0].shape)
        imgs.append(blank_img)
        # imgs = [cv2.cvtColor(img, cv2.COLOR_BGR2GRAY) for img in imgs]
        image = np.stack(imgs, axis=-1).astype('float')

        # read mask
        masks = [cv2.imread(mask, cv2.IMREAD_GRAYSCALE) for mask in self.masks_fps[i]]

        mask = np.stack(masks, axis=-1).astype('float')

        # apply augmentations
        if self.augmentation:
            sample = self.augmentation(image=image, mask=mask)
            image, mask = sample['image'], sample['mask']

        # apply preprocessing
        if self.preprocessing:
            sample = self.preprocessing(image=image, mask=mask)
            image, mask = sample['image'], sample['mask']

            # remove the padding channel
            image = np.stack([image[0, ...], image[1, ...]], axis=0).astype(np.float32)
        else:
            # remove the padding channel
            image = np.stack([image[..., 0], image[..., 1]], axis=-1).astype('float')

        image = image / 255
        mask = mask / 255

        return image, mask

    def __len__(self):
        return len(self.ids)



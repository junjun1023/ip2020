import sys
import os
from PyQt5.QtWidgets import QApplication, QMainWindow, QFileDialog, QSplitter, QSlider, QTextEdit
from PyQt5.QtCore import Qt

from PyQt5.QtWidgets import QVBoxLayout, QWidget, QHBoxLayout
from PyQt5.QtWidgets import QLabel, QPushButton, QComboBox
from functools import partial

import numpy as np
from model import my_predict, get_preprocessing, visualize
from dataset import Dataset


class MainWindow(QMainWindow):

    dataset_path = None
    record = None
    dataset = None

    def __init__(self, *args, **kwargs):
        super(MainWindow, self).__init__(*args, **kwargs)

        self.setWindowTitle('DIP 2020 HW2')
        self.cwd = os.getcwd()

        main_box_layout = QVBoxLayout()
        main_box_widget = QWidget()
        main_box_widget.setLayout(main_box_layout)

        q5_box_layout = QVBoxLayout()
        q5_box_widget = QWidget()
        q5_box_widget.setLayout(q5_box_layout)

        ##### select dataset
        self.dataset_btn = QPushButton('Select Dataset')
        self.dataset_btn.clicked.connect(self.slot_btn_chooseDir)

        self.data_path = QLabel()

        ##### Run
        self.run_btn = QPushButton("Run")
        self.run_btn.clicked.connect(self.inference)

        ##### Mean Dice
        self.dice_mean = QTextEdit()
        self.dice_mean.setReadOnly(True)
        self.dice_sep = QTextEdit()
        self.dice_sep.setReadOnly(True)

        q5_box_layout.addWidget(self.dataset_btn)
        q5_box_layout.addWidget(self.data_path)
        q5_box_layout.addWidget(self.run_btn)
        q5_box_layout.addWidget(QSplitter(Qt.Horizontal))
        q5_box_layout.addWidget(self.dice_mean)
        q5_box_layout.addWidget(self.dice_sep)


        main_box_layout.addWidget(q5_box_widget)
        self.setCentralWidget(main_box_widget)
        self.resize(400, 300)


        ##### Slider
        self.slider_label = QLabel('0')

        self.slider = QSlider(Qt.Horizontal)
        self.slider.setTickPosition(QSlider.TicksBelow)
        self.slider.setMinimum(0)
        self.slider.setMaximum(20)
        self.slider.valueChanged[int].connect(self.changevalue)

        q5_box_layout.addWidget(self.slider_label)
        q5_box_layout.addWidget(self.slider)


    def inference(self):
        if self.dataset_path:

            record = {
                "t1": [],
                "t2": [],
                "stack_t1": [],
                "stack_t2": [],
                "gt_ct": [],
                "gt_ft": [],
                "gt_mn": [],
                "pr_ct": [],
                "pr_ft": [],
                "pr_mn": [],
                "ct": [],
                "ft": [],
                "mn": []
            }

            self.dataset = Dataset(self.dataset_path, augmentation=None, preprocessing=get_preprocessing())

            cnt = len(self.dataset)
            for index in range(cnt):

                # imgs = [t1, t2], dices = [ct, ft, mn]
                inputs, gts, prs, stacks, dices = my_predict(index, self.dataset)
                record["t1"].append(inputs[0])
                record["t2"].append(inputs[1])

                record["stack_t1"].append(stacks[0])
                record["stack_t2"].append(stacks[1])

                record["gt_ct"].append(gts[0])
                record["gt_ft"].append(gts[1])
                record["gt_mn"].append(gts[2])

                record["pr_ct"].append(prs[0])
                record["pr_ft"].append(prs[1])
                record["pr_mn"].append(prs[2])

                record["ct"].append(dices[0])
                record["ft"].append(dices[1])
                record["mn"].append(dices[2])

            self.record = record

            self.dice_mean.setPlainText("Dice CT: {}\nDice FT: {}\nDice MN: {}".format(
                np.mean(np.array(record["ct"])),
                np.mean(np.array(record["ft"])),
                np.mean(np.array(record["mn"])),
            ))


    def changevalue(self, value):


        self.slider_label.setText('Current:' + str(value))
        if self.record and value < 20 :
            t1 = self.record["t1"][value]
            t2 = self.record["t2"][value]

            stack_t1 = self.record["stack_t1"][value]
            stack_t2 = self.record["stack_t2"][value]

            gt_ct = self.record["gt_ct"][value]
            gt_ft = self.record["gt_ft"][value]
            gt_mn = self.record["gt_mn"][value]

            pr_ct = self.record["pr_ct"][value]
            pr_ft = self.record["pr_ft"][value]
            pr_mn = self.record["pr_mn"][value]

            ct = self.record["ct"][value]
            ft = self.record["ft"][value]
            mn = self.record["mn"][value]

            self.dice_sep.setPlainText("Dice CT: {}\nDice FT: {}\nDice MN: {}".format(
                ct,
                ft,
                mn,
            ))


            visualize(
                t1=t1,
                t2=t2,
                gt_ct=gt_ct,
                gt_ft=gt_ft,
                gt_mn=gt_mn,
                pr_ct=pr_ct,
                pr_ft=pr_ft,
                pr_mn=pr_mn,
                contour=stack_t1,
            )


            # self.t1_picbox.setPixmap(t1)
            # self.t2_picbox.setPixmap(t2)
            # self.out_t1_picbox.setPixmap(stack_t1)
            # self.out_t2_picbox.setPixmap(stack_t2)
            # self.gt_ct_picbox.setPixmap(gt_ct)
            # self.gt_ft_picbox.setPixmap(gt_ft)
            # self.gt_mn_picbox.setPixmap(gt_mn)
            # self.pr_ct_picbox.setPixmap(pr_ct)
            # self.pr_ft_picbox.setPixmap(pr_ft)
            # self.pr_mn_picbox.setPixmap(pr_mn)


        else:
            print("Please inference first")


    def slot_btn_chooseDir(self):
        dir_choose = QFileDialog.getExistingDirectory(self,
                                                      "Select dir",
                                                      self.cwd)

        if dir_choose == "":
            print("\nCancel dir choose")
            return


        self.dataset_path = dir_choose
        self.data_path.setText(dir_choose)

    def slot_btn_chooseFile(self, btn):
        img, filetype = QFileDialog.getOpenFileName(self,
                                                                "Select Img",
                                                                self.cwd,
                                                                "All Files (*);;Image File (*.png *.jpg)")

        if img == "":
            print("\nCancel file choose")
            return


        if btn == self.t1_img_btn:
            pass
        elif btn == self.t2_img_btn:
            pass
        else:
            print("Error: unknown btn choose file")


    def slot_btn_chooseMutiFile(self, btn):
        imgs, filetype = QFileDialog.getOpenFileNames(self,
                                                       "Select Imgs",
                                                       self.cwd,
                                                       "All Files (*);;Image Files (*.png *.jpg)")

        if len(imgs) == 0:
            print("\nCancel file choose")
            return

        if btn == self.gt_img_btn:
            pass
        else:
            print("Error: unknown btn choose multifile")



def main():
    app = QApplication(sys.argv)

    window = MainWindow()
    window.show()

    app.exec_()


if __name__ == '__main__':
    main()




# -*- coding: utf-8 -*-
import cv2
from matplotlib import pyplot as plt


img = cv2.imread("photo.jpg_encrypted.bmp",0)
plt.hist(img.ravel(),256,[0,256]); plt.show()

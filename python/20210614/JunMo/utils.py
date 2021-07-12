'''
    가지고온 이미지들을 cv2
    cv2.imread 하게되면 numpy 배열로
    numpy 나온걸 이웃알고리즘
    cv2.imread predict 하게되면...?
'''
import cv2
GREEN = 0
BLUE = 1
RED = 2

def getcolors(img, color):
    other_1 = (color + 1) % 3
    other_2 = (color + 2) % 3
    # 블리언 인덱싱
    indexes = img[:, :, other_1] == 255
    img[indexes] = [0, 0, 0]
    # cv2.imshow('image', img)
    # cv2.waitKey(0)

    indexes = img[:, :, other_2] == 255
    img[indexes] = [0, 0, 0]
    # cv2.imshow('image', img)
    # cv2.waitKey(0)

    indexes = img[:, :, color] < 170
    img[indexes] = [0, 0, 0]
    # cv2.imshow('image', img)
    # cv2.waitKey(0)

    indexes = img[:, :, color] != 0
    img[indexes] = [255, 255, 255]
    # cv2.imshow('image', img)
    # cv2.waitKey(0)
    return img



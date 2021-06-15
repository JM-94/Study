'''
1. 웹, 2. 머신러닝, 3. 그래프
1. flask, 2. sklearn, 3. matplotlib
'''
from flask import Flask, render_template
from alone21 import maketraintest
import numpy as np
import matplotlib.pyplot as plt
import cv2

img1 = cv2.imread("static/image_1.jpg")
img2 = cv2.imread("static/image_2.jpg")

img3 = cv2.add(img1, img2)
cv2.imshow("img3", img3)
cv2.waitKey(0)

img4 = np.add(img1, img2)
cv2.imshow("img4", img4)
cv2.waitKey(0)

cv2.imwrite("img3.png",img3)

# app = Flask(__name__)

'''
    numpy as np
    np.arange(10) => [0,1,2,3,4,5,6,7,8,9]
    np.random.seed(42) -> 랜덤한 값이 똑같은 방식으로 나오세

    np 문법
    slice, indicate
    [:35], [1,3,5]

    KNeighborsClassifier
    fit() 데이터 학습
    score() 이 데이터들의 예측되는 값의 점수
    predict() 예측값을 확인
'''
# @app.route("/")
# def index():
#     maketraintest()
#     return render_template("index.html")
#
#
# app.run(host="127.0.0.1",port=5000)


import cv2

def doA():
    ka = cv2.imread("ka.jpg")
    cv2.imshow("ka",ka)
    cv2.waitKey(0)

    bgrv = ka[200,200]
    print(bgrv)
    print(bgrv[2])

    # roi = ka[0:350, 0:350]
    # print(roi)
    # cv2.imshow("roi",roi)
    # cv2.waitKey(0)

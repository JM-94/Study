import numpy as np

a = 10
b = 20

def doA():
    np1 = np.arange(4)  # 0~3까지 numpy배열선언
    np2 = np.zeros((4,4),dtype=float)  # 2차원 배열 4행4열 float형 선언
    np3 = np.ones((3,3),dtype=str)  # 3행 3열 문자열형 선언

    np.random.seed(2)   # 랜덤한값을 2에 패턴으로만..
    np4 = np.random.randint(0,10,(2,2)) #0~9까지 2행2열
    np5 = np.random.normal(0,1,(3,3))  #0~1사이 표준정규를 띄는 배열

    print(np1)
    print(np2)
    print(np3)
    print(np4)
    print(np5)

def doB():
    np1 = np.array([1,2])
    np2 = np.array([3,4])
    np3 = np1+np2
    np4 = np.concatenate([np1,np2])
    print(np3)
    print(np4)

    print(np3.shape)
    print(np4.shape)

    np5 = np.random.randint(0,10,(3,3))
    print(np5.shape)

def doC():
    np1 = np.arange(4).reshape(1,4)
    np2 = np.arange(8).reshape(2,4)

    print(np1)
    print(np2)

    np3 = np.concatenate([np1,np2],axis=0)  #행을 기준합쳐라
                                            # axis = 0 행기준
    print(np3)
    # np4= np.concatenate([np1, np2], axis=1)
    # print(np4)

def doD():
    array = np.arange(8).reshape(2,4)
    left,right = np.split(array,[2],axis=1)
    print('left = ',left)
    print('right = ',right)
    print('left.shape',left.shape)
    print('right.shape', right.shape)
'''
    회귀랑 분류
    지금까지 분류 알고리즘인
    knn Classfier을 공부했다.
    분류는 지도 학습이라 생각하면된다.
    학습할 데이터를 넣고
    예측되는 값을 유추하는 것

    회귀는 말은 회귀지만(인생 2회 이런건 아니다.)
    물고기 데이터에서 가로의 길이와 세로의 길이를
    학습시켜 무게를 예측하는 것
'''
import matplotlib.pyplot as plt
import numpy as np
import matplotlib.pyplot as ply
from sklearn.model_selection import train_test_split
from sklearn.neighbors import KNeighborsRegressor


perch_length = np.array(
    [8.4, 13.7, 15.0, 16.2, 17.4, 18.0, 18.7, 19.0, 19.6, 20.0,
     21.0, 21.0, 21.0, 21.3, 22.0, 22.0, 22.0, 22.0, 22.0, 22.5,
     22.5, 22.7, 23.0, 23.5, 24.0, 24.0, 24.6, 25.0, 25.6, 26.5,
     27.3, 27.5, 27.5, 27.5, 28.0, 28.7, 30.0, 32.8, 34.5, 35.0,
     36.5, 36.0, 37.0, 37.0, 39.0, 39.0, 39.0, 40.0, 40.0, 40.0,
     40.0, 42.0, 43.0, 43.0, 43.5, 44.0]
     )
perch_weight = np.array(
    [5.9, 32.0, 40.0, 51.5, 70.0, 100.0, 78.0, 80.0, 85.0, 85.0,
     110.0, 115.0, 125.0, 130.0, 120.0, 120.0, 130.0, 135.0, 110.0,
     130.0, 150.0, 145.0, 150.0, 170.0, 225.0, 145.0, 188.0, 180.0,
     197.0, 218.0, 300.0, 260.0, 265.0, 250.0, 250.0, 300.0, 320.0,
     514.0, 556.0, 840.0, 685.0, 700.0, 700.0, 690.0, 900.0, 650.0,
     820.0, 850.0, 900.0, 1015.0, 820.0, 1100.0, 1000.0, 1100.0,
     1000.0, 1000.0]
     )



# plt.show()
# plt.savefig('static/perch_gra.png')
# plt.close()

train_input, test_input, train_target, test_target \
 = train_test_split(perch_length, perch_weight, random_state=42)

# print("학습할 데터 행 열 사이즈", train_input.shape)
# print("테스트할 행 열 사이즈", test_input.shape)
# print(train_input[:5])
# print(test_input[:5])

# print("-------------------------")
train_input = train_input.reshape(-1,1)
test_input = test_input.reshape(-1,1)
#
# print("학습할 데터 행 열 사이즈", train_input.shape)
# print("테스트할 행 열 사이즈", test_input.shape)
#
# print(train_input[:5])
# print(test_input[:5])

kn = KNeighborsRegressor()
print(kn)

kn.fit(train_input, train_target)

myx = np.array([50,60,70]).reshape(-1,1)
predictvalues = kn.predict(myx)
print("예측되는 값", predictvalues)

# plt.scatter(myx, predictvalues)
# plt.show()


x = np.arange(5,45).reshape(-1,1)
y = np.arange(45,85).reshape(-1,1)

plt.scatter(x,y)
plt.plot(x,y)
plt.xlabel('xxxx')
plt.ylabel('yyyy')
plt.show()



# print("x = ")
# print(x)

# for n in [1,5,10]:
#  plt.scatter(perch_length, perch_weight)
#  plt.xlabel('length')
#  plt.ylabel('weight')



























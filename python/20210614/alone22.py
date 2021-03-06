import matplotlib.pyplot as plt
from sklearn.model_selection import train_test_split
import numpy as np
from sklearn.neighbors import KNeighborsClassifier

fish_length = [25.4, 26.3, 26.5, 29.0, 29.0, 29.7, 29.7, 30.0, 30.0, 30.7, 31.0, 31.0,
                   31.5, 32.0, 32.0, 32.0, 33.0, 33.0, 33.5, 33.5, 34.0, 34.0, 34.5, 35.0,
                   35.0, 35.0, 35.0, 36.0, 36.0, 37.0, 38.5, 38.5, 39.5, 41.0, 41.0, 9.8,
                   10.5, 10.6, 11.0, 11.2, 11.3, 11.8, 11.8, 12.0, 12.2, 12.4, 13.0, 14.3, 15.0]
fish_weight = [242.0, 290.0, 340.0, 363.0, 430.0, 450.0, 500.0, 390.0, 450.0, 500.0, 475.0, 500.0,
                   500.0, 340.0, 600.0, 600.0, 700.0, 700.0, 610.0, 650.0, 575.0, 685.0, 620.0, 680.0,
                   700.0, 725.0, 720.0, 714.0, 850.0, 1000.0, 920.0, 955.0, 925.0, 975.0, 950.0, 6.7,
                   7.5, 7.0, 9.7, 9.8, 8.7, 10.0, 9.9, 9.8, 12.2, 13.4, 12.2, 19.7, 19.9]

# cc = np.column_stack(([1, 2, 3], [4, 5, 6]))
# print(cc)
fish_data = np.column_stack((fish_length,fish_weight))

# print(fish_data)
fish_target = np.concatenate((np.ones(35), np.zeros(14)))
# print(fish_target)

train_input, test_input, train_target, test_target = train_test_split(fish_data, fish_target, stratify=fish_target, random_state=42)

# print('학습시킬 입력 행열 사이즈',test_input.shape)
# print('학습시킬 입력 행열 사이즈',train_target.shape)

# print(train_input[:5])
# print(train_target[:5])
# fish_data -> 7:3 fish_target 7:3
# 학습시킬 데이터가 준비되었다



kn = KNeighborsClassifier()
kn.fit(fish_data, fish_target)
predictValue = kn.predict([[25, 100]])
# print('예상되는 값', predictValue)

# plt.scatter(train_input[:, 0], train_input[:, 1], c='r')
# plt.scatter(25, 150, c='b', marker='^')
# plt.xlabel('length')
# plt.ylabel('weight')
# plt.show()


predictValue = kn.predict(test_input)
# print(predictValue)
# print(test_target)
# myscore = kn.score(test_input, test_target)
# print(myscore)


distances, indexes = kn.kneighbors([[25,150]])
print('5개의 점과의 거리들', distances)
print('5개의 점의 요소번호들', indexes)
print('5개 요소의 xy좌표들',fish_data[indexes,0],fish_data[indexes,1])

# plt.scatter(fish_data[indexes,0], fish_data[indexes,1], marker='D')
# plt.xlim(0,1000)

mean = np.mean(test_input,axis=0)
std = np.std(test_input,axis=0)

print('mean = ', mean)
print('std = ', std)

train_scaled = test_input-mean/std
print(train_scaled[:5])








plt.show()


'''
    [1,2,3,4,5,6,7,8,9] - 3 = [-2,-1,0,1,2,3,4,5,6]
'''











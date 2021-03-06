import numpy as np
import pandas as pd                                     # paondas 라이브러리 가져오기
from sklearn.model_selection import train_test_split    # 훈련데이터와 테스트데이터 나누기
from sklearn.neighbors import KNeighborsClassifier      # 이웃알고리즘분류
from sklearn.preprocessing import StandardScaler        # 표준점수 구하는 클래스
import matplotlib.pyplot as plt
from sklearn.linear_model import LogisticRegression     # 로지스틱분류 모델 가져오기

fish = pd.read_csv('https://bit.ly/fish_csv_data')
# head = fish.head()

fish_input = fish[['Weight', 'Length', 'Diagonal', 'Height', 'Width']].to_numpy()
# print(fish_input[:5])
fish_target = fish['Species'].to_numpy()
# print(fish_target[:5])

train_input, test_input, train_target, test_target \
    = train_test_split(fish_input, fish_target, random_state=42)

ss = StandardScaler()
ss.fit(train_input)
train_scaled = ss.transform(train_input)
test_scaled = ss.transform(test_input)

knc = KNeighborsClassifier(n_neighbors=3)
# knc.fit(train)
knc.fit(train_scaled, train_target)
예측확률 = knc.predict_proba(test_scaled[:5])
점수 = knc.score(test_scaled, test_target)
print(np.round(예측확률, decimals=3))
print(점수)

'''
    이진분류 처리
    [bream, smelt, roach, bream, smelt, roach, bream, smelt, roach]
'''
# 블리언 인덱싱
bream_smelt_indexes = (train_target == 'Bream') | (train_target == 'Smelt')
train_bream_smelt = train_scaled[bream_smelt_indexes]
target_bream_smelt = train_target[bream_smelt_indexes]

lr = LogisticRegression()
lr.fit(train_bream_smelt, target_bream_smelt)




로지스틱확률 = lr.predict_proba(train_bream_smelt[:5])
print(로지스틱확률)

z = lr.decision_function(train_bream_smelt[:5])
print('zzzzzzzzzzzz')
print(z)

from scipy.special import expit
print('시그모이드')
print(expit(z))

'''
    다중분류
'''
lr = LogisticRegression()
lr.fit(train_scaled, train_target)

myz = lr.decision_function(test_scaled)
로지스틱점수 = lr.score(test_scaled, test_target)
로지스틱확률 = lr.predict_proba(train_scaled[:5])
print('mya', np.round(myz, decimals=3)[:5])
print('로지스틱점수', 로지스틱점수)
print(np.round(로지스틱확률, decimals=3))

# plt.xlabel('Weight')
# plt.ylabel('Length')
# plt.scatter(fish['Weight'].to_numpy()[:5], fish['Length'].to_numpy()[:5], c='b')
# plt.scatter(fish['Weight'].to_numpy()[5:10], fish['Length'].to_numpy()[5:10], c='r')
# plt.show()




#이진분류
# z = decision_function
# expit(z) => 확률(시그모이드)
# predict_proba -> 확률

#다중분류
# z = decision_function
# softmax => 확률
# predict_proba -> 확률

'''
    로지스틱 리그레이션(분류)
    이진분류 -> 시그모이드 확률
    다중분류 -> 소프트맥스 확률
'''





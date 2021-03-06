#회귀분석
#회귀분석 : 독립변수와 종속변수의 인과관계를 파악하여, 종속변수를
#           독립변수로부터 설명하고 예측하는 분석.
#상관변수는 두 변수의 관계를 나타내는 것
#회귀분석은 독립변수와 종속변수가 있음
#독립변수 : 다른변수에 영향을 받지 않는 변수, 종속변수에 영향을 줌.
#종속변수 : 독립변수에 영향을 받아서 값이 변하는 변수.

#단순회귀분석 : 독립변수가 1개일 때
#독립변수가 1단위의 증감에 따라 종속변수가 어느 정도 변하는지를 예측.
#회귀식 : 독립변수에 의한 종속변수의 값을 예측해주는
#선형함수식 : Y = aX + b [Y:종속변수, X:독립변수, a:독립변수의 증감정도
#                         b: 독립변수로부터 영향을 받지 않는 값]
#산점도에서 데이터를 가장 잘 설명할 수 있는 선을 찾는 분석

library(ggplot2)
str(diamonds)
dia <- lm(price~carat, data=diamonds) #[종속변수:price~독립변수:carat,모집단]
# lm:회귀분석 함수, 결과 (Intercept 절편:-2256, carat 기울기:7756)
#                   -> carat이 증가할 수록 가격 증가한다.
View(diamonds)
dia
# 결정계수: 약85%, Adjusted R-squared:0.8493 [종속변수의 변화량이 85%예측]
#독립변수가 만약 2개 이상인 경우엔 더 많은 변화량을 설명하기에,
#결정계수가 커지는 경향이 있음.
#Residual standard error: 1549 on 53938 degrees of freedom
#Multiple R-squared:  0.8493,	Adjusted R-squared:  0.8493 
#F-statistic: 3.041e+05 on 1 and 53938 DF,  p-value: < 2.2e-16
# p < 0.05 때 신뢰도 95%이상. 오차±5% <- 통계적으로 유의미하다고 판단

#잔차 : 예상치와 실제 관측치의 차이
#1. 잔차분포 그래프:y축을 0을 기준으로 고르게 분포하는게 좋음.
#2. 정규화 관련:해당 점선에 잔차들이 놓여있으면 정규성을 만족.
#3. 잔차를 표준화해서 제곱:x축은 선형회귀로 예측된 관측치, y측은 표준화 잔차
#   기울기가 0인 직선형태, 점들도 고르게 분포가 좋음.
#4. 영향점 판별 그래프 x축 : Leverage, Y축: 표준화된 잔차
#                      x축 : 변수가 얼마나 벗어나있는지 의미
# outlier : 주어진 회귀모델에서 잘 설명되지 않는 데이터
summary(dia)
par(mfrow=c(2,2))
plot(dia)

library(car)
outlierTest(dia) #이상치값

#다중회귀분석
#종속변수1개, 독립변수가 2개 이상인 회귀분석
#ex) 맛집(종속변수), 음식맛, 분위기, 청결, 가격, 위치..
library(readxl)
csvIns <- read.csv('res/insurance.csv')
#범주형(분류목적) : sex, smoker, region [수치가 아니기에 최대/최소 안나옴]
#수치형(일정기간, 연속적인 수치) : age, bmi, children, charges
summary(csvIns)

hist(csvIns$charges)
hist(csvIns$bmi)
table(csvIns$region)#범주형을 보기에 좋음.

#psych 라이브러리
library(psych)
scaMatrix <- csvIns[c("age","bmi","children","charges")]
#기존의 산점모 매트릭스보다 잘 되어 있음
pairs.panels(scaMatrix)


# -1 ~ +1
cor(scaMatrix)

lmins <- lm(charges ~ age+children+bmi+sex+smoker+
              region,data=csvIns)
lmins
summary(lmins)














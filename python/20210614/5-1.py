import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.preprocessing import StandardScaler
from sklearn.linear_model import LogisticRegression
from sklearn.tree import DecisionTreeClassifier


wine = pd.read_csv('https://bit.ly/wine_csv_data')

print(wine.head())
print(wine.info())
print(wine.describe())

data = wine[['alcohol', 'sugar', 'pH']].to_numpy()
target = wine['class'].to_numpy()

train_input, test_input, train_target, test_target = train_test_split(
    data, target, test_size=0.2, random_state=42)

print(train_input.shape)
print(test_input.shape)

ss = StandardScaler()
ss.fit(train_input)

train_scaled = ss.transform(train_input)
test_scaled = ss.transform(test_input)

lr = LogisticRegression()
lr.fit(train_scaled, train_target)
trainscore = lr.score(train_scaled, train_target)
testscore = lr.score(test_scaled, test_target)

print(trainscore)
print(testscore)


dtc = DecisionTreeClassifier(random_state=42)
dtc.fit(train_scaled, train_target)

trainscore = dtc.score(train_scaled, train_target)
testscore = dtc.score(test_scaled, test_target)

print(trainscore)
print(testscore)


import matplotlib.pyplot as plt
from sklearn.tree import plot_tree

# plt.figure(figsize=(10,7))
# plot_tree(dtc)
# plt.show()

# plt.figure(figsize=(10,7))
# plot_tree(dtc, max_depth=1, filled=True, feature_names=['alcohol', 'sugar', 'pH'])
# plt.show()

dt = DecisionTreeClassifier(max_depth=3, random_state=42)
dt.fit(train_scaled, train_target)

print(dt.score(train_scaled, train_target))
print(dt.score(test_scaled, test_target))











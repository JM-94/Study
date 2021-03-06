library(readxl)
library(xlsx)

excelData <- read_excel('res/data_ex.xlsx')
View(excelData)

studentx <- read.xlsx(file.choose(),
                      sheetIndex = 1,
                      encoding = 'UTF-8')
View(studentx)



#연습문제
# 1. "2021-04-29 수입 3000원",
#    "2021-04-30 수입 4500원",
#    "2021-05-01 수입 5500원"
# 1번의 문자열을 이용하여 아래와 같이 출력
# 출력 형태 > "3000원", "4500원", "5500원"



# 2. 1번에서 '-' 를 '/' 로 변경
#   ---> str_replace_all()



# 3. 임의의 국어, 영어, 수학점수를 가지는 벡터3개 생성
#     Ex) kor <- c(90, 85, 90)



# 4. 3번 벡터를 가지는 data frame 생성



# 5. 국, 영, 수 data frame에서 최대값 구하기
#   ---> apply(object, 1, max) : 가로방향
#   ---> apply(object, 2, max) : 세로로방향



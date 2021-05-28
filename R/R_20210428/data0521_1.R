library(XML)
library(ggplot2)

api <- "http://apis.data.go.kr/B552584/ArpltnInforInqireSvc/getMinuDustFrcstDspth"
apikey <- "2SeuYMWYdxsLIy4uYI%2FnPK3SHArlIpjqQ7B4vlnEm0PiIBmznlriKbVOyoYRwS21G3H0DgS%2BQxBcRhrRUa8uxQ%3D%3D"
returnType <- "xml"
numOfRows <- 100
pageNo <- 1
InformCode <- "PM10"

url <- paste(api, "?serviceKey=", apikey, 
             "&returnType=", returnType,
             "&numOfRows=", numOfRows, 
             "&pageNo=", pageNo, 
             "&InformCode=", InformCode, 
             sep = "")
url
xmlFile <- xmlParse(url)
xmlRoot(xmlFile)
df <- xmlToDataFrame(getNodeSet(xmlFile, "//items/item"))
df

ggplot(data=df, aes(x=dataTime, y=informCode))+
  geom_bar(stat = "identity", fill="green")+
  # x축 눈금 라벨 90도 회전
  theme(axis.text.x = element_text(angle=90))+
  labs(title = "대기질 예보통보 조회", x="통보날짜", y="통보코코드")

ggplot(data=df, aes(x=dataTime, y=informCode, fill=informCode))+
  geom_bar(stat = "identity")+
  # x축 눈금 라벨 90도 회전
  theme(axis.text.x = element_text(angle=90))+
  labs(title = "대기질 예보통보 조회", x="통보날짜", y="통보코코드") +
  scale_fill_manual(values = rainbow(10))

ggplot(data=df, aes(x=dataTime, y=informCode, fill=informCode))+
  geom_bar(stat = "identity")+
  # x축 눈금 라벨 90도 회전
  theme(axis.text.x = element_text(angle=90))+
  labs(title = "대기질 예보통보 조회", x="통보날짜", y="통보코코드") +
  scale_fill_manual(values = rainbow(7)) +
  coord_flip()

















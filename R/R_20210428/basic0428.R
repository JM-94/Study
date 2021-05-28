# Ctrl + Enter : 한 라인 또는 선택 영역 실행
# Ctrl + Alt + R : 전체실행
# Ctrl + Alt + B : 처음에서 현재 행까지 실행
# Ctrl + Alt + E : 현재 행에서 마지막까지 실행
# 주석처리 : Ctrl + Shift + C

n = 100
n <-90
n <<- 80
n
print(n)
sprintf("점수 : %d", n)
cat("점수 : ", n)


x <- 10
y <- 10
z <- x*y
cat('x * y의 결과는 ',z,'입니다.\n')
sprintf('%d * %d = %d',x,y,z)

x <- 3.5
x
print(x)
sprintf('x : %.2f',x)

y<- 'string'
print(y)
y<-"문자열"
y

z<- FALSE # (FALSE, F, TRUE, T)
z<- TRUE

10 + 3
10 - 5
2 * 3
4 / 3
4 %/% 3 # 정수값
4 %% 3 # 나머지
2^3 #거듭제곱



#data 입력, 배열 시작 1부터
#scan() 숫자 정보만 입력 가능

print('숫자를 입력하세요')
num <- scan()
num

#scan(what='') 문자열 입력
#매개변수 받을땐 <- 값을 대입받을때 = 권장
print('문자열을 입력하세요')
str <- scan(what='')
str

#data frame, 엑셀
df <- data.frame()
df <- edit(df)
df

x <- 8
if(x > 0 && x <10){
  print('1~10 사이의 숫자 입니다.')
}else{
  print('1~10 사이의 숫자가 아닙니다.')
}

if(x == 1 || x == 10){
  print('1이거나 10 입니다.')
}else if(x != 8){
  print('8이 아닙니다.')
}else{
  sprintf('정보는 %d 입니다',x)
}

#숫자뒤에 L안붙이면 문자열, 붙이면 숫자 
num <- 30
if(is.integer(num)){
  print('num은 숫자')
}else{
  print('num은 문자열')
}

#c() = vector, 문자열 vector 
data <- c('홍길동','김길동'
          ,'박길동','이길동')
if('박길동' %in% data){
  print('박길동이 존재합니다.')
}else{
  print('박길동이 없습니다')
}

i<-0
while(i < 10){
  i <- i+1
  print(i)
}

sum <- 0
num <- c(1,4,7)
for(i in num){
  print(sum <- sum + i)
}

sum <- 0
for (iin 1:10){
  if (i %% 2 == 0){
    next;
  }
  if( i == 7){
    break
  }
  sum <- sum + i
}
print(sum)

index <- seq(1, 10, by=2)
for (i in index){
  print(i)
}

func1 <- function(start, end){
  sum <- 0
  for (i in start:end){
    sum <- sum + i
  }
  return(sum)
}

sprintf('합계 : %d', func1(1,10))

func2 <- function(num1, num2, op){
  if(op == '+'){
    return(num1+num2)
  }
  else {
    return(num1-num2)
  }
}

func2_2 <- function(num1, num2){
  return(num1+num2)
}

func2_1 <- function(...){
  res <- func2(...)
  #val <- func2_2(...)
  return (res + val)
}
func2_1(10,5,'+')
func2_1(20,10,'-')


func_var <- function(...){
  var <- c(...)
  for (i in var){
    cat (i, '\t')
  }
}
func_var(1, 2)
func_var(1, 2, 3)
func_var(1, 2, 3, 4, 100)

x <- 3
func1 <- function(){
  x<- 5
  print(x)
}
func1()
print(x)

func2 <- function(){
  x <<- 100
  print(x)
}
func2()
print(x)

add_x <- function(x){
  function(y){
    return(x+y)
  }
}

addx <- add_x(3)
addx(2)












< !DOCTYPE
html >

< html >
< head >
< link
rel = "stylesheet"
type = "text/css"
href = "./css/mainStyle.css" >
< meta
http - equiv = "Content-Type"
content = "text/html; charset=UTF-8" >
< title > 컴잘알 < / title >
< / head >
< body >
< div
id = "mainBox" >
< div
id = "titleBox" >
< a
href = "./main.jsp" > 컴잘알 < / a >
< / div >
< div
id = "navigationBox" >

< a
href = "./member/memberLoginForm.jsp"


class ="basicButton" > 로그인 < / a >

< a
href = "./member/memberJoinForm.jsp"


class ="basicButton" > 회원가입 < / a >

< a
href = "./study/study.jsp"


class ="basicButton" > 공부방 < / a >

< a
href = "./talk/talkListForm.jsp"


class ="basicButton" > 대화방 < / a >

< a
href = "./notice/noticeListForm.jsp"


class ="basicButton" > 공지사항 < / a >

< / div >
< hr
style = "border: 2px solid black;" >
< div


class ="slideshow-container" > < br >

< div


class ="mySlides fade" >

< img
src = "./image/mainOne.jpg"
style = "width:100%" >
< / div >
< div


class ="mySlides fade" >

< img
src = "./image/mainTwo.jpg"
style = "width:100%" >
< / div >
< div


class ="mySlides fade" >

< img
src = "./image/mainThree.jpg"
style = "width:100%" >
< / div >
< a


class ="prev" onclick="plusSlides(-1)" > &  # 10094;</a>

< a


class ="next" onclick="plusSlides(1)" > &  # 10095;</a>

< / div >
< br >
< div
style = "text-align:center" >
< span


class ="dot" onclick="currentSlide(1)" > < / span >

< span


class ="dot" onclick="currentSlide(2)" > < / span >

< span


class ="dot" onclick="currentSlide(3)" > < / span >

< / div >
< script >
var
slideIndex = 1;
showSlides(slideIndex);

function
plusSlides(n)
{
    showSlides(slideIndex += n);
}

function
currentSlide(n)
{
    showSlides(slideIndex=n);
}

function
showSlides(n)
{
    var
i;
var
slides = document.getElementsByClassName("mySlides");
var
dots = document.getElementsByClassName("dot");
if (n > slides.length)
{slideIndex = 1}
if (n < 1) {slideIndex = slides.length}
for (i = 0; i < slides.length; i++) {
slides[i].style.display = "none";
}
for (i = 0; i < dots.length; i++) {
dots[i].className = dots[i].className.replace(" active", "");
}
slides[slideIndex-1].style.display = "block";
dots[slideIndex-1].className += " active";
}
< / script >
< br >
< div
id = "viewBox" >
< table >
< tr >
< td


class ="head" colspan="4" >


최근
공지사항
< / td >
< / tr >
< tr >
< td


class ="middle" >


아이디
< / td >
< td


class ="middle" style="width: 320px;" >


제목
< / td >
< td


class ="middle" style="width: 180px;" >


게시글
등록일
< / td >
< / tr >

< tr >
< td


class ="tail" style="text-align: center;" > 나동빈 < / td >

< td


class ="tail" > < a href="./notice/noticeViewForm.jsp?noticeID=4" > < b > 자바 기초 프로그래밍 강좌를 완강했습니다.< / b > < / a > < / td >

< td


class ="tail" style="text-align: center;" > 2017-05-02

< / tr >

< tr >
< td


class ="tail" style="text-align: center;" > 나동빈 < / td >

< td


class ="tail" > < a href="./notice/noticeViewForm.jsp?noticeID=1" > < b > 컴잘알에 오신 것을 환영합니다.< / b > < / a > < / td >

< td


class ="tail" style="text-align: center;" > 2016-11-28

< / tr >

< / table >
< / div >
< div


class ="studyViewBox" >

< table >
< tr >
< td


class ="head" colspan="3" >


최근
강의
< / td >
< / tr >
< tr >
< td


class ="middle" >


선생님
< / td >
< td


class ="middle" style="width: 560px;" >


제목
< / td >
< td


class ="middle" style="width: 180px;" >


게시글
등록일
< / td >
< / tr >

< tr >
< td


class ="tail" style="text-align: center;" > 나동빈 < / td >

< td


class ="tail" > < a href="./study/study.jsp?studyID=85" > < b > C언어 기초 프로그래밍 강좌 20강 - 동적 메모리의 활용 (C Programming Tutorial For Beginners 2017  # 20) </b></a></td>
< td


class ="tail" style="text-align: center;" > 2017-05-15

< / tr >

< tr >
< td


class ="tail" style="text-align: center;" > 나동빈 < / td >

< td


class ="tail" > < a href="./study/study.jsp?studyID=84" > < b > C언어 기초 프로그래밍 강좌 19강 - 동적 메모리 (C Programming Tutorial For Beginners 2017  # 19) </b></a></td>
< td


class ="tail" style="text-align: center;" > 2017-05-15

< / tr >

< tr >
< td


class ="tail" style="text-align: center;" > 나동빈 < / td >

< td


class ="tail" > < a href="./study/study.jsp?studyID=83" > < b > C언어 기초 프로그래밍 강좌 18강 - 파일 입출력 (C Programming Tutorial For Beginners 2017  # 18) </b></a></td>
< td


class ="tail" style="text-align: center;" > 2017-05-15

< / tr >

< tr >
< td


class ="tail" style="text-align: center;" > 나동빈 < / td >

< td


class ="tail" > < a href="./study/study.jsp?studyID=82" > < b > C언어 기초 프로그래밍 강좌 17강 - 구조체의 활용 ② (C Programming Tutorial For Beginners 2017  # 17) </b></a></td>
< td


class ="tail" style="text-align: center;" > 2017-05-15

< / tr >

< tr >
< td


class ="tail" style="text-align: center;" > 나동빈 < / td >

< td


class ="tail" > < a href="./study/study.jsp?studyID=81" > < b > C언어 기초 프로그래밍 강좌 16강 - 구조체의 활용 ① (C Programming Tutorial For Beginners 2017  # 16) </b></a></td>
< td


class ="tail" style="text-align: center;" > 2017-05-15

< / tr >

< / table >
< / div >
< / div >
< / body >
< / html >
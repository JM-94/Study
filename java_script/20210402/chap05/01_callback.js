function callThreeTimes(callback) //함수를 정의(선언)한것
{
    for(let i = 0; i<3; i++)
    callback(i)
}
function print(i)//함수를 정의(선언)한 것
{
    console.log(i+"번째")
}

//얘네 두 개 결과 똑같음
callThreeTimes(print)

callThreeTimes(         //함수를 호출한 것
    function(i){
        console.log(i+"번째")
    }
)
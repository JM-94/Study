function callThreeTime(callback)
{
    for(let i =0; i<3; i++)
    callback(i)
}

function print(i)
{
    console.log(`${i}번째 함수 호출`)
}
callThreeTime(print)//함수 명을 넣은 것


callThreeTime// 함수를 통짜바리로 그대로 넣은거
(
    function(i)
    {
        console.log(`${i}번째 함수 호출`)
    }
)
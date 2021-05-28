//배열에 대해서 제공되는 함수 3가지
//forEach, map, filter

let numbers = [273,52,103,32,57]

//forEach : 배열의 각각의 요소에 접근하게 해주는 메소드(함수랑 같은 말)
numbers.forEach(function(value, index, array){//보통 'array'는 생략함
    console.log(`${index}번째 요소 : ${value}`)
})
// numbers = numbers.map(function(value,index,array){
//     return value*value
// })
//밑에꺼랑 위에거는 같다
// const power = function(value,index,array)
// {
//     return value*value

// }
function power(value,index,array)
{
    return value*value
}
numbers = numbers.map(power)
console.log(numbers)


// number.forEach(console.log)
// console.log(number)


//filter
//map이랑 마찬가지이긴 한데, 측정 조건을 만족하는 녀석만 추려내서 새로운 배열 만듦
const numbers2 = [0,1,2,3,4,5]
const eventNumbers = numbers2.filter(function(value)
{
    return value%2 === 0
})
console.log("원본 : "+numbers2)
console.log("원본 : "+eventNumbers)


//화살표 함수

const arrowFunc = (value) => value%2 ===0 //(function(value){return value%2 === 0})를 => 로 생략
const eventNumbers2 = numbers2.filter(arrowFunc)
console.log("원본 : "+numbers2)
console.log("원본 : "+eventNumbers)


//연속적으로 사용 가능
let numbersEx = [0,1,2,3,4,5,6,7,8,9]
numbersEx.filter((value) => value%2 === 0).forEach((value)=>{console.log(value)}  )
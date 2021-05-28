let product = {
    제품명: '망고', // 제품명 -> 키(속성)
    유형: '당절임',
    원산지: '필리핀'
}
console.log(product)
console.log(product.제품명)
console.log(product.유형)
console.log(product.원산지)
let student_idj = {
    name: '안준모',
    hakbeon: 19940407,
    '하고 싶은 것': '집에가고 싶다',
    eat: function (food) {
        console.log(food + '가 점심메뉴')
    },
    numbers: [1, 2, 3, 4, 5],
    introdce: function () {
        console.log('내이름은 ' + this.name + '입니다.')
    }
}
console.log(student_idj)
console.log(student_idj.name)
console.log(student_idj.hakbeon)
console.log(student_idj['하고 싶은 것'])
student_idj.eat('맘스터치')
console.log(student_idj.numbers)
student_idj.introdce()

student_idj.newFunc = () => {console.log('배열처럼 뒤늦게 추가하는 거 됩니다.')}
student_idj.newFunc()
student_idj.직업 = '백수'
console.log(student_idj.직업)

delete student_idj.hakbeon
//키(속성)을 지우기 가능
console.log(student_idj)



const 한빛 =
{
    name : '혼자 공부하는 파이썬',
    price : 18000,
    publisher : '한빛미디어'    
}
console.log("한빛미디어 책 : "+한빛.name)

let 대환장파티 = 
{
    배열 : [
        ()=>{console.log('ㅋㅋ')}, 
        student_idj, 
        [1,3,4,],
        {이름 : '안준모', 나이 : 28}
    ],
    한빛
}


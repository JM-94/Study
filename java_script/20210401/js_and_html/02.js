// 개미수열
/*charAt 이해용 코드
let ex = "안준모"
let one1 = ex.charAt(0)
let one2 = ex.charAt(1)
let one3 = ex.charAt(2)
console.log(ex)
console.log(one1)
console.log(one2)
console.log(one3)
*/

let start = "1"
for (let i =0; i<20; i++)
{
    console.log((Number(i)+1)+"번 째 : "+start)
    let end = "" //누적 변수
    let number = start.charAt(0) //읽을 숫자
    let count = 0 //읽은 숫자의 개수
    for(let j =0; j<start.length; j++)
    {
        if(number != start.charAt(j))
        {
            end = end + number + count
            count = 1
            number = start.charAt(j)
        }
        else
            count++ 
    }
    end = end +number + count
    start = end

}
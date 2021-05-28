function sample(...items)//... -> 매개변수의 갯수가 몇개인지 나도모른다
{
    console.log(items)
}
sample(1)
sample(1,2)
sample(1,2,3)
sample(1,2,3,4)
sample([1,2,3,4])

function sample2(a,b,...items)
{
    console.log(a,b,items)
}

sample2(1)  //1 undefined []
sample2(1,2)//1 2 []
sample2(1,2,3)// 1 2 [3]
sample2(1,2,3,4)//1 2 [3,4]
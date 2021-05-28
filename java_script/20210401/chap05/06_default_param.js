function master(name,age)
{
    // name = typeof(name) == undefined ? name : '안준모'
    // age = typeof(age) == undefined ? age : 10
    name = name || '안준모'
    age = age || 10


    console.log('반가워요 ' + name +'님')
    console.log('당신의 나이는 ' + age + '세 입니다.')
}
master() //기본 매개변수 값인 '안준모'을 사용함
master('민성',18)
master('동욱')
const todos = ['우유 구매', '업무', '필라테스']

for (const i in todos) {
    console.log(`${Number(i)+1}번째 할 일 : ${todos[i]}`)
    // == console.log(i+"번째 할 일 "+todos[i])   같다
}
for (const work of todos) // for of
{
    console.log(work)
}

for (let i = 0; i < todos.length; i++)
    console.log("할 일 : " + todos[i])

    
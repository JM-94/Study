const itemEx = ['사과','바나나','귤','바나나','강민주']

//바나나를 전부다 지우려면?
console.log(itemEx)
while(itemEx.indexOf('바나나')!=-1)
{
    itemEx.splice(itemEx.indexOf('바나나'),1)
}
console.log(itemEx)
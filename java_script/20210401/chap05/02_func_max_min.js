function min(array)
{
    let output =array[0]
    for(const item of array)
    {
        if(output>item) //item이 더 작다면
            output = item
    }
    return output
}

function max(array)
{
    let output =array[0]
    for(const item of array)
    {
        if(output<item) //item이 더 작다면
            output = item
    }
    return output
}
const testArray = [52,275,32,10,54,35]
console.log(`${testArray}중에서`)
console.log(`최댓값 = ${max(testArray)}`)
console.log(`최솟값 = ${min(testArray)}`)

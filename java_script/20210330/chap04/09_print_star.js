let output = ''

// for (let i = 1; i<10; i++)
// {
//     for(let j=0; j<i; j++)
//     {
//         output += '*'
//     }
//     output += '\n'
// }
// console.log(output)




// for (let i = 1; i<10; i++)
// {
//     for(let j=0; j<10-i; j++)
//     {
//         output += ' '
//     }
//     for (let j = 0; j<i; j++)
//     {
//         output += '*'
//     }
//     output += '\n'
// }
// console.log(output)



for(let i=1;i<15;i++)
{
    for(let j=15; j>i;j--)
    {
        output += ' '
    }
    for(let k=0;k<2*i-1;k++)
    {
        output += '*'
    }
    output += '\n'
}
console.log(output)


for(let i=15;i>=1;i--)
{
    for(let j=15; j>i;j--)
    {
        output += ' '
    }
    for(let k=0;k<2*i-1;k++)
    {
        output += '*'
    }
    output += '\n'
}
console.log(output)
#include <stdio.h>

void main(){
    
    int a = 10;
    int *b = &a;
    // printf("b = %d\n", b);
    // printf("b+1 = %d\n", b+1);
    // printf("*(b+1) = %d\n", *(b+1));
    // printf("*(b)+1 = %d\n", *(b)+1);
    *b +=30;
    printf("*b=%d\n",*b);
    *b = *b +30;
    printf("*b=%d",*b);


    
}
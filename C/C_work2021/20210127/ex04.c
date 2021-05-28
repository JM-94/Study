#include <stdio.h>

void main(){

    int a[5] = {1,2,3,4,5};
    int *ptr = &a[0];  // =a;

    printf("ptr = %d\n", ptr);
    printf("ptr[0] = %d\n", ptr[0]);
    printf("*ptr = %d\n", *ptr);


    printf("ptr[1] = %d\n", ptr[1]);
    printf("*ptr = %d\n", *(ptr+1));
    

}
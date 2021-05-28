#define ADD 1
#define SQUARE(X) ((X)*(X))

#include<stdio.h>


void main(){

    int a = 10 + ADD;

    printf("a = %d\n",a);

    printf("SQUARE = %d\n",SQUARE(5));
    printf("SQUARE = %d\n",SQUARE(3+2));


}



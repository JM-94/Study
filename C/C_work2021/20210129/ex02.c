#include<stdio.h>

void main(){
    int num1 = 10;
    int num2 = 20;
    int num3 = 30;
    printf("num1 = %d\n", num1);
    printf("num2 = %d\n", num2);
    printf("num3 = %d\n", num3);

   
    int l_num2 = num2;
    num2 = num1;
    int l_num3 = num3;
    num3 = l_num2;
    num1 = l_num3;


    printf("num1 = %d\n", num1);
    printf("num2 = %d\n", num2);
    printf("num3 = %d\n", num3);
}
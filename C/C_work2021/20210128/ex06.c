#include <stdio.h>

int value(int num){

    return num*num;
}

void refer(int *ptr){

   int num = *ptr;
   *ptr = num*num;
}

void q1(){
    
    int num;
    printf("입력 : " );
    scanf("%d",&num);
    printf("Q1\n");
    printf("Value : %d\n", value(num));
    refer(&num);
    printf("reference : %d\n", num);
    printf("\n");
    
}


void swap3(int *num1,int *num2,int *num3){

    int temp = *num3;
    *num3 = *num2;
    *num2 = *num1;
    *num1= temp;
}

void q2(){
    int num1 = 1, num2 = 2, num3= 3;
    
    printf("Q2\n");
    printf("%d %d %d\n",num1,num2,num3);
    swap3(&num1,&num2,&num3);
    printf("%d %d %d", num1,num2,num3);

}



void main(){
     q1();
    q2();
    
}
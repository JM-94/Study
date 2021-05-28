#include <stdio.h>

void doA(int *a){
    *a = 20;
    printf("doA a value a = %d \n", a);
    printf("doA a point value *a = %d \n",*a);
}

void main(){
    int a = 10;
    int num1=0,num2=0;

    
    
    printf("main address is\n");
    printf("&a=%d\n",&a);
    
    printf("main value is\n");
    printf("a=%d\n",a);


    doA(&a);

}
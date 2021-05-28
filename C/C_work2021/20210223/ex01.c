#include<stdio.h>
#include<stdlib.h>


static int a =10;
void doA(){
    a=20;
    int b =20;
    int c = 40;
    static int e =50;
}
int main(){
    a= 30;
    int b = 20;
    int c = 30;
    void * ptr1 = malloc(4);
    void * ptr2 = malloc(8);

    printf("ptr1 = %d\n",ptr1);
    printf("ptr2 = %d\n",ptr2);

    free(ptr1);
    free(ptr2);

}
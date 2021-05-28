#include<stdio.h>


// 스택영역 geap영역 데이터 영역
void main(){
    int a = 20;
    void *vp = &a;
    int *ip;

    printf("&a = %d\n", &a);
    printf("vp = %d\n", vp);

    ip = (int*)vp;
    *ip = 20;

    printf("*ip =%d\n", *ip);
    printf("ip = %d",ip);


}
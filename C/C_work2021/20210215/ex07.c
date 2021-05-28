// p.458 22-1
#include<stdio.h>

struct employee{
    char name[20]; //이름
    char num[20];   //주민
    int mon;    //급여
};

int main(void){
    struct employee man1;
    
    printf("종업원 이름 : ");
    scanf("%s", man1.name);
    printf("주민등록번호 : "); 
    scanf("%s", man1.num);
    printf("급여정보 : ");
    scanf("%d", &man1.mon);

    printf("\n");
    
    printf("종업원 이름 : %s \n", man1.name);
    printf("주민등록번호 : %s \n", man1.num); 
    printf("급여정보 : %d \n", man1.mon); 
    return 0;

}
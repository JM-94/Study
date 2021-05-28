//p.463 22-2

#include<stdio.h>

struct employee{
    char name[20]; //이름
    char num[20];   //주민
    int mon;    //급여

};


int main(){
    struct employee arr[3];
    int i;
    for(i=0; i<3; i++){
    printf("종업원 이름 : ");
    scanf("%s", arr[i].name);
    printf("주민등록번호 : "); 
    scanf("%s", arr[i].num);
    printf("급여정보 : ");
    scanf("%d", &arr[i].mon);
    }

    printf("\n");
    
    for(i=0; i<3; i++){
    printf("종업원 이름 : %s \n", arr[i].name);
    printf("주민등록번호 : %s \n", arr[i].num); 
    printf("급여정보 : %d \n", arr[i].mon); 
    }
    return 0;

}

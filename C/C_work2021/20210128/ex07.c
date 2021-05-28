#include <stdio.h>
/*
//홀수
void x(int *ptr){
    int cnt=0;
    int x_arr[10];
    printf("홀수 출력 : ");
    for(int i=0;i<10;i++)
        if(((ptr[i]) % 2) == 1){
            x_arr[cnt] = ptr[i];
            cnt++;
        }
        printf("%d", x_arr[0]);
        for (int i = 1; i<cnt; i++){
            printf(", ");
            printf("%d",x_arr[i]);
        }
        printf("\n");
}
//짝수
void y(int *ptr){
    int cnt=0;
    int y_arr[10];
    printf("짝수 출력 : ");
    for(int i=0;i<10;i++)
        if(((ptr[i]) % 2) == 0){
            y_arr[cnt] = ptr[i];
            cnt++;
        }
        printf("%d", y_arr[0]);
        for (int i = 1; i<cnt; i++){
            printf(", ");
            printf("%d",y_arr[i]);
        }
        printf("\n");
}

void main(){
    int arr[10];
    printf("정수 입력하자\n");
    for(int i = 0; i < 10; i++){
        printf("정수 입력 : ");
        scanf("%d", &arr[i]);
    }
    x(arr);//홀수
    y(arr);//짝수
}*/



void main(){
    int arr[10];


    //한줄
    //int *fip = &arr[0];
    //두줄
    int *fip;
    fip = &arr[0];

    
    int *eip = &arr[9];
    int i = 0;
    while(i<10){
        //printf("%d",i);
        int temp = 0;
        printf("정수입력");
        scanf("%d",&temp);
        //홀수
        if(temp%2==1){
            *fip = temp;
             fip = fip+1;  //   주소값 5752 -> 5756
        }
        //짝수
        else{
            *eip = temp; 
            eip =eip-1; //  주소값 5792 -> 5788
        }
        i++;
    }
    for(i=0;i<10;i++){
        printf("arr[%d]= %d ",i,arr[i]);
    }
}
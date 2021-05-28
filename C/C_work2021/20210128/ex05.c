#include <stdio.h>

void doA(int *p){
    
    printf("\n");
    printf("*p = %d\n",*p);
    printf("\n");
    *p = 20;

}


void main(){
    int arr[3] = {1,2,3};
    int i = 0;
    for(;i<3;i++){
        printf("arr[%d] = %d \n", i, arr[i]);

    }

    doA(arr); // arr[0] 주소값을 넘겨줌          =  doA(&arr[0]);
    //콜바이 랩퍼런스   주소값 넘겨주기
    //콜바이 벨류 구분하기  값을 복사해서 넘겨주기
    for (i=0;i<3;i++){
        printf("arr[%d] = %d \n", i, arr[i]);
    }
}
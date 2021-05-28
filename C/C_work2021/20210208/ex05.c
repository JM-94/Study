
//p.406 도전1
#include<stdio.h>

void main(){
    int arr[4][4] = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16};
    int i,j;
    for(i=0;i<4;i++){
        printf("\n");
        for(j=0;j<4;j++)
        printf("%d  ",arr[i][j]);
    }
 //1
    printf("\n");
    for(i=0;i<4;i++){
        printf("\n");
        for(j=0;j<4;j++)
        printf("%d  ",arr[3-j][i]);
    }
//2
    printf("\n");
    for(i=0;i<4;i++){
        printf("\n");
        for(j=0;j<4;j++)
        printf("%d  ",arr[3-i][3-j]);
    }
//3
    printf("\n");
    for(i=0;i<4;i++){
        printf("\n");
        for(j=0;j<4;j++)
        printf("%d  ",arr[j][3-i]);
    }


}
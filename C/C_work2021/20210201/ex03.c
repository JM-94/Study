#include<stdio.h>

void maxandmin(int *arr,int size, int **mxptr,int **mnptr){
    int *max, *min;
    int i;

    max = min =&arr[0];
    for(i=0;i<size;i++){
        if(*max <arr[i])
        max=&arr[i];
        if(*min >arr[i])
        min=&arr[i];
        
    }
    *mxptr=max;
    *mnptr=min;
}



void main(){
    int *maxptr;
    int *minptr;
    int arr[5];
    int i;

    for (i=0;i<5;i++){
        printf("정수입력 : ");
        scanf("%d",&arr[i]);
    }
    maxandmin(arr, sizeof(arr)/sizeof(int),&maxptr,&minptr);
    printf("최대 : %d, 최소 : %d\n",*maxptr,*minptr);
  
}
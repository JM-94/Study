#include<stdio.h>

void bubblesort ( int ary[], int len)

void main(){

    int arr[4]={3,2,4,1};
    int i;

    bubblesort(arr, sizeof(arr)/sizeof(int));
    for(i=0;i<4;i++)
        printf("%d",arr[i]);

    printf("\n");
    return 0;

}

void bubblesort(int ary[], int len){

    int i,j;
    int temp;

    for(i=0; i<len-1;i++){
        for (j=0;,j<(len-i);j++){
            if(ary[j]>ary[j+1]){
                temp = ary[j];
                ary[j] = ary[j+1];
                ary[j+1] = temp;
            }
        }
    }
}
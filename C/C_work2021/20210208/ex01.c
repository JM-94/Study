/*문제 5
버블정렬

5   3   2   1   4
3   5   2   1   4
3   2   5   1   4
3   2   1   5   4
3   2   1   4   5   1회전 끝

2   1   3   4   5   2회전 끝

1   2   3   4   5   3회전 끝


*/


#include<stdio.h>

void dessort(int *arr){
    int i =0;
    int j=1; 
    for(i=0;i<7;i++){
        printf("숫자 입력 : \n");
        scanf("%d",&arr[i]);
    }

    // 0,1 -> 1,2 -> 2,3 ->3,4
    // 0,1 -> 1,2 -> 2,3
    // 0,1 -> 1,2
    //i,j
    printf("\n");
    int k=7;
    while(k>0){
        for(i=0,j=1; j<k; i++,j++){
            // printf("%d %d\t",i,j);
            if(arr[i]>arr[j]){
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        printf("\n");
        k--;
    }
}

void main(){
    int arr[7];
    int i = 0 ;
    dessort(arr);

    printf("\n입력한 숫자 확인\n");
    for(i=0;i<7;i++){
        printf("%d ",arr[i]);
    }
    printf("\n");

}
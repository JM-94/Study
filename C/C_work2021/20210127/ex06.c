#include <stdio.h>

void n1(){
    int arr[5] = {1,2,3,4,5};
    int *ptr = arr, i;  //  int *p; p = arr; 

    for (i = 0; i < 5; i++)
    {
        *ptr += 2;
        ptr++;
    }
    for(i=0; i<5; i++)
        printf("%d\n", arr[i]);
        printf("\n");
        return 0;

}

void s1(){
     int arr[5] = {1,2,3,4,5};
    int *ptr = arr, i;
    printf("s1\n");
    for(i=0; i<5; i++){
        printf("arr[%d] = %d\n",i,arr[i]);
        printf("*(arr+%d) = %d\n",i,*(arr+i));
    }
    printf("\n");
}


void n2(){
     int arr[5] = {1,2,3,4,5};
     int *ptr = arr, i;

      for (i = 0; i < 5; i++)
        {
            *(ptr+i) += 2;            
        }
        for(i=0; i<5; i++)
            printf("%d\n", arr[i]);
            printf("\n");
            

        return 0;
        

}

void s2(){
    int arr[5] = {1,2,3,4,5};
     int *ptr = arr, i;
    printf("s2\n");
      for (i = 0; i < 5; i++)
        {
            arr[i] = arr[i]+2;            
        }
        for(i=0; i<5; i++)
            printf("%d\n", arr[i]);
            printf("\n");
            
    printf("\n");
        return 0;
}

void n3(){
     int arr[5] = {1,2,3,4,5};
     int *ptr = &arr[4], i, total = 0;

    
     for (i=0; i<5; i++)
        total += *(ptr--);
    printf("%d\n",total);
    printf("\n");
   
}
void s3(){
    int arr[5] = {1,2,3,4,5};
    int *ptr = &arr[4], i, total = 0;
    printf("s3\n");




}

void n4(){
     int arr[6] = {1,2,3,4,5,6};
    int * ptr1 = &arr[0];
    int * ptr2 = &arr[5];
    int x,temp;

    for(x=0; x<3; x++)
    {
        temp = *ptr1;
        *ptr1 = *ptr2;
        *ptr2 = temp;
        ptr1 += 1;
        ptr2 -= 1;

    }

    for (x=0; x<6; x++)
        printf("%d\n",arr[x]);
        printf("\n");
    return 0;
}


void s4(){
    int arr[6] = {1,2,3,4,5,6};
    int *ptr1 = &arr[0];
    int *ptr2 = &arr[5];
    int i =0;
printf("s4\n");
    for(;i<3;i++){
        //swap
        int temp = *(ptr1+i);       //arr[0]을 temp에 담아라
        // 1,2,3,4,5,6
        *(ptr1+i) = *(ptr2-i);
        //6,2,3,4,5,6
        *(ptr2-i) = temp;
        //6,2,3,4,5,1

    }
    //확인하는 for구문
    for(i=0;i<6;i++){
        printf("arr[%d] = %d\n", i, arr[i]);
    }
    printf("\n");


   

    *(ptr1+1) = *(ptr2-1);

}

void main(){
    n1();
    s1();
    n2();
    s2();
    n3();
    s3();
    n4();
}
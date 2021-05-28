// p.329 도전4
#include<stdio.h>

void main(){


    char arr[100]; // abcde'\0'
    char brr[100]; // edcba'\0'
    int input_len = 0;
    int i = 0;

    printf("글자 입력 : ");
    scanf("%s",arr);// arr = &arr[]

    printf("arr = %s\n", arr);
    while(1){
        // arr[0] = a, arr[1] = b, arr[2] = c, arr[3] = d, arr[4] = '\0'

        if(arr[i]=='\0'){
            input_len = i;
            break;
        }
        i++;
    }
    printf("입력한 문자열 길이 input_len = %d\n", input_len);
    brr[input_len] = '\0';

    int j = input_len-1;
    for(i=0; i<input_len;i++,j--){
        brr[j]=arr[i];
    }

  //  printf("%s",brr);
   int chk =1;
   for(i=0;i<input_len;i++){
       if(arr[i] != brr[i]){
           chk = 0;
           printf("회문이 아닙니다.");
           break;
       }
   }
   if(chk){
       printf("회문입니다.");
   }

}
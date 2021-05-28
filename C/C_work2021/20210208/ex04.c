#include<stdio.h>

void main (int a, char *b[]){
    printf("a = %d\n", a);
    for (int i =0; i<a; i++){
        printf("b= %s\n",b[i]);
    }
}
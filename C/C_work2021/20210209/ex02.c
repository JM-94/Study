#include<stdio.h>

void main(){
    int ch1,ch2;

    ch1 = getchar();
    ch2 = fgetc (stdin);

    putchar(ch1);
    fputc(ch2,stdout);

    
}
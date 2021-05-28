#include<stdio.h>

int main(void){
    
    FILE * fp = fopen("simple.txt", "wt");

    if (fp == NULL){
        puts("파일생성오픈실패");
        return -1;
    }

    fputc('A', fp);
    fputc('B', fp);
    fputc('\n', fp);
    fputc("ABCD \n", fp);
    fputc("ABCD \n", fp);
    fclose(fp);
    return 0;
}
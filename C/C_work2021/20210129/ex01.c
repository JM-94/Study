#include <stdio.h>
// ctrl + k + f 자동 정렬
// shift + delete 한줄삭제
// ctrl + k + c 주석설정 ctrl + k + u 주석설정 해제


void doA(int a){
	printf("doA() start \na = %d\n",a);
	a = 20;
	printf("a = %d\ndoA() end \n",a);
}

void doB(int *b){
	printf("b = %d\n",b);
	printf("b = %d\n",*b);
	*b= 10;
	*(b+1) = 20;
	int i =0;
	for(i=0; i<10; i++){
		printf("*(b+%d) = %d\n",i, *(b+i));
	}
}

int doC(int a){
	a = 20;
	return a*a;
}

void main(){
	int i =0;
	int a = 10;
	int b[10] = {1,2,3,4,5,6,7,8,9,10};
	doA(a);
	printf("main a = %d\n",a);
	doB(&b[0]);
	for(i=0; i<10; i++){
		printf("*(b+%d) = %d\n",i, *(b+i));
	}
	printf("a = %d\n",a);
	a = doC(a);
	printf("a = %d\n",a);
}
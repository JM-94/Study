#include <stdio.h>

int dan(void)
{
	int num1, num2, num3, num4;

	printf("정수 입력 : ");
	scanf_s("%d", &num1);    // &num1은 scanf의 num1의 주소값을 바꾼다
	printf("정수 입력 : ");
	scanf_s("%d", &num2);

	if (num1 > num2){
		for (num3 = num2; num3 <= num1; num3++)	{
			for (num4 = 1; num4 < 10; num4++){
				printf("%d * %d = %d\n", num3, num4, num3 * num4);
			}
			printf("\n");
		}
	}
	else{
		for (num3 = num1; num3 <= num2; num3++)	{
			for (num4 = 1; num4 < 10; num4++){
				printf("%d * %d = %d\n", num3, num4, num3 * num4);

			}
			printf("\n");
		}
	}
	return 0;
}

int n2(){
	int num;
	printf("정수입력 : ");
	scanf_s("%d", &num);
	printf("2의 %d승은 %d\n", num, n3(num));
	return 0;
}

int n3(int num){
	if (num == 0)
		return 1;
	return n3 (num - 1) * 2;
}

int p3(){
	int num1 = 10, num2 = 20;
	int *ptr1 = &num1, *ptr2 = &num2;
		
	(*ptr1) += 10;
	(*ptr2) -= 10;

	ptr1 = num2;
	ptr2 = num1;
	printf("ptr1 : %d \nptr2 : %d \n", ptr1,ptr2);
	return 0;

}

int main() {
	//dan();
	//n2();
	p3();
}
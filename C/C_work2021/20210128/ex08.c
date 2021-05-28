#include <stdio.h>

/*
void trans(int num);

int main(void) {
	int num;
	printf("10진수 정수 입력: ");
	scanf("%d", &num);
	trans(num);
}

void trans(int num) {
	if (num / 2 == 1) {
		printf("%d", num/2);
	}
	else {
		trans(num / 2);
	}
	printf("%d", num % 2);
}
*/


void main(){
    int arr[100];
    int cnt=0;
//12
// arr[0] arr[1] arr[2] arr[3]
//  1       1      0      0
//  0       0      1	  1
// arr[0] =0
// arr[0] ==0 ->arr[1] =0
// arr[0] ==0
    int input_number = 0;
    int rema_number = 0;

    printf("정수 입력\n");
    scanf("%d",&input_number);
	/*while 문 한번
		intput_number = 12 -> 6 -> 3
		temp_value = 6 -> 3 -> 1
		cnt = 0 -> 1 -> 2 -> 3 -> 4
		arr[0] = 0, arr[1] = 0, arr[2] = 1, arr[3] = 1
	*/

    printf("intput_number = %d\n", input_number);
    while (input_number > 1){
        rema_number = input_number %2;

		arr[cnt] = rema_number;
		cnt++;


		int temp_value = input_number/2;
		if(temp_value<2){
			arr[cnt] = temp_value;
			cnt++;
			break;
		}
	
        input_number = temp_value;
			

    }
	//역순 출력
	//	cnt = 0 -> 1 -> 2 -> 3 -> 4
	//	arr[0] = 0, arr[1] = 0, arr[2] = 1, arr[3] = 1
	int i=0;
	// i--	==	i=i-1	==	i-=1
	for (i=cnt-1;i>-1;i--){  // 3 2 1 0
		printf("arr[%d] = %d\n", i,arr[i]);
	}
}
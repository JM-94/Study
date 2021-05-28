#include <stdio.h>

#include "cal.h"
#ifndef __MSTRUCT_H__
#define __MSTRUCT_H__
#include "mstruct.h"
#endif
/*
    학생관리프로그랩.. 파일에 저장..
    fwrite() 구조체
    fread() 구조체
*/

void main (){

    int x;
    int area;

    printf("사각형의 넓이를 구합니다. 길이 입력 : ");
    scanf("%d",&x);

    area = c_square(x);
    printf("넓이는 = %d",area);


}






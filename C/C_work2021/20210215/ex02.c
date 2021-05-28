#include<stdio.h>
#include<math.h>

struct point{
    int xpos;
    int ypos;
};

void main(){
    struct point pos1, pos2;

    double distance;
    fputs("point1 pos : ", stdout);
    scanf("%d %d", &pos1.xpos, &pos1.ypos);
    
    fputs("point2 pos : ", stdout);
    scanf("%d %d", &pos2.xpos, &pos2.ypos);
    
    /*두 점간의 거리 계산 공식*/
    distance=sqrt((double)((pos1.xpos-pos2.xpos) * (pos1.xpos-pos2.xpos)+(pos1.ypos-pos2.ypos) * (pos1.ypos-pos2.ypos)));

    printf("두 점의 거리는 %g 입니다.\n", distance);
   
    printf("sizeof(pos1) = %d\n",sizeof(pos1));
    printf("sizeof(pos2) = %d\n",sizeof(pos2));
    
    printf("&pos1 = %d\n",&pos1);
    printf("&pos1.xpos = %d\n",&pos1.xpos);
    printf("&pos1.ypos = %d\n",&pos1.ypos);
    printf("&pos2 = %d\n",&pos2);
    printf("&pos2.xpos = %d\n",&pos2.xpos);
    printf("&pos2.ypos = %d\n",&pos2.ypos);


}
#include<stdio.h>

typedef struct point
{
    int xpos;
    int ypos;
}Point;

void ShowPosition(Point pos){

    printf("pos.xpos = %d, pos.ypos = %d \n ", pos.xpos, pos.ypos);
}
Point makePoint(void){

    Point pos;
    printf("xpos = "); scanf("%d", &pos.xpos);
    printf("ypos = "); scanf("%d", &pos.ypos);
    return pos;
}




void main(){
    Point cPos = makePoint();
    ShowPosition(cPos);
    return 0;

}
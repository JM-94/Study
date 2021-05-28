#include <stdio.h>
#include<stdlib.h>
#include<time.h>

//p.410 도전5

void main(){
    // 사용자가 가위바위보 게임을 질때까지
    // C언어는 값이 0 false
    // 0이 아닌 모든 값이 true

    int seo = 1;
    // 1 가위 2 바위 3보
    int select = 0;
    int compu_select = 0;
    int win=0, draw=0, lose=0;
    while(seo){
        printf("뭐 낼래?");
        scanf("%d", &select);
    
    srand((int)time(NULL));
    compu_select = (rand()%3)+1;
    
    //1번
    // 1 2 3
        if(select == 1){
        //비김
            if(compu_select == 1){
               draw++;
               printf("당신의 선택은 가위 선택, 컴퓨터도 가위 선택\n");
            //졌음
           }else if(compu_select == 2){
                lose++;
                seo = 0;
               printf("당신의 선택은 가위 선택, 컴퓨터도 바위 선택\n");
        // 이겼음
            }else if(compu_select == 3){
                win++;
               printf("당신의 선택은 가위 선택, 컴퓨터도 보 선택\n");

            }   
        }
    }
    
    printf("게임의 결과 %d승 %d무 %d패", win, draw, lose);
}
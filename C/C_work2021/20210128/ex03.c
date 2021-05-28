#include <stdio.h>

void doA(){
    
    char *arrp[3] = {"aaa","bbb","ccc"};
    
    printf("arrp[0] = %d\n",arrp[0]);
    printf("arrp[1] = %d\n",arrp[1]);
    printf("arrp[2] = %d\n",arrp[2]);
    
    printf("\n");

    printf("*arrp[0] = %s\n", arrp[0]);
    printf("*arrp[1] = %s\n", arrp[1]);
    printf("*arrp[2] = %s\n", arrp[2]);

}

void main(){
 

    doA();
}
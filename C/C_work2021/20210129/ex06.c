#include <stdio.h>


//문제1------------------------------------------------
void q1()
{
    int arr[3][9];
    int i = 0, j = 0;
    for (i = 0; i < 3; i++)
        for (j = 0; j < 9; j++)
            arr[i][j] = (i + 2) * (j + 1);

    for (i = 0; i < 3; i++)
    {
        printf("\n");
        for (j = 0; j < 9; j++)
        {

            printf("%4d ", arr[i][j]);
        }
    }
}

//문제2------------------------------------------------
void q2()
{
    int arr[2][4] = {{1, 2, 3, 4}, {5, 6, 7, 8}};
    int brr[4][2];
    int i, j;

    for (int i = 0; i < 2; i++)
        for (int j = 0; j < 4; j++)
            brr[j][i] = arr[i][j];

    for (i = 0; i < 4; i++)
    {
        for (j = 0; j < 2; j++)
        {
            printf("%d ", brr[i][j]);
        }
        printf("\n");
    }
}

//문제3------------------------------------------------
int result[5][5];

void q4()//입력
{
    int sum;
    int i, j;
    for (i = 0; i < 4; i++)
    {
        sum = 0;
        printf("%d번째 학생 성적 : \n", i + 1);
        for (j = 0; j < 4; j++)
        {
            printf("과목 %d : ", j + 1);
            scanf("%d", &result[i][j]);
            sum += result[i][j];
        }
        result[i][4] = sum;
    }
}

void q5()//계산
{
    int sum = 0;
    int i, j;

    for (i = 0; i < 4; i++)
    {
        sum = 0;
        for (j = 0; j < 4; j++)
            sum += result[j][i];
        result[4][i] = sum;
        result[4][4] += sum;
    }
}

void q6()//출력
{
    int i, j;
    for (i = 0; i < 5; i++)
    {
        for (j = 0; j < 5; j++)
            printf("%3d ", result[i][j]);
        printf("\n");
    }
}

int q3()
{
   
    q4();
    q5();
    q6();
}

void main()
{

    //q1();
    //q2();
    q3();
}
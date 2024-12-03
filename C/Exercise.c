#include<stdio.h>
#include<math.h>
#include<stdlib.h>

void exercise_8(){
    int s = 1, n;
    printf("Enter The Number:");
    scanf("%d", &n);
    for(int i = 1; i <= n; i++){
        s *= i;
    }
    printf("RESULT: %d", s);
}

void exercise_9(){
    int n, s = 0;
    printf("Enter The Number:");
    scanf("%d", &n);
    for(int i = 1; i <= n; i++){
        s += pow(-1, i+1) * i;
    }
    printf("RESULT: %d", s);
}

void exercise_10(){
    int s = 0, n;
    do{
        printf("Enter The Number:");
        scanf("%d", &n);
        s += n;
    }while(n!=0);
    printf("RESULT: %d", s);
}

void exercise_11(){
    float r;
    printf("Enter The Radius:");
    scanf("%f", &r);
    float s = r * r * 3.14;
    float c = 2 * r * 3.14;
    printf("Result Circle Perimeter: %.1f", c);
    printf("\nResult Circle Area: %.1f", s);
}

void exercise_12(){
    float a, b, c;
    scanf("%f", &b);
    scanf("%f", &a);
    scanf("%f", &c);
    float p, area, per;
    if((a + b) > c && (a + c) > b && (b + c) > a ){
        p = (float)((a + b + c) / 2);
        area = sqrt(p * (p - a) * (p - b) * (p - c));
        per = a + b +c;
        printf("Triangle Perimeter: %.1f", per);
        printf("\nTriangle Area: %.1f", area);
    }else{
        printf("This is  Triangle ?");
    }
}

void exercise_13(){
    int x, y;
    printf("Enter X = "); scanf("%d", &x);
    printf("Enter Y = "); scanf("%d", &y);
    int s = 1;
    for(int i = 0; i < y; i++){
        s *= x;
    }
    printf("RESULT: %d", s);
}

void exercise_14(){
    float x1, x2, y1, y2;
    printf("Enter Y1 = "); scanf("%f", &y1);
    printf("Enter X2 = "); scanf("%f", &x2);
    printf("Enter y2 = "); scanf("%f", &y2);
    printf("Enter X1 = "); scanf("%f", &x1);
    float h = (y2 - y1) / (x2 / x1);
    float k = sqrt(pow((y2 - y1), 2) + pow((x2 - x1), 2));
    printf("\nKhoang Cach 2 Diem : %.1f", k);
    printf("\nHe So Goc: %.1f", h);
}

void exercise_15() {
    int i;
    for (i = 0; i <= 256; i++) {
        char character = i;
        printf("%c", &character);
    }
}
int main()
{
    int i;
    for(i=0; i<125;i++){
        char c = i;
        printf("%s ", &c);
    }
    // int x;
    // printf("\n[1].Exercise 8");
    // printf("\n[2].Exercise 9");
    // printf("\n[3].Exercise 10");
    // printf("\n[4].Exercise 11");
    // printf("\n[5].Exercise 12");
    // printf("\n[6].Exercise 13");
    // printf("\n[7].Exercise 14");
    // printf("\nEnter The Number: ");
    // scanf("%d", &x);
    // system("cls");
//     switch(x){
//         case 1:
//             exercise_8();
//             break;
//         case 2:
//             exercise_9();
//             break;
//         case 3:
//             exercise_10();
//             break;
//         case 4:
//             exercise_11();
//             break;
//         case 5:
//             exercise_12();
//             break;
//         case 6:
//             exercise_13();
//             break;
//         case 7:
//             exercise_14();
//             break;
//    }
    return 0;
}
#include<iostream>
using namespace std;
int main()
{
    int a = 100;
    int b = 15;
    int c = 0;
    while (a > b){
        c++;
        a -= b;
    }
    cout<<c;
    return 9;
}
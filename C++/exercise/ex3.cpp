#include<iostream>
using namespace std;
int main()
{
    int a = 100;
    int b = 5;
    int c = 0;
    while(b>0){
        c += a;
        b--;
    }
    cout<<c;
    return 0;
}
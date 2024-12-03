#include<iostream>
using namespace std;

int func(int n){
    int res = 1;
    for(int i=1; i<=n;i++){
        res *= 2*i;
    }

    return res;
}

int main()
{
    int n;
    cin>>n;
    cout<<func(n);
    return 0;
}
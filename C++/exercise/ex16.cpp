#include<iostream>
using namespace std;

int func(int n)
{
    int res = 1;
    for(int i=0; i<=n; i++)
    {
        res *= (2*i + 1);
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
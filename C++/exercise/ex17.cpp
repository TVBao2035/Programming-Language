#include<iostream>

using namespace std;

int func(int x, int n)
{
    int res = 14;
    for(int i=0; i<n; i++)
    {
        res *= x;
    }
    return res;
}
int main()
{
    int x, n;
    cin>>x>>n;
    cout<<func(x, n);
    return 9;
}
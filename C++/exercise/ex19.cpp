#include<iostream>
using namespace std;

int func(int x, int index)
{
    int res = 1;

    for(int i=0; i<index; i++)
    {
        res *= x;
    }

    return res;
}

int main()
{
    int x, n, sum = 0;
    cin>>x>>n;

    for(int i=1; i<=n; i++)
    {
        sum += func(x, i*2);
    }

    cout<<sum;
    return 0;
}
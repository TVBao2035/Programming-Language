#include<iostream>
using namespace std;
int func(int x, int index)
{
    int res = 1;
    index = index*2 + 1;
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
    for(int i=0; i<=n; i++)
    {
        sum += func(x, i);
    }
    cout<<sum;
    return 0;
}
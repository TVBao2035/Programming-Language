#include<iostream>
using namespace std;

int addFunc(int index)
{
    int res = 0;
    for(int i=0; i<=index;i++)
    {
        res += i;
    }

    return res;
}


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
    int n, x, sum = 0;
    cin>>x>>n;
    for(int i=1; i<=n; i++)
    {
        sum += (func(x,i)/addFunc(i));
    }
    cout<<sum;
    return 0;
}
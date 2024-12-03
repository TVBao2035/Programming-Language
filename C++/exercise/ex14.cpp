#include<iostream>
using namespace std;
int GiaiThua(int num)
{
    int res = 1;
    for(int i=1; i<=num; i++){
        res *= i;
    }

    return res;
}
int main()
{
    int n, sum = 0;
    cin>>n;
    for(int i=1; i<=n; i++){
        sum += GiaiThua(i);
    }
    cout<<sum;
    return 0;
}
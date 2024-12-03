#include<iostream>
using namespace std;

int main()
{
    int n, sum = 0;
    cin>>n;
    for(int i=0; i<=n; i++){
        for(int j=0; j<=i;j++){
            sum += j;
        }
    }

    cout<<sum;
    return 0;
}
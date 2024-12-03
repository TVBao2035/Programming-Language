#include<iostream>
using namespace std;

bool checkTriangle(int a, int b, int c){
    if(a + b > c && a + c > b && b + c > a) return true;

    return false;
}
int countCase(int arr[], int n){
    int count = 0;

    for (int i = 0; i < n - 2; i++)
    {
        for (int j = i + 1; j < n - 1; j++)
        {
            for (int z = j + 1; z < n; z++)
            {
                if (checkTriangle(arr[i], arr[j], arr[z])){
                    count++;
                }
            }
        }
    }
    return count;
}
int main(){

    int testcase;
    int res[100];
    do{
        cin>>testcase;
    }while(testcase < 1);
    for(int j=0; j<testcase; j++){
        int n;
        do
        {
            cin >> n;

        } while (n < 3);

        int arr[100];
        for (int i = 0; i < n; i++)
        {
            cin >> arr[i];
        }


        res[j] = countCase(arr, n);
    }
   

   for(int i=0; i<testcase; i++){
    cout<<res[i]<<endl;
   }
 
    return 0;
}
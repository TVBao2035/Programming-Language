#include<iostream>
#include<cmath>
using namespace std;

void enterMatrix(int matrix[][10], int n)
{
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            cout<<"enter element index of ["<<i<<"]["<<j<<"]:";
            cin>>matrix[i][j];
        }
    }
}

void displayMatrix(int matrix[][10], int n)
{
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            cout<<matrix[i][j]<<"   ";
        }

        cout<<endl;
    }
}


int length(int n)
{
    int count = 0;
    while(n > 0)
    {
        count++;
        n /= 10;
    }
    return count;
}


bool isArmstrong(int n)
{
    int sum = 0;
    int k = length(n);
    int i = n;
    while(i != 0)
    {
        int temp = i % 10;
     
        sum = sum +  pow(temp, k);
        i /= 10;
    }
    cout<<sum<<endl;
    return sum == n && length(n) == 3;
}

int sumArmstrong(int matrix[][10], int n)
{
    int sum = 0;
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            if(isArmstrong(matrix[i][j]))
            {
                sum += matrix[i][j];
            }
        }
    }

    return sum;
}


int TinhTongArmstrong(int a[][10],int n,int m)
{
    int sum = 0;

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            int num = a[i][j];
            int originalNum = num;
            int n = 0;
            int digit, result = 0;
            while (originalNum != 0) {
                originalNum /= 10;
                ++n;
            }

            originalNum = num;
            while (originalNum != 0) {
                digit = originalNum % 10;
                result += pow(digit, n);
                originalNum /= 10;
            }
            if (result == num && n == 3) {
                sum += num;
            }
        }
    }

    return sum;
}

int main()
{
    int n;
    int matrix[10][10];
    cout<<pow()
    enterMatrix(matrix, n);
    displayMatrix(matrix, n);
    cout<<TinhTongArmstrong(matrix, n, n)<<endl<<sumArmstrong(matrix, n)<<endl;
    

    return 0;
}
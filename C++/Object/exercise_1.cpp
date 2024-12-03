#include<iostream>
#include<cmath>
using namespace std;

int maxValue = 0;
void enterMatrix(int matrix[][10], int n)
{
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            cout<<"enter element index of ["<<i<<"]["<<j<<"]:";
            cin>>matrix[i][j];
            maxValue = maxValue < matrix[i][j] ? matrix[i][j] : maxValue;
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
        
        sum = sum +  round(pow(temp, k));
        i /= 10;
    }
    return sum == n && k == 3;
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




int DemCapDoiXungNhoNhat(int matrix[][10], int n)
{
    int count = 0;
    int minValue = maxValue;
    bool check[10][10] = {0};
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            if(i != j && matrix[i][j] == matrix[j][i])
            {
                minValue = minValue < matrix[i][j] ? minValue : matrix[i][j];
            }
        }
    }

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
           if(i != j && matrix[i][j] == matrix[j][i] && minValue == matrix[i][j]){
                if(check[i][j] == 0 && check[j][i] == 0){
                    count++;
                    check[i][j] = 1;
                    check[j][i] = 1;
                }
           }
        }
    }

    return count;
}


int main()
{
    int n = 4;
    int matrix[10][10];
   
    enterMatrix(matrix, n);
    displayMatrix(matrix, n);
    cout<<sumArmstrong(matrix, n)<<endl;

    cout<<DemCapDoiXungNhoNhat(matrix, n)<<endl;

    return 0;
}
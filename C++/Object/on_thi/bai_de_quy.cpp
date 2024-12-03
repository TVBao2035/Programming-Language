#include<iostream>
#include<math.h>
using namespace std;


void xuat(int arr[], int n)
{
    for(int i = 0; i < n; i++)
    {
        cout<<arr[i]<<" ";
    }
}

void sap_xep(int a[], int n)
{
    if(n == 1) return;

    for(int i = 0; i < n - 1; i ++)
    {
        if(a[i] > a[n - 1])
        {
            int temp = a[n - 1];
            a[n - 1] = a[i];
            a[i] = temp;
        }
    }

    sap_xep(a, n - 1);
}

void sap_xep_2(int a[], int n)
{
    if(n == 1) return;

    int index = 0;

    for(int i = 0; i < n; i++)
    {
        if(a[i] > a[index]){
            index = i;
        }
    }

    int temp = a[index];
    a[index] = a[n - 1];
    a[n - 1] = temp;

    sap_xep_2(a, n - 1);
}


int tim_lon_nhat(int a[], int n)
{
    if(n == 0) return a[0];

    int lon_nhat = tim_lon_nhat(a, n -1);

    if(a[n - 1] > lon_nhat){
        lon_nhat = a[n - 1];
    } 

    return lon_nhat;
}

int UCLN(int m, int n){
    if(n == 0) return m;
    
    return UCLN(n, m%n);
}

int Fibo(int n)
{
    if(n == 0 || n == 1) return 1;

    return Fibo(n - 1) + Fibo(n - 2);
}

int tong(int a[], int n)
{
    if(n == 0) return a[0];

    return a[n - 1] + tong(a, n - 1);
}
            
int tich(int a[], int n)
{
    if(n == 0) return a[0];

    return a[n - 1] * tich(a, n - 1);
}

int vi_tri_lon_nhat(int a[], int n)
{
    if(n == 1) return 0;

    int vi_tri = vi_tri_lon_nhat(a, n - 1);

    if(a[n - 1] > a[vi_tri]) vi_tri = n - 1;

    return vi_tri;
}

int dem_chan(int a[], int n){
    if(n == 0) return 0;

    if(a[n - 1] % 2 == 0) return dem_chan(a, n -1) + 1;
    return dem_chan(a, n - 1);
}

bool nguyen_to(int n)
{
    if(n < 2) return false;
    else{
        for(int i = 2; i <= sqrt(n); i++){
            if(n % i == 0) return false;
        }
        return true;
    }
}


int dem_nguyen_to(int a[], int n)
{
    if(n == 0) return 0;
    if(nguyen_to(a[n - 1])) return 1 + dem_nguyen_to(a, n - 1);
    return dem_nguyen_to(a, n - 1);
}

bool toan_duong(int a[], int n){
    if(n == 0) return true;
    if(a[n - 1] > 0) return toan_duong(a, n - 1);
    return false;
}

bool tim_kiem(int a[], int n, int x){
    if(n == 0) return false;
    if(a[n - 1] == x) return true;
    return tim_kiem(a, n - 1, x);
}
int main()
{
    int array[] = {2, 9, 6, 1, 8, 10,  3, 5, 4, 7};
    int n = 10;
    //sap_xep_2(array, n);
    cout<<endl<<tim_kiem(array, n, 11)<<endl;

    cout<<endl<<toan_duong(array, n)
        <<endl<<dem_chan(array, n)
        <<endl<<dem_nguyen_to(array, n)<<endl;

    cout<<endl<<tim_lon_nhat(array, n)
        <<endl<<vi_tri_lon_nhat(array, n)<<endl;
        
    cout<<UCLN(100, 2)
        <<endl<<Fibo(6)
        <<endl<<tong(array, n)
        <<endl<<tich(array, n)<<endl;
        
    xuat(array, n);
    return 0;
}
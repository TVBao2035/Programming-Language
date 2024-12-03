#include<iostream>
#include<math.h>
using namespace std;


struct DaThuc
{
    float x;
    int n;
    int * a = new int[n];

    void Nhap()
    {
        cout<<endl<<"- Nhap Tham so x: ";
        cin>>x;
        cout<<endl<<"- Nhap Tham so n: ";
        cin>>n;
        for(int i=0; i<=n; i++)
        {
            cout<<endl<<"- Nhap tham so a vi tri ["<<i+1<<"]: ";
            cin>>a[i];
        }
    }

    float Gia_Tri_Tai_Diem(int m)
    {
        return a[m-1] * pow(x, m-1);
    }

    float Tong_Da_Thuc()
    {
        float tong = 0;
        for(int i=0; i<=n; i++)
        {
            tong += a[i] * pow(x, i);
        }
        return tong;
    }

    void Xuat()
    {
        cout<<endl<<x<<" "<<n<< "\ntham so a: ";
        for(int i=0; i<=n; i++)
        {
            cout<<a[i]<<" ";
        }
        cout<<endl<<"Tong Da Thuc: "<<Tong_Da_Thuc();
    }

};

void Tong_Hai_Da_Thuc(DaThuc a, DaThuc b)
{
    float tong =  a.Tong_Da_Thuc() + b.Tong_Da_Thuc();
    cout<<endl<<"Tong Hai Da Thuc: "<<tong;
}


int main()
{
    DaThuc a;
    DaThuc b;
    a.Nhap();
    a.Xuat();
    b.Nhap();
    b.Xuat();
    Tong_Hai_Da_Thuc(a, b);
    return 0;
}
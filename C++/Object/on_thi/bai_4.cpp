#include<iostream>
using namespace std;
struct Da_Thuc
{
    int n;
    int * da_thuc = new int[100];
    Da_Thuc(){}

    Da_Thuc(int arr[], int l)
    {
        da_thuc = arr;
        n = l;
    }

    void Nhap()
    {
        cout<<"- Nhap Bac Da Thuc Lon Nhat: ";
        cin>>n;

        for(int i=n; i>=0; i--)
        {
            cout<<"- Nhap tham so cho da thuc A("<<i<<") * X^"<<i<<": ";
            cin>>da_thuc[i];
        }
    }

    void Xuat()
    {
        for(int i=n; i>=0; i--)
        {
            cout<<da_thuc[i]<<"X^"<<i;
            if(i == 0) cout<<" ";
            else cout<<" + ";
        }
    }

    Da_Thuc Tinh_Dao_Ham()
    {
        Da_Thuc dao_ham;
        dao_ham.n = n -1;
        for(int i = 1; i <= n; i++){
            dao_ham.da_thuc[i-1] = da_thuc[i] * i;
        }
        return dao_ham;
    }
};


int main()
{
    
    Da_Thuc DaThuc;
    DaThuc.Nhap();
    DaThuc.Tinh_Dao_Ham().Xuat();
    return 0;
}
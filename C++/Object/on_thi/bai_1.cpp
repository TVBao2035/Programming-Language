#include<iostream>
#include<string.h>

using namespace std;

struct NhanVien
{
    string ma_nhan_vien, ho_ten; 
    int loai_san_pham, so_luong_sp, luong_nv;
};

void Tinh_Tien_Luong(NhanVien nv[], int n)
{
    for(int i=0; i<n; i++)
    {
        int index;

        if(nv[i].so_luong_sp > 0 && nv[i].so_luong_sp <= 30) index = 0;
        else if(nv[i].so_luong_sp > 31 && nv[i].so_luong_sp <= 50) index = 1;
        else if(nv[i].so_luong_sp > 50) index = 2;

        int bang_don_gia[3][3] = {{32000, 30000, 28000}, {35000, 32000, 29000}, {38000, 35000, 30000}};
        
        nv[i].luong_nv = bang_don_gia[index][nv[i].loai_san_pham] * nv[i].so_luong_sp;
    }
} 

void Nhap_Nhieu_NV(NhanVien nv[], int n)
{
    for(int i=0; i<n; i++)
    {
        cout<<endl<<"- Nhap ma nhan vien: ";
        fflush(stdin);
        getline(cin, nv[i].ma_nhan_vien);

        cout<<endl<<"- Nhap ho ten nhan vien: ";
        fflush(stdin);
        getline(cin, nv[i].ho_ten);

        do{
            cout<<endl<<"- Nhap loai san pham: ";
            cin>>nv[i].loai_san_pham;
        }
        while(nv[i].loai_san_pham < 0 || nv[i].loai_san_pham > 2);

        do{
            cout<<endl<<"- Nhap so luong san phan: ";
            cin>>nv[i].so_luong_sp;
        }
        while(nv[i].so_luong_sp < 0);

    }
}

void Xuat_Nhan_Vien(NhanVien nv[], int n)
{
    for(int i=0; i<n; i++)
    {
        cout<<endl<<nv[i].ma_nhan_vien<<"  "<<nv[i].ho_ten<<" "<<nv[i].loai_san_pham<<" "<<nv[i].so_luong_sp<<" "<<nv[i].luong_nv;
    }
}


int main()
{
    int n;
    do{
        cout<<"- Nhap so luong nhan vien: ";
        cin>>n;
    }
    while(n <= 0 || n > 50);
    
    NhanVien * danh_sach_nv = new NhanVien[n];

    Nhap_Nhieu_NV(danh_sach_nv, n);
    Tinh_Tien_Luong(danh_sach_nv, n);
    Xuat_Nhan_Vien(danh_sach_nv, n);

    return 1;
}
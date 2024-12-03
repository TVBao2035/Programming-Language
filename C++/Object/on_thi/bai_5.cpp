#include<iostream>
#include<string.h>
#include<math.h>
using namespace std;

struct SinhVien{
    int masv;
    string ten;
    int nam_sinh;
    double diem_toan, diem_ly, diem_hoa;

    double Tinh_Diem_Trung_Binh(){
        return (diem_hoa + diem_toan + diem_ly) / 3;
    }
};

void Nhap(SinhVien sv[], int n)
{
    for(int i = 0; i < n; i++){
        cout<<"- Ma Sinh Vien: ";
        cin>>sv[i].masv;
        cout<<"- Ten Sinh Vien: ";
        fflush(stdin);
        getline(cin, sv[i].ten);
        cout<<"- Nam Sinh: ";
        cin>>sv[i].nam_sinh;
        cout<<"- Nhap diem toan, ly, hoa: ";
        cin>>sv[i].diem_toan>>sv[i].diem_ly>>sv[i].diem_hoa;
    }
}


void Xuat(SinhVien sv[], int n){
    for(int i=0; i<n; i++){
        cout<<endl<<sv[i].masv<<" "<<sv[i].ten<<" "<<sv[i].nam_sinh<<" "<<sv[i].diem_toan<<" "<<sv[i].diem_hoa<<" "<<sv[i].diem_ly<<endl;
    }
}

SinhVien DiemTB_Cao_Nhat(SinhVien sv[], int n){
    if(n == 0) return sv[0];
    SinhVien temp = DiemTB_Cao_Nhat(sv, n - 1);
    if(temp.Tinh_Diem_Trung_Binh() < sv[n - 1].Tinh_Diem_Trung_Binh()){
        temp = sv[n - 1];
    }
    return temp;
}

SinhVien Tuoi_Nho_Nhat(SinhVien sv[], int n){
    if(n == 0) return sv[0];
    SinhVien temp = Tuoi_Nho_Nhat(sv, n - 1);
    if(temp.nam_sinh < sv[n - 1].nam_sinh){
        temp = sv[n - 1];
    }
    return temp;
}

void Sap_Xet_Tang_Dan_DiemTB(SinhVien sv[], int n){
    if(n == 1) return;
    for(int i = 0; i < n - 1; i++){
        if(sv[i].Tinh_Diem_Trung_Binh() > sv[n - 1].Tinh_Diem_Trung_Binh()){
            SinhVien temp = sv[i];
            sv[i] = sv[n - 1];
            sv[n - 1] = temp;
        }
    }
    Sap_Xet_Tang_Dan_DiemTB(sv, n - 1);
}

void Danh_Sach_SV(SinhVien sv[], int n)
{
    SinhVien *ds = new SinhVien[100];
    int index = 0;
    SinhVien temp = Tuoi_Nho_Nhat(sv, n);
    for(int i = 0; i < n; i++){
        if(sv[i].nam_sinh == temp.nam_sinh && sv[i].Tinh_Diem_Trung_Binh() > 5){
            ds[index] = sv[i];
            index++;
        }
    }

    for(int i = 0; i < n; i++){
        cout<<sv[i].masv<<" "<<sv[i].ten<<" "<<sv[i].Tinh_Diem_Trung_Binh()<<endl;
    }
}
int main()
{
    SinhVien * sv = new SinhVien[100];
    int n = 3;
    Nhap(sv, n);
    cout<<DiemTB_Cao_Nhat(sv, n).masv<<" "<<DiemTB_Cao_Nhat(sv, n).ten;
    Sap_Xet_Tang_Dan_DiemTB(sv, n);
    Danh_Sach_SV(sv, n);
    Xuat(sv, n);
    return 0;
}
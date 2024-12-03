#include<iostream>
#include<math.h>
using namespace std;


struct Diem
{
    double x,y;
    Diem()
    {

    }
    Diem(double a, double b)
    {
        x = a;
        y = b;
    }
    void Nhap_Toa_Do()
    {
        cout<<endl<<"- Nhap X: ";
        cin>>x;
        cout<<endl<<"- Nhap Y: ";
        cin>>y;
    }

    void Xuat_Toa_Do()
    {
        cout<<endl<<"["<<x<<"  "<<y<<"]";
    }

};
struct HinhVuong
{
    Diem a, b, c, d;
    void Nhap_Diem()
    {   
        do{
            cout<<endl<<"- Nhap Diem A: ";
            a.Nhap_Toa_Do();
            cout<<endl<<"- Nhap Diem B: ";
            b.Nhap_Toa_Do();
        }while(a.x == b.x || a.y == b.y);
        c.x = a.x;
        c.y = b.y;
        d.x = b.x;
        d.y = a.y;
    }
    
    double Chieu_Dai(Diem a, Diem b)
    {
        return sqrt(pow(b.x - a.x, 2) + pow(b.y - a.y, 2));
    }

    double Dien_Tich()
    {
        return Chieu_Dai(a,c) * Chieu_Dai(a, d);
    }

    double Chu_Vi()
    {
        return (Chieu_Dai(a, c) * Chieu_Dai(a, d)) / 2;
    }


};
struct TamGiac
{
    Diem A, B, C;
    TamGiac(Diem a, Diem b, Diem c){
        A = a;
        B = b;
        C = c;
    }
    void Nhap_Diem()
    {
        cout<<endl<<"- Nhap Diem A: ";
        A.Nhap_Toa_Do();
        cout<<endl<<"- Nhap Diem B: ";
        B.Nhap_Toa_Do();
        cout<<endl<<"- Nhap Diem C: ";
        C.Nhap_Toa_Do();
    }

    double Chieu_Dai(Diem a, Diem b)
    {
        return sqrt(pow(b.x - a.x, 2) + pow(b.y - a.y, 2));
    }

    double Chu_Vi_TG()
    {
        return Chieu_Dai(A,B) + Chieu_Dai(B, C) + Chieu_Dai(A, C);
    }

    double Dien_Tich_TG()
    {
        double nua_cv = Chu_Vi_TG() / 2;
        return sqrt(nua_cv * (nua_cv - Chieu_Dai(A, B)) * (nua_cv - Chieu_Dai(B, C)) * (nua_cv - Chieu_Dai(A, C)));
    }    

    Diem Trong_Tam()
    {
        Diem trong_tam;
        trong_tam.x = (A.x + B.x + C.x)/3;
        trong_tam.y = (A.y + B.y + C.y)/3;

        return trong_tam;
    }

    Diem Truc_Tam()
    {
        Diem truc_tam;
        Diem vector_1, vector_2;
        //vector BC;
        vector_2.x = C.x - B.x;
        vector_2.y = C.y - B.y;
        //vector AB;
        vector_1.x = B.x - A.x;
        vector_1.y = B.y - A.y;
        double tham_so_1 = ((-1 * vector_1.x * vector_2.y * C.x)) / (vector_2.x * vector_1.y);
        double tham_so_2 = (((C.y * vector_2.y)) / vector_2.x ) ;
        double tham_so_3 = (((vector_2.y * A.y) / vector_2.x ) + A.x);
        double tham_so_4 = (vector_1.x * vector_2.y) / (vector_2.x * vector_1.y);

        truc_tam.x = (tham_so_1 - tham_so_2 + tham_so_3) / ( 1 - tham_so_4);

        tham_so_1 = ((truc_tam.x - C.x) * vector_1.x) / vector_1.y;
        truc_tam.y = (-1 * tham_so_1 + C.y);
        return truc_tam;
    }
};


int main()
{
    TamGiac tg (Diem(-1, 0),Diem(1, 4),Diem(3, 4));
    TamGiac t ( Diem(-2, 6), Diem(-2, 9), Diem(9, 8));
    return 0;
}
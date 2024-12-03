namespace bai_2
{

    class Diem
    {
        double x,y;
        public Diem(){}
        public Diem(double t, double v)
        {
            x = t;
            y = v;
        }
        public void nhap_toa_do()
        {
            Console.Write("Nhap x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap Y: ");
            y = double.Parse(Console.ReadLine());
        }

        public void dat_toa_do_x(double a)
        {
            x = a;
        }

        public void dat_toa_do_y(double a)
        {
            y = a;
        }

        public  double lay_toa_do_x()
        {
            return x;
        }

        public  double lay_toa_do_y()
        {
            return y;
        }
        public void xuat_toa_do()
        {
            Console.WriteLine(x + " : " + y);
        }
    }

    class TamGiac
    {
        Diem A, B, C;
        public TamGiac(Diem a, Diem b, Diem c)
        {
            A = a;
            B = b;
            C = c;
        }
        public void nhap_diem()
        {
            A = new Diem();
            Console.WriteLine("Nhap diem thu nhat:");
            A.nhap_toa_do();
            B = new Diem();
            Console.WriteLine("Nhap diem thu hai:");
            B.nhap_toa_do();
            C = new Diem();
            Console.WriteLine("Nhap diem thu ba:");
            C.nhap_toa_do();         
        }

        public Diem Trong_Tam()
        {
            Diem trong_tam = new Diem();
            trong_tam.dat_toa_do_x((A.lay_toa_do_x() + B.lay_toa_do_x() + C.lay_toa_do_x()) / 3);
            trong_tam.dat_toa_do_y((A.lay_toa_do_y() + B.lay_toa_do_y() + C.lay_toa_do_y()) / 3);
            return trong_tam;
        }


        public Diem Truc_Tam()
        {
            Diem vector1 = new Diem(), vector2 = new Diem(), truc_tam = new Diem();
            //vector AB
            vector1.dat_toa_do_x(B.lay_toa_do_x() - A.lay_toa_do_x());
            vector1.dat_toa_do_y(B.lay_toa_do_y() - A.lay_toa_do_y());
            //vector BC
            vector2.dat_toa_do_x(C.lay_toa_do_x() - B.lay_toa_do_x());
            vector2.dat_toa_do_y(C.lay_toa_do_y() - B.lay_toa_do_y());

            double tham_so_1 = ((-vector1.lay_toa_do_x() * vector2.lay_toa_do_y() * C.lay_toa_do_x())) / (vector2.lay_toa_do_x() * vector1.lay_toa_do_y());
            double tham_so_2 = (C.lay_toa_do_y() * vector2.lay_toa_do_y()) / vector2.lay_toa_do_x();
            double tham_so_3 = ((vector2.lay_toa_do_y() * A.lay_toa_do_y()) / vector2.lay_toa_do_x()) + A.lay_toa_do_x();
            double tham_so_4 = (vector1.lay_toa_do_x() * vector2.lay_toa_do_y()) / (vector2.lay_toa_do_x() * vector1.lay_toa_do_y());

            truc_tam.dat_toa_do_x((tham_so_1 - tham_so_2 + tham_so_3) / (1 - tham_so_4));
            tham_so_1 = ((truc_tam.lay_toa_do_x() - C.lay_toa_do_x()) * vector1.lay_toa_do_x()) / vector1.lay_toa_do_y();
            truc_tam.dat_toa_do_y(-1 * tham_so_1 + C.lay_toa_do_y());

            return truc_tam;
        }
       

        public Diem Tam_Duong_Tron_Ngoai_Tiep()
        {
            Diem tam_duong_tron = new Diem();

            // su dung do dai vector OA =  vector OB & vector OA = vector OC;
            double tham_so_1 = (Math.Pow(B.lay_toa_do_x(), 2) - Math.Pow(A.lay_toa_do_x(), 2) + Math.Pow(B.lay_toa_do_y(), 2) - Math.Pow(A.lay_toa_do_y(), 2)) /( 2 * (B.lay_toa_do_x() - A.lay_toa_do_x()));
            double tham_so_2 = ((B.lay_toa_do_y() - A.lay_toa_do_y()) * (Math.Pow(C.lay_toa_do_x(), 2) - Math.Pow(A.lay_toa_do_x(), 2) + Math.Pow(C.lay_toa_do_y(), 2) - Math.Pow(A.lay_toa_do_y(), 2))) / (2 * (C.lay_toa_do_y() - A.lay_toa_do_y()) * (B.lay_toa_do_x() - A.lay_toa_do_x()));
            double tham_so_3 = ((B.lay_toa_do_y() - A.lay_toa_do_y()) * (C.lay_toa_do_x() - A.lay_toa_do_x())) / ((C.lay_toa_do_y() - A.lay_toa_do_y()) *(B.lay_toa_do_x() - A.lay_toa_do_x()));
            
            tam_duong_tron.dat_toa_do_x((tham_so_1 - tham_so_2) / (1 - tham_so_3));
            // tinh toa do y bang toa x;
            tham_so_1 = Math.Pow(C.lay_toa_do_x(), 2) - Math.Pow(A.lay_toa_do_x(), 2) + Math.Pow(C.lay_toa_do_y(), 2) - Math.Pow(A.lay_toa_do_y(), 2);
            tham_so_2 =  (2 * tam_duong_tron.lay_toa_do_x() * (C.lay_toa_do_x() - A.lay_toa_do_x()));
            tham_so_3 =( 2 * (C.lay_toa_do_y() - A.lay_toa_do_y()));
           
            tam_duong_tron.dat_toa_do_y((tham_so_1 - tham_so_2) / tham_so_3);

            return tam_duong_tron;
        }
        public void xuat()
        {
            Console.Write("- Toa Do Truc Tam Cua Tam Giac: ");
            Truc_Tam().xuat_toa_do();
            Console.Write("- Toa Do Tam Duong Tron Ngoai Tiep Tam Giac: ");
            Tam_Duong_Tron_Ngoai_Tiep().xuat_toa_do();
        }
    }
    class Program
    {
        static void Main()
        {
            TamGiac a = new TamGiac(new Diem(-1, 0), new Diem(1, 4), new Diem(3, 4));
            TamGiac b = new TamGiac(new Diem(1, 2), new Diem(3, 4), new Diem(2, -1));
            TamGiac c = new TamGiac(new Diem(-1, 1), new Diem(3, 1), new Diem(2, 4));
            TamGiac d = new TamGiac(new Diem(0, 1), new Diem(-2, 3), new Diem(2, 0));
            TamGiac e = new TamGiac(new Diem(-2, 6), new Diem(-2, 9), new Diem(9, 8));
            e.xuat();
        }
    }
}
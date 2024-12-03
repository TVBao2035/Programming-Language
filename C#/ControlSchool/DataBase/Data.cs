using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using ControlSchool.Object;
namespace ControlSchool.DataBase
{
    public class Data
    {
        public List list = new List();

        public Data(){
            list.list_of_department.Add(new Department("KHMT", "Khoa hoc may tinh"));
            list.list_of_department.Add(new Department("HTT", "He thong thong tin"));
            list.list_of_department.Add(new Department("CNPM", "Cong nghe phan mem"));
            list.list_of_department.Add(new Department("MTT", "Mang va truyen thong"));
            list.list_of_department.Add(new Department("KTMT", "Ki thuat may tinh"));

            list.list_of_subject.Add(new Subject("THDC", "Tin hoc dai cuong", "KHMT"));
            list.list_of_subject.Add(new Subject("CTRR", "Cau truc roi rac", "KHMT"));
            list.list_of_subject.Add(new Subject("CSDL", "Co so du lieu", "HTTT"));
            list.list_of_subject.Add(new Subject("CTDLGT", "Cau truc du lieu va giai thuat", "KHMT"));
            list.list_of_subject.Add(new Subject("PTTKTT", "Phan tich thiet ke thuat toan", "KHMT"));
            list.list_of_subject.Add(new Subject("DHMT", "Do hoa may tinh", "KHMT"));
            list.list_of_subject.Add(new Subject("KTMT", "Kien truc may tinh", "KTMT"));
            list.list_of_subject.Add(new Subject("TKCSDL", "Thiet ke co so du lieu", "HTTT"));
            list.list_of_subject.Add(new Subject("PTTKHTTT", "Phan tich thiet ke he thong thong tin", "HTTT"));
            list.list_of_subject.Add(new Subject("HDH", "He dieu hanh", "KTMT"));
            list.list_of_subject.Add(new Subject("NMCNPM", "Nhap mon cong nghe phan men", "CNPM"));
            list.list_of_subject.Add(new Subject("LTCFW", "Lap trinh C for win", "CNPM"));
            list.list_of_subject.Add(new Subject("LTHDT", "Lap trinh huong doi tuong", "CNPM"));      
              
            list.list_of_classroom.Add(new ClassRoom("K11", "Lop 1 Khoa 1", 11));
            list.list_of_classroom.Add(new ClassRoom("K12", "Lop 2 Khoa 1", 12));
            list.list_of_classroom.Add(new ClassRoom("K13", "Lop 3 Khoa 1", 12));

            list.list_of_student.Add(new Student("24532", "Truong Van Bao", "K11"));
            list.list_of_student.Add(new Student("36552", "Nguyen Tien Dat", "K11"));
            list.list_of_student.Add(new Student("37732", "Le Minh Hien", "K11"));
            list.list_of_student.Add(new Student("83932", "Nguyen Tri Nhan", "K12"));
        
        
        }
    }
}
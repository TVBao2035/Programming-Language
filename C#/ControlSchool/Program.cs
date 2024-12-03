using System;
using ControlSchool.Object;
using Microsoft.VisualBasic;
using ControlSchool.DataBase;
using ControlSchool.Control;
namespace ControlSchool{
    class Program{

      
       static void Main()
       {
            Data data = new Data();
            

            // foreach(Student st in data.list.list_of_student)
            //     {
            //         if(st.Id_classroom == "K12")
            //         {
            //             Console.WriteLine(st.Id_student + " " + st.Name_student + " " + st.Id_classroom);
            //         }
            //     }
            // foreach(ClassRoom clr in data.list.list_of_classroom)
            // {
            //     foreach(Student st in data.list.list_of_student)
            //     {
            //         if(st.Id_classroom == clr.Id_classroom)
            //         {
            //             Console.WriteLine(st.Id_student + " " + st.Name_student + " " + st.Id_classroom);
            //         }
            //     }
            // }
          
        //    foreach(Subject e in data.list.list_of_subject){
        //         Console.WriteLine("+++++++++++++++++++++++++");
        //         foreach(Department ed in data.list.list_of_department){
        //             if(e.Id_department == ed.Id_department){
        //                 Console.WriteLine(e.Id_subject);
        //                 Console.WriteLine(e.Name_subject);
        //                 Console.WriteLine(e.Id_department);
        //                 Console.WriteLine(ed.Name_department);
        //             }
        //         }
        //    }


           

       }
    }
}
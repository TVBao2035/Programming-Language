using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace ControlSchool.Object
{
    public class Teacher
    {
        private string id_teacher;
        private string name_teacher;
        private string id_department;
        private int salary;
        private int salary_coefficient;


        public string Id_teacher{
            get{
                return id_teacher;
            }
            set{
                id_teacher = value;
            }
        }


        public string Name_teacher{
            get{
                return name_teacher;
            }
            set{
                name_teacher = value;
            }
        }

        public string Id_department{
            get{
                return id_department;
            }

            set{
                id_department = value;
            }
        }

        public int Salary{
            get{
                return salary;
            }
            set{
                salary = value;
            }
        }

        public int Salary_coefficient{
            get{
                return salary_coefficient;
            }
            set{
                salary_coefficient = value;
            }
        }


        public Teacher(string id, string name, int sal, int sal_coe, string id_depart){
            id_teacher = id;
            name_teacher = name;
            salary = sal;
            salary_coefficient = sal_coe;
            id_department = id_depart;
        }
        public static bool operator ==(Teacher objects, Teacher element)
        {
            if(objects.Id_teacher == element.Id_teacher) return true;
            return false;
        }
        public static bool operator !=(Teacher objects, Teacher element)
        {
            if(objects.Id_teacher != element.Id_teacher) return true;
            return false;
        }

    }
}
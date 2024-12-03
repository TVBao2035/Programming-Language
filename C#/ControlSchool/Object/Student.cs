using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlSchool.Object
{
    public class Student
    {
        private string id_student;
        private string name_student;

        private string id_classroom;

        public string Id_student{
            get{
                return id_student;
            }
            set{
                id_student = value;
            }
        }

        public string Name_student{
            get{
                return name_student;
            }
            set{
                name_student = value;
            }
        }

        public string Id_classroom{
            get{
                return id_classroom;
            } 
            set{
                id_classroom = value;
            }
        }

        public Student(string id, string name, string id_class){
            id_student = id;
            name_student = name;
            id_classroom = id_class;
        }

        public static bool operator ==(Student objects, Student element)
        {
            if(objects.Id_student == element.Id_student) return true;
            return false;
        }
        public static bool operator !=(Student objects, Student element)
        {
            if(objects.Id_student != element.Id_student) return true;
            return false;
        }
    }
}
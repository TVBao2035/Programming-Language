using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace ControlSchool.Object
{
    public class ClassRoom
    {
        private string id_classroom;
        private string name_classroom;

        private int number_of_members;

        public string Id_classroom{
            get{
                return id_classroom;
            }
            set{
                id_classroom = value;
            }
        }

        public string Name_classroom{
            get{
                return name_classroom;
            } 
            set{
                name_classroom = value;
            }
        }

        public int Number_of_members{
            get{
                return number_of_members;
            }
            set{
                number_of_members = value;
            }
        }


        public ClassRoom(string id, string name, int number_of_mem){
            id_classroom = id;
            name_classroom = name;
            number_of_members = number_of_mem;
        }

        public static bool operator ==(ClassRoom objects, ClassRoom element)
        {
            if(objects.Id_classroom == element.Id_classroom) return true;
            return false;
        }
        
        public static bool operator !=(ClassRoom objects, ClassRoom element)
        {
            if(objects.Id_classroom != element.Id_classroom) return true;
            return false;
        }
    }
}
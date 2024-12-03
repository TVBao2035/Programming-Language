using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ControlSchool.Object
{
    public class Department
    {
        private string  id_department;
        private string name_department;
        
        
        public string Id_department{
            get{
                return id_department;
            }
            set{
                id_department = value;
            }
        }
        public string Name_department{
            get{
                return name_department;
            }

            set{
                name_department = value;
            }
        }

        public Department(string id, string name){
            id_department = id;
            name_department = name;
        }

        public static bool operator ==(Department objects, Department element)
        {
            if(objects.Id_department == element.Id_department) return true;
            return false;
        }
        public static bool operator !=(Department objects, Department element)
        {
            if(objects.Id_department != element.Id_department) return true;
            return false;
        }
    }
}
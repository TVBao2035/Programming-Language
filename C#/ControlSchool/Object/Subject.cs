using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlSchool.Object
{
    public class Subject
    {
        private string id_subject;
        private string name_subject;

        private string id_department;

        public string Id_subject{
            get{
                return id_subject;
            }
            set{
                id_subject = value;
            }
        }

        public string Name_subject{
            get{
                return name_subject;
            }
            set{
                name_subject  = value;
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
        public static bool operator ==(Subject objects, Subject element)
        {
            if(objects.Id_subject == element.Id_subject) return true;
            return false;
        }
        public static bool operator !=(Subject objects, Subject element)
        {
            if(objects.Id_subject != element.Id_subject) return true;
            return false;
        }
        public Subject(string id, string name, string id_depart){
            id_subject = id;
            name_subject = name;
            id_department = id_depart;
        }


    }
}
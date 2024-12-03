using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_29
{
    public class Student
    {
        public string Name{
            get; set;
        }

        public double Math{
            get; set;
        }

        public double Physic{
            get; set;
        }

        public double Chemistry{
            get; set;
        }

        public Student(){}

        public Student(string name, double math, double physic, double chemistry){
            Name = name;
            Math = math;
            Physic = physic;
            Chemistry = chemistry;
        }

        public double avgPoint(){
            return (Math + Physic + Chemistry) / 3;
        }
        
        public void display(){
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Math: " + Math);
            Console.WriteLine("Physic: " + Physic);
            Console.WriteLine("Chemistry: " + Chemistry);
            Console.WriteLine("Average: " + avgPoint());
        }
        public static List<Student> getStudentMaxAvg(List<Student> listStudents){
            Student avgMaxElement = listStudents[0];
            List<Student> result = new List<Student>();

            for(int i=0; i<listStudents.Count; i++) if(listStudents[i].avgPoint() > avgMaxElement.avgPoint()) avgMaxElement = listStudents[i];


            for(int i=0; i<listStudents.Count; i++) if(listStudents[i].avgPoint() == avgMaxElement.avgPoint()) result.Add(listStudents[i]);

            return result;
        }

        public static List<Student> getStudentMaxMath(List<Student> listStudents){
            Student mathMaxElement = listStudents[0];
            List<Student> result = new List<Student>();

            for(int i=0; i<listStudents.Count; i++) if(listStudents[i].Math > mathMaxElement.Math) mathMaxElement = listStudents[i];
            
            for(int i=0; i<listStudents.Count; i++) if(listStudents[i].Math == mathMaxElement.Math) result.Add(listStudents[i]);
            

            return result;
        }

        public static List<Student> getStudentMaxPhysic(List<Student> listStudents){
            Student physicMaxElement = listStudents[0];
            List<Student> result = new List<Student>();

            for(int i=0; i<listStudents.Count; i++) if(listStudents[i].Physic > physicMaxElement.Physic) physicMaxElement = listStudents[i];
            
            for(int i=0; i<listStudents.Count; i++) if(listStudents[i].Physic == physicMaxElement.Physic) result.Add(listStudents[i]);

            return result;
        }

        public static List<Student> getStudentMaxChemistry(List<Student> listStudents){
            Student chemistryMaxElement = listStudents[0];
            List<Student> result = new List<Student>();

            for(int i=0; i<listStudents.Count; i++) if(listStudents[i].Chemistry > chemistryMaxElement.Chemistry) chemistryMaxElement = listStudents[i];
            
            for(int i=0; i<listStudents.Count; i++) if(listStudents[i].Chemistry == chemistryMaxElement.Chemistry) result.Add(listStudents[i]);

            return result;
        }
    }
}
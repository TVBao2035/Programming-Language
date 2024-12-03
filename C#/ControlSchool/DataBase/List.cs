using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlSchool.Object;
namespace ControlSchool.DataBase
{
    public class List
    {
        
            public List<Department> list_of_department = new List<Department>();
            public List<Subject> list_of_subject = new List<Subject>();
            public List<Teacher> list_of_teacher = new List<Teacher>();
            public List<ClassRoom> list_of_classroom = new List<ClassRoom>();
            public List<Student> list_of_student = new List<Student>();
            public List<TestResult> list_of_test_result = new List<TestResult>();
    }
}
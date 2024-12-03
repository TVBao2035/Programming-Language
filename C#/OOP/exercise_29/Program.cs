namespace exercise_29;

class Program{
    static void Main(){
        List<Student> list = new List<Student>();

        // Student s1 = new Student("bao", 5, 8, 9);
        // Student s2 = new Student("hai", 6, 5, 7);
        // Student s3 = new Student("ngan", 4, 5, 8);
        // Student s4 = new Student("trang", 7, 5, 4);
        // Student s5 = new Student("tram", 3, 6, 9);
        // list.Add(s1); list.Add(s2); list.Add(s3); list.Add(s4); list.Add(s5);
         for(int i=0; i<5 ;i++){
            string name = Console.ReadLine();
            double math = double.Parse(Console.ReadLine());
            double physic = double.Parse(Console.ReadLine());
            double chemistry = double.Parse(Console.ReadLine());
            Student student = new Student(name, math, physic, chemistry);
            list.Add(student);
        }

        List<Student> listMaxMath = Student.getStudentMaxMath(list);
        List<Student> listMaxPhysic = Student.getStudentMaxPhysic(list);
        List<Student> listMaxChemistry = Student.getStudentMaxChemistry(list);
        List<Student> listMaxAverage = Student.getStudentMaxAvg(list);


        Console.WriteLine("--------List Max Average Students: ");
        for(int i=0; i<listMaxAverage.Count ;i++){
            listMaxAverage[i].display();
        }

        Console.WriteLine("--------List Max Math Students: ");
        for(int i=0; i<listMaxMath.Count ;i++){
            listMaxMath[i].display();
        }

        Console.WriteLine("--------List Max Physic Students: ");
        for(int i=0; i<listMaxPhysic.Count ;i++){
            listMaxPhysic[i].display();
        }
        
        Console.WriteLine("--------List Max Chemistry Students: ");
        for(int i=0; i<listMaxChemistry.Count ;i++){
            listMaxChemistry[i].display();
        }
    }
}
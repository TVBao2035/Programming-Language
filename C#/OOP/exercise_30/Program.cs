namespace exercise_30;

class Program{
    static void Main(){
        List<Subject> list = new List<Subject>();

        Subject s1 = new Subject("OOP", 5.5, 2, 300);
        Subject s2 = new Subject("Database", 6.9, 3, 400);
        Subject s3 = new Subject("Programming technique", 7, 4,300);

        list.Add(s1); list.Add(s2); list.Add(s3);

        Student s = new Student("022101012", "Bao", list);
        s.display();
    }
}
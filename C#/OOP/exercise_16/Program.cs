namespace exercise_16;
class Program{
    static void Main()
    {
        Person p = new Person("Bao", 3);
        Student s = new Student("VanBao", 6, 5.6);
        p.display();
        s.display();
    }
}
namespace exercise_17;

class Program{
    static void Main()
    {
        Person p = new Person("A", 20, "TG");
        Student s = new Student("Bao", 20, "MT", 5.5);
        Teacher t = new Teacher("C", 30, "MT", 1700);

        p.display();
        s.display();
        t.display();
    }
}
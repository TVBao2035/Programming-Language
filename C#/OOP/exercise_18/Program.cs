namespace exercise_18;
class Program{
    static void Main()
    {
        Employee e = new Employee("Bao", 3000);
        Manager m = new Manager("Dat", 4000, 1000);
       

        e.display();
        m.display();
        
    }
}
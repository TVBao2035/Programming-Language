namespace exercise_20;

class Program{
    static void Main()
    {
        Customer p = new Customer("Bao","My Tho", 3000);
        Person r = new Employee("TVB", "TG", 200);
        p.display();
        r.display();
    }
}
namespace exercise_22;

class Program {
    static void Main(){
        Employee e1 = new PartTimeEmployee("Bao", 4500, 7);
        Employee e2 = new FullTimeEmployee("Bao", 6500);
        Console.WriteLine(e1.Name + "            " + e1.calculateSalary());
        Console.WriteLine(e2.Name + "   " + e2.calculateSalary());
    }
}
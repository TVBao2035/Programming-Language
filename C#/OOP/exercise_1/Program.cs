namespace OOP;

class Student{
    public int age;
    public string name;

    public void getInformation(){
        Console.Write("Enter Name: ");
        name = Console.ReadLine();
        Console.Write("Enter Age: ");
        age = int.Parse(Console.ReadLine());
    }

    public void displayInformation(){
        Console.Clear();
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}
class Program{
    static void Main(){
        Student s = new Student();
        s.getInformation();
        s.displayInformation();
    }
}
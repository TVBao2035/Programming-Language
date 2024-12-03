namespace exercise_11;

class Program{

    static void Main(){
        Employee e = new Employee(8889, "Bao", "Truong Van", 9);
        e.display();

        e.Id = 1003;
        e.display();
    }
}
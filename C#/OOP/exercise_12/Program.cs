namespace exercise_12;

class Program
{
    static void Main()
    {
        Date d = new Date(3, 5, 2004);
        d.display();
        d.setDate(12, 12, 2003);
        d.display();
    }
}
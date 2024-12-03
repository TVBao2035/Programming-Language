namespace exercise_10;
class Program{
    static void Main(){
        Student s = new Student(10004, "Bao", 20, "Tg", 4);
        s.display();

        s.Name = "TVBao";
        s.Id = 1003;
        s.Address = "TG";
        
        s.display();
    }
}
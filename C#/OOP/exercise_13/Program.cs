namespace exercise_13;
class Program{
    static void Main(){
        Time t = new Time(23, 59, 59);
        t.display();
        t.nextSecond();
        t.display();
        t.setTime(0, 0, 0);
        t.display();
        t.previousSecond();
        t.display();
        t.setTime(2, 5, 6);
        t.display();
    }
}
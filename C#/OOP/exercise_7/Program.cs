namespace exercise_7;

class Program{
    static void Main(){
        Student s1 = new Student();
        s1.display();
        Student s2 = new Student("Bao");
        s2.display();
        Student s3 = new Student('f');
        s3.display();
        Student s4 = new Student("van Bao", 'm');
        s4.display();
    }
}
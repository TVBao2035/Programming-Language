namespace exercise_15;
class Program{
    static void Main(){
        Account a = new Account(1001, "bao", 4455);
        a.display();
        a.deposit(3333);
        a.display();
        a.withdraw(100000);
        a.withdraw(3000);
        a.display();
    }
}
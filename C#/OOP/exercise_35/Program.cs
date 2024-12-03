namespace exercise_35;

class Program{
    static void Main(){
        Food f = new CannedFood("beef", 10000, 10);
        f.display();

        f = new NonCFood("fish", 2000, 2);
        f.display();


        List<CannedFood> listCFood = new List<CannedFood>();
        listCFood.Add(new CannedFood("beef", 9000, 20));
        listCFood.Add(new CannedFood("chicken", 5000, 90));
        listCFood.Add(new CannedFood("duck", 4000, 60));
        listCFood.Add(new CannedFood("pork", 6000, 80));
        listCFood.Add(new CannedFood("fish", 2000, 50));

        List<NonCFood> listNCFood = new List<NonCFood>();
        listNCFood.Add(new NonCFood("fish", 900, 100));
        listNCFood.Add(new NonCFood("port", 4000, 140));
        listNCFood.Add(new NonCFood("beef", 8000, 90));
        listNCFood.Add(new NonCFood("chicken", 3000, 130));
        listNCFood.Add(new NonCFood("duck", 2500, 80));

        CannedFood.sortNumberBox(listCFood);
        NonCFood.sortWeight(listNCFood);

        Console.Clear();
        foreach(var e in listCFood) e.display();
        
        foreach(var e in listNCFood) e.display();
    }
}
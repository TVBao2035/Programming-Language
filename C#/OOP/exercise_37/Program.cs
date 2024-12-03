namespace exercise_37;

class Program{
    static void Main()
    {
        List<People> listP = new List<People>();

        listP.Add(new People("Gumball", 13, "Student", "ABC1"));
        listP.Add(new People("Jack", 15, "Farmer", "ABC2"));
        listP.Add(new People("Emma", 19, "", "ABC3"));
        listP.Add(new People("Anna", 4, "", "ABC4"));
        listP.Add(new People("Bo", 14, "", "ABC5"));

        List<People> listPP = new List<People>();
        
        listPP.Add(new People("Duo", 25, "IT", "FBC11"));
        listPP.Add(new People("Lin", 23, "Farmer", "FBC12"));
        listPP.Add(new People("Cow", 14, "Student", "FBC13"));
        listPP.Add(new People("Pig", 4, "", "FBC14"));
        listPP.Add(new People("Jenny", 9, "Student", "FBC15"));



        List<People> listPS = new List<People>();
        
        listPS.Add(new People("Cat", 30, "Farmer", "GJC213"));
        listPS.Add(new People("Mama", 28, "Farmer", "GJC223"));
        listPS.Add(new People("Min", 20, "", "GJC233"));
        listPS.Add(new People("Cat", 15, "Student", "GJC243"));
        listPS.Add(new People("Mount", 2, "", "GJC253"));

        List<Family> listF = new List<Family>();

        listF.Add(new Family("Gumball", "poor","US", listP));
        listF.Add(new Family("Duo", "rich","England", listPP));
        listF.Add(new Family("Cat", "poor","China", listPS));

        Group g = new Group("ABF", listF);

        Console.WriteLine(g.getNumberFamily());
        
        g.display();

        Console.WriteLine(Group.avgAgeGroup(g));
        List<People> temp = Group.getPeopleHaveNotJob(g);

        foreach(var e in temp) e.display();

        foreach(var e in Family.getPoorHousehold(g.f)){
            e.display();
        }
        Console.WriteLine("------function find");
        foreach(var e in Family.findFamilySurname(g.f, "Cat")){
            e.display();
        }
    }
}
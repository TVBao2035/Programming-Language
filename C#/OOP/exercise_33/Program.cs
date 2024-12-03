namespace exercise_33;

class Program{
    static void Main()
    {
        List<Person> a = new List<Person>(5);
        a.Add(new EmployeeFT("a", 18, "HN", "09842", "nam", 30, 309200));
        a.Add(new EmployeePT("b", 18, "HN", "09842", "nam", 7, 30000));
	    a.Add(new EmployeeFT("c", 18, "HN", "09842", "nam", 30, 1200));
        a.Add(new EmployeePT("d", 18, "HB", "09842", "nam", 6, 1200));
        a.Add(new EmployeeFT("e", 18, "NB", "09842", "nam", 30, 130200));
        
        foreach(Person e in a) e.display();
    }
}
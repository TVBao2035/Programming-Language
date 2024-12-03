namespace exercise_38;

class Program{
    static void Main()
    {
        Book a = new Book("Pride and Prejudice", "Jane Austen", 100);
        Book b = new Book("Crime and Punishment", "Fyodor Dostoyevsky", 1000);

        List<Book> BookList = new List<Book>();
        BookList.Add(a);
        BookList.Add(b);

        List<Person> PersonList = new List<Person>();

        List<Book> personBorrowedCase1 = new List<Book>();
        List<Book> personBorrowedCase2 = new List<Book>();
        personBorrowedCase1.Add(a);
        personBorrowedCase2.Add(a);
        personBorrowedCase1.Add(b);

        PersonList.Add(new Person("a", 9, "HN", personBorrowedCase1));
        PersonList.Add(new Person("b", 20, "NM", personBorrowedCase1));
        PersonList.Add(new Person("c", 8, "HN", personBorrowedCase2));
        PersonList.Add(new Person("d", 9, "NB", personBorrowedCase2));

        foreach(var element in PersonList){
            element.display();
        }

        Person.sortPersonAge(PersonList);

        List<int> listAge = Person.getListAge(PersonList);

        foreach(int e in listAge) Console.WriteLine(e);

        List<Book> maxBookBorrowed = Person.getMaxBookBorrowed(PersonList, BookList);

        foreach(var element in maxBookBorrowed) element.display();

    }
}
namespace exercise_25;

class Program{
    static void Main()
    {
        Author[] authors = new Author[3];
        authors[0] = new Author("Viet", "VietCV@codelearn.io");
        authors[1] = new Author("Tuan", "TuanLQ7@codelearn.io");
        authors[2] = new Author("KienNT", "KienNT@codelearn.io");

        Book b = new Book("C++ for Beginners", authors, 210000);
        Console.WriteLine(b.getAuthorNames());
    }
}
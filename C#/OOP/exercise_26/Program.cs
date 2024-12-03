namespace exercise_26;
class Program{
    static void Main()
    {
        Customer c = new Customer(1000, "Tuan", 20);
        Invoice i = new Invoice(1000, c, 100000);
        Console.WriteLine(i.customer.Name + "    " + i.getAmountAfterDiscount());
    }
}
namespace exercise_6
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[5]{4, 6, 7, 8, 2};
            double[] dArray = new double[5]{4.6, 3.7, 1.9, 5.5, 9.4};
            Console.WriteLine(ArrayCalculator.sumOfArray(array, 5));
            Console.WriteLine(ArrayCalculator.sumOfArray(dArray, 5))
        }
    }
}
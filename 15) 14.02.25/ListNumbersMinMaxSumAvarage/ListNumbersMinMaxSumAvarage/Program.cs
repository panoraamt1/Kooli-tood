namespace ListNumbersMinMaxSumAvarage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] numbers = new int[5] { 10, 15, 16, 8, 6 };

            Console.WriteLine("Kõige suurem number on: " + numbers.Max());
            Console.WriteLine("Kõige väoksem number on: " + numbers.Min());
            Console.WriteLine("Numbrite koondsumma on: " + numbers.Sum());
            Console.WriteLine("Numbrite keskmine on: " + numbers.Average());

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Sorteerib numbrid alates väiksemast suuremani.");

            Array.Sort(numbers);
            foreach (int value in numbers)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sorteerib numbrid alates suurimast väiksemani");

            Array.Reverse(numbers);
            foreach (int value in numbers)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine(Array.BinarySearch(numbers, 15));
        } 
    }
}

namespace ArraySortNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] animals = {"cat", "alligator", "fox",
                "donkey", "bear", "elephant", "goat" };

            Console.WriteLine();
            Console.WriteLine("Tähestikulises järjekorras:");
            Array.Sort(animals);
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine();
            Console.WriteLine("Pikkuse järjekorras");
            Array.Sort(animals, (x, y) => x.Length.CompareTo(y.Length));
            foreach (string animal in animals)
            {
                Console.WriteLine($"{animal}");
            }

            Console.WriteLine("--------------------------");
            Array.Sort(animals, 0, 3);
            foreach (string animal in animals)
            {
                Console.WriteLine($"{animal}");
            }

            Console.WriteLine("--------------------------");
            int[] numbers = { 1, 2, 3, 4, 3, 55, 23, 2 };

            
            int[] distinct = numbers.Distinct().ToArray();
            foreach (int number in distinct)
            {
                Console.WriteLine(number);
            }
        }
    }
}

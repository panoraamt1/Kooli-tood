namespace ForeachInForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var words = new List<List<string>>
            {
                new List<string> {"tea", "coffe", "juice", "smoothie" },
                new List<string> {"cup", "plate", "knife", "spoon" },
                new List<string> {"rain", "snow", "hail", "sunny" },
            };
            foreach (var word in words) 
            {
                foreach (var item in word)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

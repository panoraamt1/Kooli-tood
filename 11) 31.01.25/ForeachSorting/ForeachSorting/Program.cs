using Microsoft.VisualBasic.FileIO;

namespace ForeachSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] genders = { "m", "f", "m", "m", "m", "f", "f", "m", "m", "f" };
            int male = 0, female = 0;
            foreach (var item in genders)
            {
                if (item == "m")
                {
                    male++;
                }
                else if (item == "f")
                {
                    female++;
                }
                else
                { 
                    Console.WriteLine(item);
                }
                // var result = genders == "f" ? female++: male++:
            }
            Console.WriteLine("Number of male's: {0}", male);
            Console.WriteLine("Number of females's: {0}", female);
        }
    }
}

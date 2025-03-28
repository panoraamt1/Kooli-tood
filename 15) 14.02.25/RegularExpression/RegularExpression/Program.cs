using System.Text.RegularExpressions;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string word = "#CD5C5C";
            Console.WriteLine("Hex code: " +word);
            Console.WriteLine("Is Regex: " + RegExTest(word));

            string word2 = "#CFf64G";
            Console.WriteLine("Hex code: " + word2);
            Console.WriteLine("Is Regex: " + RegExTest(word2));
        }

        public static bool RegExTest(string word)
        {
            return Regex.IsMatch(word, @"[#][0-9A-Fa-f]{6}\b");
        }
    }
}

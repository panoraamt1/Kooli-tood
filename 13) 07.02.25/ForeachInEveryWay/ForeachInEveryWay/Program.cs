namespace ForeachInEveryWay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Kas soovid kasutada For või Foreach?");
            string vas = Console.ReadLine();

            switch (vas)
            {
                case "For" or "for":
                    ForWithList();
                break;

                case "Foreach" or "foreach":
                    ForeachWithList();
                break;
            }
                Console.ReadLine();
        }

        static void ForeachWithList()
        {
            var words = new List<string>() { "Why", "would", "you", "do", "this" };
            foreach (string word in words)
            {
                Console.Write("{0} ", word);
            }
        }

        static void ForWithList()
        {
            var words = new List<string>() { "For", "what", "was", "your", "reasone" };
            for (int i = 0; i < words.Count; i++)
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}

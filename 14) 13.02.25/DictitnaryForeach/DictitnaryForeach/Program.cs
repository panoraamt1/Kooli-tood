namespace DictitnaryForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary and foreach");
            var domains = new Dictionary<string, string>()
            {
                { "est", "Estonia" },
                { "lat", "Latvia" },
                { "fin", "Finland" },
                { "swe", "Sweden" }
            };
            int i = 1;

            foreach (var domain in domains)
            {
                Console.WriteLine($"{domain.Key} - {domain.Value} - {i++}");
                
            }
        }
    }
}

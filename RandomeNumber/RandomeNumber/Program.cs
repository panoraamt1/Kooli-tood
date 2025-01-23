namespace RandomeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Random rnd = new Random();
            int dice = rnd.Next(1, 7);

            switch (dice)
            {
                case 1:
                    Console.WriteLine("Veeretasid: " +dice);
                    break;
                case 2:
                    Console.WriteLine("Veeretasid: " + dice);
                    break;
                case 3:
                    Console.WriteLine("Veeretasid: " + dice);
                    break;
                case 4:
                    Console.WriteLine("Veeretasid: " + dice);
                    break;
                case 5:
                    Console.WriteLine("Veeretasid: " + dice);
                    break;
                case 6:
                    Console.WriteLine("Veeretasid: " + dice);
                    break;
                default:
                    Console.WriteLine("How?");
                    break;
            }

        }
    }
}

namespace MCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage esimene arv:");
            double earv = double.Parse(Console.ReadLine());

            Console.WriteLine("Sisestage teine arv:");
            double tarv = double.Parse(Console.ReadLine());

            Console.WriteLine("Sisestage tehe:");
            string tehe = (Console.ReadLine());

            if (tehe == "+")
            {
                Console.WriteLine("Tulemus: " + earv + "+" + tarv + "=" + (earv + tarv));
            }
            else if (tehe == "-")
            {
                Console.WriteLine("Tulemus: " + earv + "-" + tarv + "=" + (earv - tarv));
            }
            else if (tehe == "*")
            {
                Console.WriteLine("Tulemus: " + earv + "*" + tarv + "=" + (earv * tarv));
            }
            else if (tehe == "/" && tarv == 0)
            {
                Console.WriteLine("Can't devide with 0");
            }
            else if (tehe == "/")
            {
                Console.WriteLine("Tulemus: " + earv + "/" + tarv + "=" + (earv / tarv));
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}

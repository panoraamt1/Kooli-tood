namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swich");
            int arv = Convert.ToInt32(Console.ReadLine());

            switch (arv)
            {
                case int n when (n >= 0 && n <= 100):
                    Console.WriteLine("Sisestatud arv on 0 ja 100 ringis: " + arv);
                break;

                case int n when (n > 100 && n <= 200):
                    Console.WriteLine("Sisestatud arv on 101 ja 200 ringis: " + arv);
                break;

                case int n when (n > 200 && n <= 300):
                    Console.WriteLine("Sisestatud arv on 201 ja 300 ringis: " + arv);
                break;
                default:
                    Console.WriteLine("Sisesta arv 0-300.");
                break;
            }

            Console.ReadKey();
        }
    }

}

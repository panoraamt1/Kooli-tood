namespace Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ruut");
            //Ruudu sees olev ringi raadius on 3. Diameeter on 6

            double ruutpind = 6 * 6;
            Console.WriteLine("Ruudu pindala on " + ruutpind);

            double ruutYmber = 4 * 6;
            Console.WriteLine("Ruudu ümbermõõt on " + ruutYmber);

            int r = 3;
            int a = 2 * r;
            int P = 4 * a;
            int S = a * a;

            Console.WriteLine("Pindala " +S);
            Console.WriteLine("Ümbermõõt " +P);

            Console.WriteLine("Ringi pindala " + Math.PI * (r * r));
            Console.WriteLine("Ringi ümbermõõt " + 2 * Math.PI * r);

        }
    }
}

namespace ForMultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            Console.WriteLine("Sisestage tabelisse number, millest soovid alustada");
            n =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Korrutustabel ühest kuni ");
            Console.Write( "\n" );

            for (i = 1; i <= 10; i++)
            {
                Console.Write( "\n" ); 
                for (j = 1; j <= n; j++)
                {
                    if (i == j)
                    {
                        Console.Write("{0} X {1} = {2} \n", j, i, i * j);
                    }
                    else
                    {
                        Console.Write("{0} X {1} = {2} \n", j, i, i * j);
                    }
                }
            }
        }
    }
}

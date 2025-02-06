using System.Drawing;

namespace MShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Millist kujundit soovid? (Ruut, Ristkülik, Ring, Kolmnurk)");
            string n = Console.ReadLine();
            switch (n)
                {
                    case "ruut" or "Ruut":
                    Square();
                    break;

                    case "ristkülik" or "Ristkülik":
                    Rectangle();
                    break;

                    case "ring" or "Ring":
                    Circle();
                    break;

                    case "kolmnurk" or "Kolmnurk":
                    Triangle();
                    break;

                    default:
                    Console.WriteLine("Vaja on sisestada eelnevalt antud kujund.");
                    break;

            }
        }

        static void Square()
        {
            Console.WriteLine("Sisesta ruudu suurus");
            int a = int.Parse(Console.ReadLine());

            for (int row = 1; row <= a; row++)
            {
                for (int column = 1; column <= a; column++)
                {
                    string mark;
                    if (row == column || row + column <= a + 1)
                    {
                        mark = "* ";
                    }
                    else
                    {
                        mark = "* ";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Ruudu pindala on: " + a * a);
            Console.WriteLine("Ruudu ümbermõõt on: " + 4 * a);
        }

        static void Rectangle()
        {
            Console.WriteLine("Sisesta ristküliku esimene serv");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta ristküliku teine serv");
            int b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("See on ruut.");

                for (int row = 1; row <= a; row++)
                {
                    for (int column = 1; column <= a; column++)
                    {
                        string mark;
                        if (row == column || row + column <= a + 1)
                        {
                            mark = "* ";
                        }
                        else
                        {
                            mark = "* ";
                        }
                        Console.Write(mark);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Ruudu pindala on: " + a * a);
                Console.WriteLine("Ruudu ümbermõõt on: " + 4 * a);
            }
            else
            {
                for (int row = 1; row <= a; row++)
                {
                    for (int column = 1; column <= b; column++)
                    {
                        string mark;
                        if (row != column || row + column <= a + 1)
                        {
                            mark = "* ";
                        }
                        else
                        {
                            mark = "* ";
                        }
                        Console.Write(mark);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Ristküliku pindala on: " + a * b);
                Console.WriteLine("Ristküliku ümbermõõt on: " + ((2 * a) + (2 * b)));
            }
        }

        static void Circle()
        {
            double r;
            double thickness = 0.5;
            char symbol = '*';

            do
            {
                Console.WriteLine("Sisesta ringi raadius");
                if (!double.TryParse(Console.ReadLine(), out r) || r <= 0)
                {
                    Console.WriteLine("Radius peab olema positiivne number");
                }
            }
            while (r <= 0);

            Console.WriteLine();
            double rIn = r - thickness, rOut = r + thickness;

            for (double y = r; y >= -r; --y)
            {
                for (double x = -r; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine("Ringi pindala on: " + Math.PI * (r * r));
            Console.WriteLine("Ringi ümbermõõt on: " + 2 * Math.PI * r);
        }

        static void Triangle()
        {
            Console.WriteLine("Sisesta kolmnurga kõrgus");
            int h = int.Parse(Console.ReadLine());
            int a = ((2 * h)-1);

            for (int i = 0; i <= h; i++)
            {
                for (int j = 1; j <= h - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("Kolmnurga pindala on: " + ((a * h) / 2));
            Console.WriteLine("Kolmnurga ümbermõõt on: " + 3 * a);
        }
    }
}

namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to binary");

            int n1;
            string binaryNum = "";

            Console.WriteLine("Imput first number: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            while (n1 > 0)
            {
                int reminder = n1 % 2;
                binaryNum = reminder + binaryNum;
                n1 /= 2;
            }
            Console.WriteLine(binaryNum);
        }
    }
}

namespace IfAndElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number.");

            int aNumber = int.Parse(Console.ReadLine());
            if (aNumber > 0)
            {

                if (aNumber == 69)
                {
                    Console.WriteLine("Nice!");
                }

                 else if (aNumber >= 10)
                {
                    if (aNumber == 11)
                    {
                        Console.WriteLine(aNumber / aNumber + " What dose it mean to be 1?");
                    }

                    else
                    {
                        Console.WriteLine("Sinu arv on " + aNumber);
                    }
                }

                else
                {
                    Console.WriteLine("Sinu number oli " + aNumber * aNumber);
                }
            }
            
            else
            {
                if (aNumber == 0)
                {
                    Console.WriteLine("OK");
                }

                else
                {
                    Console.WriteLine("Mils nii negatiivne?");
                }
            }

        }
    }
}

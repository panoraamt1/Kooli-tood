namespace FailReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void FileWordReading()
        {
            string line;
            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/Administrator/Desktop/WriteToFile.txt"))
                {
                    int cnt = 0;
                    while (sr.EndOfStream == false)
                    {
                        cnt++;
                        line = sr.ReadLine();
                        int lenght = line.Length;
                        Console.WriteLine(cnt + " " + line + " " + lenght);
                    }
                    sr.Close();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Faili ei saa lugeda");
                Console.WriteLine();
                throw;
            }
        }
    }
}

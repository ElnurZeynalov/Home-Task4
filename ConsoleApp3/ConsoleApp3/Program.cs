using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int given = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sqrt(given)); 
        }
        static int Sqrt(int given)
        {
            int result = 0;
            while (given >= result * result) 
            {
                result++;
            }
            return result-1;
        }
    }
}

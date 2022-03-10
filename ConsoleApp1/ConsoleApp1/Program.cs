using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,3,5};
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=========");

            foreach (var item in add(array,7))
            {
                Console.WriteLine(item);
            }
        }
        static int[] add(int[] array , int n)
        {
            int[] array2 = new int[array.Length+1];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            array2[array.Length] = n;
            return array2;
        }
    }
}

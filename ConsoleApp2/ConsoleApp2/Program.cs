using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            
            Console.WriteLine(deleter(ref sentence));
        }
        static string deleter(ref string sentence)
        {
            string sentence2 = sentence.Replace(" ","");
            return sentence2;
        }
    }
}

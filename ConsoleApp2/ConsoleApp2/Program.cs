using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            
            Console.WriteLine(deleter(sentence));
           
        }
        static string deleter(string sentence)
        {
            string test = "";
           for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i]!=' ')
                    test+= sentence[i];   
            }
            return test;
        }
        
    }
}

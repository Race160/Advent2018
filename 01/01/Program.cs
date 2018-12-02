using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)      
        {
            Console.WriteLine($"{Part1()}");

            Console.Read();         
        }

        static int Part1()
        {
            string[] lines = System.IO.File.ReadAllLines("TextFile1.txt");

            int total = 0;

            foreach (string line in lines)
            {                
                total += Int32.Parse(line);
            }

            return total;
        }
    }
}

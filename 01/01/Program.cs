using System;
using System.Collections.Generic;

namespace _01
{
    class Program
    {
        static void Main(string[] args)      
        {
            Console.WriteLine($"{Part1()}");

            Console.WriteLine($"{Part2()}");

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

        static int? Part2()
        {
            string[] lines = System.IO.File.ReadAllLines("TextFile1.txt");

            int? repeat = null;
            int frequency = 0;

            List<int> values = new List<int>();

            while(repeat == null)
            {
                foreach (string line in lines)
                {
                    frequency += Int32.Parse(line);

                    if (values.Contains(frequency))
                    {
                        repeat = frequency;

                        break;
                    }
                    else
                    {
                        values.Add(frequency);
                    }
                }
            }            
            return repeat;
        }
    }
}

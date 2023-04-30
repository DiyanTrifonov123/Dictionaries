using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NechetniSreshtaniya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(' ').ToArray();
            Dictionary<string, int> statistika = new Dictionary<string, int>();

            foreach (var item in words)
            {
                if (statistika.ContainsKey(item))
                {
                    statistika[item]++;
                }
                else
                {
                    statistika.Add(item,1);
                }
            }

            foreach (var item in statistika)
            {
                if (item.Value % 2 == 1)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}

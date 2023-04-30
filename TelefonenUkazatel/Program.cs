using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonenUkazatel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                string name = tokens[1];

                switch (command)
                {
                    case "A":
                        string phone = tokens[2];
                        phoneBook.Add(name, phone); break;

                    case "S":
                        if (phoneBook.ContainsKey(name))
                        {
                            Console.WriteLine($"{name} -> {phoneBook[name]}");
                        }
                        else
                        {
                            Console.WriteLine($"Контактът {name} не съществува!");
                        }
                        break;

                    default:
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}

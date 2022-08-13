using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectNUmber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Tipni si cislo od 1 do 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Prosim pouzij normalni cislo...");
                        Console.ResetColor();
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Spatne, zkus to znovu");
                        Console.ResetColor();
                    }
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("TREFA!! Uhodl jsi cislo");
                Console.ResetColor();

                Console.WriteLine("Chces hrat znovu? [A or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "A")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }
    }
}
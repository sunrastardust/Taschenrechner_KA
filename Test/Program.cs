using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string weiter = "";
            while (weiter != "X" && weiter != "x")
            {
                Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
                double zahl1 = double.Parse(Console.ReadLine());

                if (((zahl1 % 2) != 1) && ((zahl1 % 2) != 0))
                {
                    Console.WriteLine("Es ist ein double");
                }
                else
                {
                    Console.WriteLine("Es ist ein int");
                }
                Console.WriteLine("Wollen Sie noch eine Zahl eingeben?");
                weiter = Console.ReadLine();
            }            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abfrage
             double z1 = 0;
            double z2 = 0;
            string ope = "";

            Console.WriteLine("\t\t-- Programm Taschenrechner --");
            while (ope != "X" && ope != "x")
            {
                Console.WriteLine("\n\nWelche Art von Rechnung Möchten Sie durchführen?\n\nAddition (+) \n\nSubtraktion (-) \n\nMultiplikation (*) \n\nDivision (/)\n\nAbbruch (x oder X)\n");
                Console.Write("\t");
                ope = Console.ReadLine();
                if (ope == "x" || ope == "X")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nAuf Wiedersehen!");
                    Console.ResetColor();
                    break;
                }
                Console.Write("\nErste Zahl: ");
                z1 = double.Parse(Console.ReadLine());
                Console.Write("\nZweite Zahl: ");
                z2 = double.Parse(Console.ReadLine());
                If(ope, z1, z2);
            }
        }

        //Methode +
        static double Add(double z1, double z2)
        {
            return z1 + z2;
        }
        //Methode -
        static double Sub(double z1, double z2)
        {
            double erg = 0;
            if ((z1 > 0 && z2 > 0) || (z1 < 0 && z2 < 0))
            {
                erg = z1 + (~z2 + 1);
            }
            else if ((z1 < 0) ^ (z2 < 0))
            {
                erg = z1 + (~z2 + 1);
            }
            return erg;
        }
        //Methode *
        static double Mul(double z1, double z2)
        {
            double erg = 0;
            double cnt = 0;
            if (z1 > 0 && z2 > 0)
            {
                while (cnt < z2)
                {
                    erg = z1 + erg;
                    cnt++;
                }
            }
            else if ((z1 > 0 && z2 < 0) || (z1 < 0 && z2 < 0))
            {
                while (cnt > z2)
                {
                    erg = (~z1 + 1) + erg;
                    cnt--;
                }
            }
            else
            {
                while (cnt > z1)
                {
                    erg = (~z2 + 1) + erg;
                    cnt--;
                }
            }
            return erg;
        }
        //Methode /
        static double Div(double z1, double z2)
        {
            double erg = 0;
            double cnt = z2;
            if (z1 > 0 && z2 > 0)
                while (cnt <= z1)
                {
                    cnt = z2 + cnt;
                    erg++;
                }
            else if (z1 < 0 && z2 < 0)
            {
                while (cnt >= z1)
                {
                    cnt = cnt + z2;
                    erg++;
                }
            }
            else if (z1 < 0)
            {
                while (z1 <= (~cnt + 1))
                {
                    cnt = z2 + cnt;
                    erg--;
                }
            }
            else
            {
                while ((~z1 + 1) <= cnt)
                {
                    cnt = z2 + cnt;
                    erg--;
                }
            }

            return erg;

        }
        //Medothe if
        static void If(string ope, double z1, double z2)
        {
            double erg = 0;
            if (ope == "+")
            {
                erg = Add(z1, z2);
                Aus(erg, z1, z2, ope);
            }
            if (ope == "-")
            {
                erg = Sub(z1, z2);
                Aus(erg, z1, z2, ope);
            }
            if (ope == "*")
            {
                erg = Mul(z1, z2);
                Aus(erg, z1, z2, ope);
            }
            if (ope == "/" && z2 != 0 && z1 != 0)
            {
                erg = Div(z1, z2);
                Aus(erg, z1, z2, ope);
            }
        }
        //Methode Ausgabe
        static void Aus(double erg, double z1, double z2, string ope)
        {
            if (erg > 0)
            {
                Console.Write($"\n{z1} {ope} {z2} = ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{erg}");
                Console.ResetColor();
            }
            else if (erg < 0)
            {
                Console.Write($"\n{z1} {ope} {z2} = ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{erg}");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Ihre eingabe mindestens einmal 0");
            }
        }
    }
}

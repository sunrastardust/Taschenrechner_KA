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
            int z1 = 0;
            int z2 = 0;
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
                z1 = int.Parse(Console.ReadLine());
                Console.Write("\nZweite Zahl: ");
                z2 = int.Parse(Console.ReadLine());
                If(ope, z1, z2);
            }
        }

        //Methode +
        static int Add(int z1, int z2)
        {
            return z1 + z2;
        }
        //Methode -
        static int Sub(int z1, int z2)
        {
            int erg = 0;
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
        static int Mul(int z1, int z2)
        {
            int erg = 0;
            int cnt = 0;
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
        static int Div(int z1, int z2)
        {
            int erg = 0;
            int cnt = z2;
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
        static void If(string ope, int z1, int z2)
        {
            int erg = 0;
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
            if (ope == "/" && z2 !=0 && z1 != 0)
            {
                erg = Div(z1, z2);
                Aus(erg, z1, z2, ope);
            }
        }
        //Methode Ausgabe
        static void Aus(int erg, int z1, int z2, string ope)
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

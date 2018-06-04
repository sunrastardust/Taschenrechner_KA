using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Übung_Ein_und_Ausgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo, wie geht es dir, mir geht es gut.\n");
            Console.ReadLine();
            Console.WriteLine("\nIch hoffe du hast gut gesagt, denn momentan\nkann ich dir nur Fragen stellen, aber dich noch\nnicht Verstehen,");
            Console.Write("\nMit Console.WriteLine(); erzähle ich dem Benutzer was man möchte,");
            Console.Write("\n\nmit Console.Write(); schreibst du in der Zeile weiter.\n\nMit Backslash und n wechselst du in die nächste Zeile\n\nandere Zeichen lernen wir später.");
            Console.WriteLine("\nEinfacher ist es mit cw tab tab, denn Console:WriteLine(); wird gleich fertig geschrieben.");
            Console.WriteLine("\n\nIch kann auch rechnen");
            Console.WriteLine($"\nz.B. 7 + 3 = {7+3}");
            Console.WriteLine($"Ein gleines geheimnis habe ich, am liebsten Addiere ich, also 7 - 3 = {7+(~3 + 1)} \nist für mich nicht 7 - 3 wie ich das mach oder warum könnt ihr in\n\n");
            Console.WriteLine("\nUnd wir haben schon ein neues Zeichen gelernt, ein $ Zeichen vor dem ersten\n\nAnführungszeichen schaft uns einen Platzhalter");
            Console.ReadKey();
        }
    }
}

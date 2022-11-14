using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Finanzassisten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Vallah = false;
            bool DateiAverwendbar= false;
            bool DateiAVerstanden = false;
            bool? DateiAVorhanden = null;
            bool? Fertig = null;
            var Einnahmen = @"" + Properties.Settings.Default.Einnahmen;
            var Ausgaben =@""+ Properties.Settings.Default.Ausgaben;
            List<int> EinnahmenListe = new List<int>();
            if (Einnahmen == "")
            {
                Console.WriteLine("Haben sie schon eine Datei mit ihren Einnahmen ? [J/N]");
                while (DateiAVorhanden == null)
                {
                    char key = Console.ReadKey().KeyChar;
                    switch (key)
                    {
                        case 'j':
                            DateiAVorhanden = true;
                            break;
                        case 'n':
                            DateiAVorhanden = false;
                            break;
                        case 'J':
                            DateiAVorhanden = true;
                            break;
                        case 'N':
                            DateiAVorhanden= false;
                            break;
                            
                        default:
                            Console.WriteLine("invalid input");
                            break;
                    }
                    
                }
                while (!DateiAverwendbar)
                {
                    if (DateiAVorhanden == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(@"Geben Sie den Dateipfad ein. Beispiel ---> C:\Benutzer\jfrey\documents\Hallo\Test.txt");
                        while (!Vallah)
                        {
                            try
                            {
                                Einnahmen = Convert.ToString(Console.ReadLine());
                                Properties.Settings.Default.Einnahmen = @"";
                                Vallah = true;
                            }
                            catch
                            {
                                Console.WriteLine("invalid File path");
                            }
                            DateiAverwendbar = true;
                        }
                    }
                    else if (DateiAVorhanden == false)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Erstellen Sie eine txt. Datei und halten sie den Dateipfad bereit.");
                        Console.WriteLine("Wenn Sie das erledigt haben, drücken Sie die Taste J");
                        while (Fertig == null)
                        {
                            char key2 = Console.ReadKey().KeyChar;
                            switch (key2)
                            {
                                case 'j':
                                    Fertig = true;
                                    DateiAVorhanden = true;
                                    break;
                                case 'n':
                                    Fertig = false;
                                    DateiAVorhanden = false;
                                    break;
                                case 'J':
                                    Fertig = true;
                                    DateiAVorhanden = true;
                                    break;
                                case 'N':
                                    Fertig = false;
                                    DateiAVorhanden = false;
                                    break;

                                default:
                                    Console.WriteLine("invalid input");
                                    break;
                            }
                            
                        }
                    }
                }
                Console.ReadLine();
                Console.WriteLine(Einnahmen);
                Console.ReadLine();
               
            } 
        }
    }
}

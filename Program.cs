using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestVersion1
{
    static class Program
    {
        static void Main(string[] args)
        {
            bool schleife = false;
            bool dateiAverwendbar = false;
            bool dateiBverwendbar = false;
            bool? dateiBVorhanden = null;
            bool schleife2 = false;
            bool dateiPfad1Korrekt = false;
            bool? dateiAVorhanden = null;
            bool? fertig = null;
            bool? fertig1 = null;
            bool? dateiAKorrekt = null;
            bool? korrekt = null;
            bool? vermerkung = null;
            bool vermerkungAntwort = false;
            string Antwort = "0";
            bool vermerkungsSchleife = false;
            bool schleife1 = false;



            string einnahmenPfad = Properties.Settings.Default.Einnahmen;
            string ausgabenPfad = Properties.Settings.Default.Ausgaben;
            var einnahmenPfad1 = Properties.Settings.Default.Einnahmen;
            var ausgabenPfad1 = Properties.Settings.Default.Ausgaben;


            List<int> EinnahmenListe = new List<int>();
            
            bool exception = false;


            //Einnahmen Pfad
            while (einnahmenPfad1 == "")

            {
                Console.WriteLine("Haben sie schon eine Datei mit ihren Einnahmen ? [J/N]");
                while (dateiAVorhanden == null)
                {
                    char key = Console.ReadKey().KeyChar;
                    switch (key)
                    {
                        case 'j':
                            dateiAVorhanden = true;
                            break;
                        case 'n':
                            dateiAVorhanden = false;
                            break;
                        case 'J':
                            dateiAVorhanden = true;
                            break;
                        case 'N':
                            dateiAVorhanden = false;
                            break;

                        default:
                            Console.WriteLine("invalid input");
                            break;
                    }

                }
                while (!dateiAverwendbar)
                {
                    if (dateiAVorhanden == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(@"Geben Sie den Dateipfad ein. Beispiel ---> C:\Benutzer\jfrey\documents\Hallo\Test.txt");
                        while (!schleife)
                        {
                            try
                            {
                                einnahmenPfad1 = Convert.ToString(Console.ReadLine());
                                Properties.Settings.Default.Einnahmen = einnahmenPfad1;
                                Properties.Settings.Default.Save();
                                schleife = true;
                            }
                            catch
                            {
                                Console.WriteLine("invalid File path");
                            }
                            dateiAverwendbar = true;
                        }
                    }
                    else if (dateiAVorhanden == false)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Erstellen Sie eine txt. Datei und halten sie den Dateipfad bereit.");
                        Console.WriteLine("Wenn Sie das erledigt haben, drücken Sie die Taste J");
                        while (fertig == null)
                        {
                            char key2 = Console.ReadKey().KeyChar;
                            switch (key2)
                            {
                                case 'j':
                                    fertig = true;
                                    dateiAVorhanden = true;
                                    break;
                                case 'n':
                                    fertig = false;
                                    dateiAVorhanden = false;
                                    break;
                                case 'J':
                                    fertig = true;
                                    dateiAVorhanden = true;
                                    break;
                                case 'N':
                                    fertig = false;
                                    dateiAVorhanden = false;
                                    break;

                                default:
                                    Console.WriteLine("invalid input");
                                    break;
                            }
                        }
                    }
                }
            }




            //Ausgaben Pfad
            while (ausgabenPfad1 =="")

            {
                Console.WriteLine("Haben sie schon eine Datei mit ihren Ausgaben ? [J/N]");
                while (dateiBVorhanden == null)
                {
                    char key5 = Console.ReadKey().KeyChar;
                    switch (key5)
                    {
                        case 'j':
                            dateiBVorhanden = true;                          
                            break;
                        case 'n':
                            dateiBVorhanden = false;
                            break;
                        case 'J':
                            dateiBVorhanden = true;
                            break;
                        case 'N':
                            dateiBVorhanden = false;
                            break;
                        default:
                            Console.WriteLine("invalid input");
                            break;
                    }

                }
                while (!dateiBverwendbar)
                {
                    if (dateiBVorhanden == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(@"Geben Sie den Dateipfad ein. Beispiel ---> C:\Benutzer\jfrey\documents\Hallo\Test.txt");
                        while (!schleife1)
                        {
                            try
                            {
                                einnahmenPfad1 = Convert.ToString(Console.ReadLine());
                                einnahmenPfad1 = Properties.Settings.Default.Ausgaben;
                                Properties.Settings.Default.Save();
                                schleife1 = true;
                            }
                            catch
                            {
                                Console.WriteLine("invalid File path");
                            }
                            dateiBverwendbar = true;
                        }
                    }
                    else if (dateiBVorhanden == false)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Erstellen Sie eine txt. Datei und halten sie den Dateipfad bereit.");
                        Console.WriteLine("Wenn Sie das erledigt haben, drücken Sie die Taste J");
                        while (fertig1 == null)
                        {
                            char key6 = Console.ReadKey().KeyChar;
                            switch (key6)
                            {
                                case 'j':
                                    fertig1 = true;
                                    dateiBVorhanden = true;
                                    dateiBverwendbar = true;
                                    break;
                                case 'n':
                                    fertig1 = false;
                                    dateiBVorhanden = false;
                                    break;
                                case 'J':
                                    fertig1 = true;
                                    dateiBVorhanden = true;
                                    dateiBverwendbar = true;
                                    break;
                                case 'N':
                                    fertig1 = false;
                                    dateiBVorhanden = false;
                                    break;

                                default:
                                    Console.WriteLine("invalid input");
                                    break;
                            }
                        }
                    }
                }
            }
            while (!dateiPfad1Korrekt)
            {

                Console.WriteLine("Ist der Dateipfad " + einnahmenPfad1 + " und "+ ausgabenPfad1+ " korrekt ? [J/N]");
                char key3 = Console.ReadKey().KeyChar;
                while (korrekt == null)
                {
                    switch (key3)
                    {
                        case 'j':
                            korrekt = true;
                            dateiAKorrekt = true;
                            dateiPfad1Korrekt = true;
                            break;
                        case 'n':
                            korrekt = false;
                            dateiAKorrekt = false;
                            break;
                        case 'J':
                            korrekt = true;
                            dateiAKorrekt = true;
                            dateiPfad1Korrekt = true;
                            break;
                        case 'N':
                            korrekt = false;
                            dateiAKorrekt = false;
                            break;

                        default:
                            Console.WriteLine("invalid input");
                            break;
                    }
                }
                if (dateiAKorrekt == false)
                {
                    Console.WriteLine("");
                    Console.Write("Geben sie ihre Dateipfäde ein:");
                    Console.WriteLine("");
                    while (!schleife2)
                    {
                        try
                        {
                            Console.Write("Einnahmenpfad:");
                            einnahmenPfad1 = Properties.Settings.Default.Einnahmen;
                            einnahmenPfad1 = Convert.ToString(Console.ReadLine());
                            Properties.Settings.Default.Einnahmen = einnahmenPfad1;
                            Properties.Settings.Default.Save();
                            Console.Write("Ausgabenpfad:");
                            ausgabenPfad1 = Properties.Settings.Default.Ausgaben;
                            ausgabenPfad1 = Convert.ToString(Console.ReadLine());
                            Properties.Settings.Default.Save();
                            schleife2 = true;
                            dateiAKorrekt = true;
                        }
                        catch
                        {
                            Console.WriteLine("invalid file path ");
                        }
                    }
                }

                else if (dateiAKorrekt == true)
                {

                    string Dat1text = Properties.Settings.Default.Einnahmen;
                    Console.ReadLine();
                    Dat1text = File.ReadAllText(@einnahmenPfad1);
                    string Dat2text = File.ReadAllText(ausgabenPfad1);                    
                    string[] Linien1 = Dat1text.Split('\n');                   
                    string[] Linien2 = Dat2text.Split('\n');
                    string Menge;
                    string[] Wörter1;
                    string[] Wörter2;
                    //string[] Linien1 = new.string[words1];
                    int[] items;

                    do
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Wollen Sie etwas vermerken?[J/N]");
                        Console.WriteLine("");
                        while (vermerkung == null)
                        {
                            char key4 = Console.ReadKey().KeyChar;
                            switch (key4)
                            {
                                case 'j':
                                    vermerkung = true;
                                    vermerkungAntwort = true;
                                    break;
                                case 'n':
                                    vermerkung = false;
                                    vermerkungAntwort = false;
                                    break;
                                case 'J':
                                    vermerkung = true;
                                    vermerkungAntwort = true;
                                    break;
                                case 'N':
                                    vermerkung = false;
                                    vermerkungAntwort = false;
                                    break;

                                default:
                                    Console.WriteLine("invalid input");
                                    break;
                            }
                        }
                        if (vermerkungAntwort == true)
                        {
                            Console.WriteLine("Wollen Sie eine Einnahme oder eine Ausgabe vermerken?");
                            while (!vermerkungsSchleife)
                            {
                                try
                                {
                                    Antwort = Console.ReadLine();
                                    vermerkungsSchleife = true;
                                }
                                catch
                                {
                                    Console.WriteLine("invalid Input");

                                }

                            }

                            if (Antwort == "Einnahme")
                            {
                                Console.WriteLine("Menge:");
                                Menge = Dat1text + Console.ReadLine();
                                File.WriteAllText(einnahmenPfad, Menge);
                                // items = Linien1[10000].Split(',');
                                //Console.WriteLine(items[0]);
                            }
                            else if (Antwort == "Ausgabe")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("2");
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Falsche Eingabe");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                            }
                        } else if (vermerkungAntwort == false)
                        {
                            Console.WriteLine("Schade");
                        }

                    } while (exception == true);

                    int Zeilennummer1 = Linien1.Length;
                    int Zeilennummer2 = Linien2.Length;

                    int Ausgaben2 = 0;
                    int Einnahmen2 = 0;

                    for (int i = 0; i <= Zeilennummer1 - 1; i++)
                    {
                        Einnahmen2 = Einnahmen2 + Convert.ToInt32(Linien1[i]);

                    }
                    //Console.WriteLine(Einnahmen);

                    for (int j = 0; j <= Zeilennummer2 - 1; j++)
                    {
                        Ausgaben2 = Ausgaben2 + Convert.ToInt32(Linien2[j]);

                    }
                    //Console.WriteLine(Ausgaben);

                    int Verdienst = Einnahmen2 - Ausgaben2;
                    int Sparziel = 0;
                    bool TryCatch = false;

                    if (Verdienst < 0)
                    {
                        Console.WriteLine("Sie machen " + Verdienst + " Franken minus pro Monat");
                    }
                    else
                    {
                        Console.WriteLine("Sie machen " + Verdienst + " Franken plus pro Monat");
                    }
                    bool B = false;
                    do
                    {
                        do
                        {
                            try
                            {
                                Console.WriteLine("Wie viel Geld wollen sie sparen?");
                                Sparziel = Convert.ToInt32(Console.ReadLine());
                                TryCatch = true;
                            }
                            catch
                            {
                                Console.WriteLine("Ungültige Eingabe");
                                TryCatch = false;
                            }
                        } while (TryCatch == false);

                        if (Verdienst < 0)
                        {
                            Console.WriteLine("Da Sie monatlich kein Geld verdienen macht es keinen Sinn zu Spaaren");

                        }

                        int Sparzeit = Sparziel / Verdienst;
                        int Jahre = 0;
                        int Gschanmargo69 = Sparzeit;
                        if (Sparzeit > 48)
                        {
                            Jahre = Sparzeit / 12;
                        }
                        
                        if (Jahre > 25)
                        {
                            Console.WriteLine("Sie wollen " + Jahre + " Jahre sparen was ziemlich lange ist, vielleicht sollten Sie sich ein realistischeres Ziel setzen.");
                            B = true;
                        }
                        else if (Gschanmargo69 > 48)
                        {
                            Console.WriteLine("Sie werden " + Jahre + " Jahre brauchen um das Ziel zu erreichen");
                            B = false;
                        }
                        else
                        {
                            Console.WriteLine("Sie werden " + Gschanmargo69 + 1 + " Monate brauchen um das Ziel zu erreichen");
                            B = false;
                        }
                    } while (B);
                    

                }
            }



        }
    }
}

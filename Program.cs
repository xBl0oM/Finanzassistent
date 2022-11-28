using System.Linq.Expressions;

namespace fgj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Dateipfad1 = @"C:\Users\haldi\OneDrive\Desktop\Finnannzassisstent.txt";
            string Dateipfad2 = @"C:\Users\haldi\OneDrive\Desktop\Finnannzassisstent2.txt";

            string Datei1 = File.ReadAllText(Dateipfad1);
            string Datei2 = File.ReadAllText(Dateipfad2);

            string[] Linien1 = Datei1.Split("\r\n");
            string[] Linien2 = Datei2.Split("\r\n");

            int Zeilennummer1 = Linien1.Length;
            int Zeilennummer2 = Linien2.Length;

            int Ausgaben = 0;
            int Einnahmen = 0;

            for (int i = 0; i <= Zeilennummer1-1; i++)
            {
                Einnahmen = Einnahmen + Convert.ToInt32(Linien1[i]);

            }
            //Console.WriteLine(Einnahmen);

            for (int j = 0; j <= Zeilennummer2 - 1; j++)
            {
                Ausgaben = Ausgaben + Convert.ToInt32(Linien2[j]);

            }
            //Console.WriteLine(Ausgaben);

            int Verdienst = Einnahmen - Ausgaben;
            int Sparziel = 0;
            bool TryCatch = false;

            if (Verdienst<0)
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
                    B=false;
                }
                else
                {
                    Console.WriteLine("Sie werden " + Gschanmargo69+1 + " Monate brauchen um das Ziel zu erreichen");
                    B=false;
                }
            } while (B == true);
        }
    }
}
namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Einnahme = 0;
            int Ausgabe = 0;
            string Antwort;
            bool exception = false;
            string Dat1 = @"C:\Users\ben-l\OneDrive - Alte Kantonsschule Aarau\Desktop\momentan\Finanzassistent\Einnahmen.csv";
            string Dat2 = @"C:\Users\ben-l\OneDrive - Alte Kantonsschule Aarau\Desktop\momentan\Finanzassistent\Ausgaben.csv";
            string Dat1text = File.ReadAllText(Dat1);
            string Dat2text = File.ReadAllText(Dat2);
            string[] Linien1 = Dat1text.Split("\r\n");
            string[] Linien2 = Dat2text.Split("\r\n");
            string Menge;
            string[] Wörter1;
            string[] Wörter2;
            //string[] Linien1 = new.string[words1];
            int[] items;




          
            
           
               
         
           


            do
            {
                Console.WriteLine("");
                Console.WriteLine("Wollen Sie eine Einnahme oder eine Ausgabe vermerken?");
                Console.WriteLine("");
                Antwort = Console.ReadLine();

                exception = false;
                if (Antwort == "Einnahme")
                {
                    Console.WriteLine("Menge:");
                    Menge = Dat1text+Console.ReadLine();
                    File.WriteAllText(Dat1, Menge);
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
                    exception = true;
                }

            } while (exception == true);






        }
    }
}
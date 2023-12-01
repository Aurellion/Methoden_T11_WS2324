namespace Methoden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nochmal;
            Console.WriteLine("Arbeiten mit Methoden.");
            do
            {
                string auswahl;
                Console.WriteLine("1: Quersumme berechnen");
                Console.WriteLine("2: Zeichen ersetzen");
                Console.WriteLine("3: Vokale entfernen");

                Console.Write("Auswahl:");
                auswahl=Console.ReadLine();
                switch(auswahl)
                {
                    case "1":
                        //Eingabe
                        int Zahl;
                        Console.Write("Zahl eingeben:");
                        Zahl = Convert.ToInt32(Console.ReadLine());
                        //Verarbeitung
                        int Ausgabe=0;
                        Ausgabe = Quersumme(Zahl);
                        //Ausgabe
                        Console.WriteLine($"Die Quersumme von {Zahl} ist {Ausgabe}");
                        break;
                    case "2":
                        //Eingabe
                        Console.WriteLine("Text eigeben:");
                        string text = Console.ReadLine();
                        Console.Write("Welches zeichen soll ersetzt werden? ");
                        string zuErsetzen = Console.ReadLine();
                        Console.Write($"Wodurch soll {zuErsetzen} ersetzt werden? ");
                        string Ersatz = Console.ReadLine();
                        //Verarbeitung
                        string neuerText = ZeichenErsetzen(text, zuErsetzen, Ersatz);
                        //Ausgabe
                        Console.WriteLine(neuerText);
                        break;
                    case "3":
                        Console.WriteLine("Vokale aus der Eingabe entfernen:");
                        Console.Write("Eingabe:");
                        string eingabe = Console.ReadLine();

                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe!");
                        break;
                }

                Console.Write("Neue Auswahl? (j/n)");
                nochmal = Console.ReadLine();
            }while (nochmal=="j" || nochmal =="J");
        }

        static int Quersumme(int Eingabezahl)
        { 
            string Zahl = Eingabezahl.ToString();
            int Ausgabe = 0;
            for (int i = 0; i < Zahl.Length; i++)
            {
                Ausgabe += Convert.ToInt32(Zahl[i].ToString());                
            }
            return Ausgabe; 
        }

        static string ZeichenErsetzen(string text, string zuErsetzen, string Ersatz)
        {
            string ausgabe="";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].ToString() == zuErsetzen)
                {
                    ausgabe += Ersatz;
                }
                else
                {
                    ausgabe += text[i].ToString();
                }
            }
            return ausgabe;
        }
    }
}
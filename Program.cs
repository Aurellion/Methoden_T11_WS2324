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
                Console.WriteLine("4: Passwortstärke prüfen");

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
                        List<string> Vokalliste = new List<string>
                        {
                            "a", "i", "e", "o", "u", "ü", "ö", "ä"
                        };
                        foreach (string ch in Vokalliste)
                        {
                            eingabe = ZeichenErsetzen(eingabe.ToLower(), ch, "");                            
                        }
                        Console.WriteLine("Text ohne Vokale:");
                        Console.WriteLine(eingabe);
                        break;
                    case "4":
                        bool schlechtesPasswort = true;
                        do
                        {

                            Console.WriteLine("Das Passwort soll mindestens acht zeichen lang "
                                             +"sein, Groß- und \nKleinbuchstaben, sowie Zahlen"
                                             +"und Sonderzeichen enthalten.");
                            Console.Write("Testpasswort:");
                            string passwort = Console.ReadLine();

                            if (passwort.Length < 8)
                            {
                                Console.WriteLine("Das Passwort ist zu kurz!");
                            }
                            else if (!EnthältKleinbuchstaben(passwort))
                            {
                                Console.WriteLine("Das Passwort enthält keine Kleinbuchstaben!");
                            }
                            else if (!EnthältGrossbuchstaben(passwort))
                            {
                                Console.WriteLine("Das Passwort enthält keine Großbuchstaben!");
                            }
                            else if (!EnthältZahlen(passwort))
                            {
                                Console.WriteLine("Das Passwort enthält keine Zahlen!");
                            }
                            else if (!EnthältSonderzeichen(passwort))
                            {
                                Console.WriteLine("Das Passwort enthält keine Sonderzeichen!");
                            }
                            else
                            {
                                Console.WriteLine("Gutes Passwort!");
                                schlechtesPasswort = false;
                            }

                        } while (schlechtesPasswort);
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

        static bool EnthältKleinbuchstaben(string text)
        {
            bool Bedingung=false;
            foreach(char ch in text)
            {
                if (Char.IsLower(ch)) {Bedingung = true;}
            }
            return Bedingung;
        }

        static bool EnthältGrossbuchstaben(string text)
        {
            bool Bedingung = false;
            foreach (char ch in text)
            {
                if (Char.IsUpper(ch)) { Bedingung = true; }
            }
            return Bedingung;
        }

        static bool EnthältZahlen(string text)
        {
            bool Bedingung = false;
            foreach (char ch in text)
            {
                if (Char.IsDigit(ch)) { Bedingung = true; }
            }
            return Bedingung;
        }

        static bool EnthältSonderzeichen(string text)
        {
            bool Bedingung = false;
            foreach (char ch in text)
            {
                if (!Char.IsLetterOrDigit(ch)) { Bedingung = true; }
            }
            return Bedingung;
        }
    }
}
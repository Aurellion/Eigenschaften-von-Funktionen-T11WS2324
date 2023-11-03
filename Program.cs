namespace Eigenschaften_von_Funktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wiederholung;
            do
            {
                //Menü
                int auswahl;
                Console.WriteLine("Menü:");
                Console.WriteLine("1: Eigenschaften einer lin. Fkt. bestimmen.");
                Console.WriteLine("2: Gleichung einer lin. Fkt. aus zwei Punkten bestimmen.");
                Console.WriteLine("3: Programm beenden.");
                Console.Write("Auswahl:");
                auswahl = Convert.ToInt32(Console.ReadLine());

                if (auswahl == 1)
                {
                    string Begrüßungstext = "Eigenschaften von linearen Funktionen sollen bestimmt werden. \n Funktionsgleichung y=f(x)=mx+n.";
                    Console.WriteLine(Begrüßungstext);
                    double m, n;
                    Console.WriteLine("Koeffizienten angeben:");
                    Console.Write("m=");
                    m = Convert.ToDouble(Console.ReadLine());
                    Console.Write("n=");
                    n = Convert.ToDouble(Console.ReadLine());

                    //Nullstelle
                    string nullstelle;
                    double nst = -n / m;
                    nullstelle = $"Die Nullstelle von f(x) ist bei x={nst}.";
                    //Monotonie
                    string monotonie;
                    if (m > 0) { monotonie = "f(x) ist streng monotom wachsend."; }
                    else { monotonie = "f(x) ist streng monotom fallend."; }

                    Console.WriteLine("{0}\n{1}", nullstelle, monotonie);
                }
                else if (auswahl == 2)
                {
                    //Eingabe

                    //Verarbeitung

                    //Ausgabe
                }
                else if (auswahl == 3) { Environment.Exit(0); }
                else { Console.WriteLine("Ungültige Eingabe!"); }


                Console.Write("Weitere Berechnung? (j/n)");
                wiederholung = Console.ReadLine();
            } while (wiederholung == "j");

    

            
            
        }
    }
}
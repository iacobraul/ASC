//Automat vanzari
using System.Data;

class Program
{
    enum Stare { A, B, C, D };
    static void Main(string[] args)
    {
        Stare stareCurenta = Stare.A;
        int bani = 0;
        bool produsEliberat = false;
        bool returnNickel = false;
        bool returnDime = false;

        while (!produsEliberat)
        {   
            Console.Clear();
            Console.WriteLine("Cost Produs: 20c");
            Console.WriteLine($"Bani introdusi: {bani}c");
            Console.WriteLine("Introduceti o moneda N(5c), D(10c), Q(25c):");
            string moneda = Console.ReadLine().ToUpper();
            
            switch (stareCurenta)
            {
                case Stare.A:
                    if (moneda == "N") { bani += 5; stareCurenta = Stare.B; }
                    else if (moneda == "D") { bani += 10; stareCurenta = Stare.C; }
                    else if (moneda == "Q") { bani += 25; produsEliberat = true; returnNickel = true; stareCurenta = Stare.A; }
                    break;
                case Stare.B:
                    if (moneda == "N") { bani += 5; stareCurenta = Stare.C; }
                    else if (moneda == "D") { bani += 10; stareCurenta = Stare.D; }
                    else if (moneda == "Q") { bani += 25; produsEliberat = true; returnDime = true; stareCurenta = Stare.A; }
                    break;
                case Stare.C:
                    if (moneda == "N") { bani += 5; stareCurenta = Stare.D; }
                    else if (moneda == "D") { bani += 10; produsEliberat = true; stareCurenta = Stare.D; }
                    else if (moneda == "Q") { bani += 25; produsEliberat = true; returnNickel = true; returnDime = true; stareCurenta = Stare.A; }
                    break;
                case Stare.D:
                    if (moneda == "N") { bani += 5; produsEliberat = true; stareCurenta = Stare.A; }
                    else if (moneda == "D") { bani += 10; produsEliberat = true; returnNickel = true; stareCurenta = Stare.A; }
                    else if (moneda == "Q") { bani += 25; produsEliberat = true; returnNickel = true; returnDime = true; stareCurenta = Stare.B; }
                    break;
            }
        }

        Console.Clear();
        Console.WriteLine($"Bani introdusi: {bani}");
        if (produsEliberat)
        {
            Console.WriteLine("Produs eliberat!");
            if (stareCurenta == Stare.B) { Console.WriteLine("Returnare 5c");}
            if (returnNickel) Console.WriteLine("Returnare 5c");
            if (returnDime) Console.WriteLine("Returnare 10c");
        }
    }
}
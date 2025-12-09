//Sa se determine daca o secventa de n numere este monotona.
//Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("n=");
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Primul numar:");

        int prev = int .Parse(Console.ReadLine());

        bool cresc = true;
        bool desc = true;

        for (int i = 2; i <= n; i++)
        {
            Console.WriteLine("Urmatorul numar:");
            int x = int.Parse(Console.ReadLine());

            if (x > prev)
            {
                desc = false;
            }
            else if (x < prev)
            {
                cresc = false;
            }

            prev = x;
        }

        if (cresc || desc)
        {
            Console.WriteLine("Secventa este monotona.");
        }
        else
        {
            Console.WriteLine("Secventa nu este monotona.");
        }
    }
}
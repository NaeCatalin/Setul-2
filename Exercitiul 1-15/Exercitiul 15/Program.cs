//O secventa bitonica este o secventa de numere care incepe monoton crescator
//si continua monoton descrecator.
//De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica.
//Se da o secventa de n numere.
//Sa se determine daca este bitonica.


using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Console.WriteLine("n=");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Primul numar:");
        int prev = int.Parse(Console.ReadLine());

        bool crescator = true;
        bool bitonica = true;
        bool descrescator = false;
        bool hasIncreased = false;

        for (int i = 2; i < n; i++)
        {
            Console.WriteLine("Numarul" + i + ":");
            int x = int.Parse(Console.ReadLine());

            if (x>prev)
            {
                if (crescator)
                {
                    bitonica = true;

                }
                hasIncreased = true;

            }
            else if (x < prev)
            {
            if (!crescator) 
                    crescator = false;

               descrescator = true;
            }
            prev = x;
        }
        if (!crescator || !descrescator)
            bitonica = false;
        
        if (bitonica)
            Console.WriteLine("Secventa este bitonica");
        else
            Console.WriteLine("Secventa nu este bitonica");
    }
}

//Se da o secventa de n numere.
//Care este numarul maxim de numere consecutive egale din secventa. 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("n=");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Primul numar:");
        int prev = int.Parse(Console.ReadLine());

        int currentCount = 1; //lungimea curenta de elemente egale
                int maxCount = 1; //lungimea maxima de elemente egale

        for (int i = 2; i < n; i++)
        {
            Console.WriteLine("Urmatorul numar:");
            int x = int.Parse(Console.ReadLine());

            if (x==prev)
            {
                currentCount++;
            }
            else
            {
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
                currentCount = 1; //resetam lungimea curenta
            }
            prev = x;
        }
        //Verificam la final
        if (currentCount > maxCount) 
        maxCount = currentCount;
        Console.WriteLine("Numarul maxim de numere consecutive egale este: " + maxCount);
    }
}
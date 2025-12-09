//Se da o secventa de n numere.
//Se cere sa se caculeze suma inverselor acestor numere. 

using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main()
    {
        Console.WriteLine("n = ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i =1; i <= n; i ++)
        {
            Console.WriteLine("Numarul " + i + ":" );
            double x = double.Parse(Console.ReadLine());
            // evitam impartirea la 0
            if (x !=0)
            {
                sum += 1 / x;
            }
            else
            {
                Console.WriteLine("Impartirea la 0 nu este permisa, numarul va fi ignorat.");
            }
            Console.WriteLine("Suma inverselor este: " + sum);
        }

    }
}
//Se da o secventa de n numere.
//Sa se determine daca numerele din secventa sunt in ordine crescatoare. 

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool crescator = true;

        int anterior = int.Parse(Console.ReadLine()); //Citim primul nr

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());

            if (x == anterior)
                crescator = false;

            anterior = x; //Actualizam ultimu nr
        }
        if (crescator)
            Console.WriteLine("DA");
        else
            Console.WriteLine("NU");
    }
}
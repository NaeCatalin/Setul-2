//Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a.
//Se considera ca primul element din secventa este pe pozitia zero.
//Daca numarul nu se afla in secventa raspunsul va fi -1. 
using System;

class program
{
    static void Main()
    {
        int n = int. Parse(Console.ReadLine());
        int a = int.Parse(Console.ReadLine()); // numarul de gasit
        int pozitive = -1; 

        for (int i = 0;i<n;i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x == a && pozitive == -1)
            {
                pozitive = i;
            }
        }
        Console.WriteLine(pozitive);
    }
}
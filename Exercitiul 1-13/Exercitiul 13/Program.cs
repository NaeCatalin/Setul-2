//O <secventa crescatoare rotita> este o secventa de numere care este in
//ordine crescatoare sau poate fi transformata intr-o secventa in ordine
//crescatoare prin rotiri succesive (rotire cu o pozitie spre
//stanga = toate elementele se muta cu o pozitie spre stanga si primul
//element devine ultimul). Determinati daca o secventa de n numere este o
//secventa crescatoare rotita. 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("n =");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Primul numar:");
        int firstNumber = int.Parse(Console.ReadLine());
        int previousNumber = firstNumber;

        int dropCount = 0;  
        int lastNumber = firstNumber;

        for (int i = 2; i<=n;i++)
        {
            Console.WriteLine("Numarul" + i + ":");
            int x = int.Parse(Console.ReadLine());

            if (x < previousNumber) 
            dropCount++;

            previousNumber = x;
            lastNumber = x;

        }
        bool esteCrescatoareRotita= false;
        if (dropCount == 0)
        {
            esteCrescatoareRotita = true; 
        }
        else if (dropCount == 1 && lastNumber <= firstNumber)
        {
            esteCrescatoareRotita = true;
        }
        if (esteCrescatoareRotita)
        {
            Console.WriteLine("Secventa este crescatoare rotita.");
        }
        else
        {
            Console.WriteLine("Secventa nu este crescatoare rotita.");
        }
            {
            
        }
    }
}
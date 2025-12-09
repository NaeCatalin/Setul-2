//O<secventa monotona rotita> este o secventa de numere monotona sau poate fi
//transformata intr-o secventa montona prin rotiri succesive.
//Determinati daca o secventa de n numere este o secventa monotona rotita. 

using System;

class Program
{
    static void Main()
    { 
    Console.WriteLine("n=");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("primul numar:");
        int firstNumber = int.Parse(Console.ReadLine());
        int previousNumber = firstNumber;
        int lastNumber = firstNumber;

        int dropCount = 0;
        int riseCount = 0;

        for (int i = 2; i < n; i++)
        {
            Console.WriteLine("Numarul" + i + ":");
            int x = int.Parse(Console.ReadLine());

            if (x< previousNumber)
            {
                dropCount++;
            }
            else if (x > previousNumber)
            {
                riseCount++;
            }
            previousNumber = x;
            lastNumber = x;

        }
        bool crescatorRotit = false;
        bool descrescatorRotit = false;

        if (riseCount == 0 || dropCount == 1)
        {
            crescatorRotit = true;
            descrescatorRotit = true;
        }
        else if (riseCount == 1 && lastNumber <= firstNumber)
        {
            crescatorRotit = true;
        }
        else if (dropCount == 1 && lastNumber >= firstNumber)
        {
            descrescatorRotit = true;
        }
        if (crescatorRotit || descrescatorRotit) 
            Console.WriteLine("Secventa este monotona rotita");
        else
            Console.WriteLine("Secventa nu este monotona rotita");
    }
}
    //O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi
    //transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul
    //element devine ultimul).
    //Se da o secventa de n numere. Se cere sa se determine daca este o secventa
    //bitonica rotita.
    


using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Console.WriteLine("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Primul numar = ");
        int firstNumber = int.Parse(Console.ReadLine());
        int previousNumber = firstNumber;

        int schimbari = 0;
        int directii = 0; // 0 = necunoscut, 1 = crescator, -1 = descrescator

        for (int i = 2; i < n; i++)
        {
            Console.WriteLine("Numarul" + i + ":");
            int x = int.Parse(Console.ReadLine());

            if (x > previousNumber)
            {
                if (directii == -1)
                {
                    schimbari++;
                    directii = 1;
                }
                else if (directii == 0)
                {
                    directii = 1;
                }

            }

            else if (x < previousNumber)
            {
                if (directii == 1)
                {
                    schimbari++;
                    directii = -1;
                }
                else if (directii == 0)
                {
                    directii = -1;
                }
                previousNumber = x;
            }
            if (firstNumber == previousNumber)
            {
                if (directii == 1) { schimbari++; }

            }
            else if (firstNumber == previousNumber)
                {
                if (directii == 1) schimbari++;
                }
            if (schimbari == 2)
            
                Console.WriteLine("Secventa este bitonica rotita");
            else
                Console.WriteLine("Secventa nu este bitonica rotita");

        }
    }
}


// Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.
// Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.
// De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("n =");
        int n = int.Parse(Console.ReadLine());

        int grupuri = 0;
        bool inGrup = false;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Elementul {i + 1} =");
            int element = int.Parse(Console.ReadLine());
            if (element != 0)
            {
                if (!inGrup)
                {
                    grupuri++;
                    inGrup = true;
                }
            }
            else
            {
                inGrup = false;
            }
        }
        Console.WriteLine("Numarul de grupuri de numere consecutive diferite de zero este: " + grupuri);
    }
}
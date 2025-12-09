//Cate elemente dintr-o secventa de n numere sunt egale
//cu pozitia pe care apar in secventa.
//Se considera ca primul element din secventa este pe pozitia 0. 

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x == i)
                count++;

        }
        Console.WriteLine(count);
        {
        }
    }
}
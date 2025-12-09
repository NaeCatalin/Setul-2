using System;

class Program
{
    static void Main ()
    {
        int n =int.Parse(Console.ReadLine());

        int x = int .Parse(Console.ReadLine());  //citim primul nr
        int minim = x;
        int maxim = x;

        for (int i = 1; i<n; i++)
        {
            x = int.Parse(Console.ReadLine());

            if (x < minim)
                minim = x;
            if (x > maxim)
                maxim = x;
        }
        Console.WriteLine("Minimul este: " + minim);
        Console.WriteLine("Maximul este: " + maxim);
    }
}
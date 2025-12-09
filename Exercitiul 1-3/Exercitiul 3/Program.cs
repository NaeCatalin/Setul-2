//Calculati suma si produsul numerelor de la 1 la n. 
using System;

class Program
{
    static void Main ()
    {
        int n = int.Parse(Console.ReadLine());
        long suma = 0;
        long produs = 1;

        for (int i = 1; i <= n; i++)
        {
            suma += i;        //adunam nr
                produs *= i;    //inmultim nr
        }
        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Produs: " + produs);
    }
}
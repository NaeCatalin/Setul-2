//Determianti al n-lea numar din sirul lui Fibonacci.
//Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2).
//Exemplu: 0, 1, 1, 2, 3, 5, 8 ...

using System;

class Program
{
    static void Main ()
    {

        int n; 
        Console.WriteLine ("n = ");
        n=int.Parse (Console.ReadLine ());

        if (n == 1)
        {
            Console.WriteLine("Fibonacci = 0");
        }
        else if (n == 2) 
        {
            Console.WriteLine("Fibonacci = 1");
        }
        else
        {
             long a = 0;
            long b = 1;
            long c = 0;
            for (int i = 3; i <= n; i++)
            {
                c = a + b; // f(n) = f(n-1) + f(n-2)
                a = b;
                b = c;
            }
            Console.WriteLine ("Fibonacci = " + b);

        }

    }
}
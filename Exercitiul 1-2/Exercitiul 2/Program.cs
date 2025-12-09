//Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 

using System;

class Program
{
    static void Main()
    {
        int n = int .Parse(Console.ReadLine());
        int neg = 0 , zero = 0 , poz = 0;
        for 
            
           (int i = 0;  i <n; i++ )
        {
            int x = int .Parse(Console.ReadLine());
            if (x< 0) neg++;
            else if (x == 0) zero++;
            else poz++;
        }
        Console.WriteLine(neg + " " + zero + " " + poz);
    }
}
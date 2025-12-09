using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int countEven = 0;
        for (int i = 0; i< n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                countEven++;
         
           }
            Console.WriteLine(countEven);
        }

    }
}
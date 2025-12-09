//Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1
//inseamna paranteza inchisa.
//Determinati daca secventa reprezinta o secventa de paranteze corecta si,
//daca este, determinati nivelul maxim de incuibare a parantezelor.
//De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe
//cand 0 0 1 1 1 0 este incorecta.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("n=");
        int n = int.Parse(Console.ReadLine());

        int nivelCurent = 0;
        int nivelMaxim = 0;
        bool esteCorecta = true;

        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine("Elementul " + i + " (0=deschis , 1=inchis):");
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                nivelCurent++;
                if (nivelCurent > nivelMaxim)
                {
                    nivelMaxim = nivelCurent;
                }

            }
            else if (x == 1)
            {
                nivelCurent--;
                if (nivelCurent < 0)
                {
                    esteCorecta = false;
                    break;
                }
            }
            else
            {
                   Console.WriteLine("Element invalid!");
                esteCorecta = false;
                break;
            }
        }
        if (nivelCurent !=0)  
        esteCorecta |= false;

        if (esteCorecta)
        {
            Console.WriteLine("Secventa este corecta.");
            Console.WriteLine("Nivelul maxim de incuibare este: " + nivelMaxim);
        }
        else
        {
            Console.WriteLine("Secventa nu este corecta.");
        }


    }
}

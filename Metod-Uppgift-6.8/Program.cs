using System;

namespace Uppgift_6_8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Skriv in ett heltal för att få reda på vilka tal mindre än det angivna talet är ett primtal");
            Console.WriteLine(MindrePrim(int.Parse(Console.ReadLine())));
        }

        static int MindrePrim(int tal)
        {
            int resultat = 0; 

            for (int i = 2; i < tal; i++)
            {
                if (Prim(i)) resultat++;
            }

            return resultat;
        }

        static bool Prim(int tal)
        {
            for (int i = 2; i < tal - 1; i++)
            {
                if (tal % i == 0) return false;
            }

            return true;
        }
    }
}







using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Som
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIONS
            int getal1, getal2, som;

            byte kleinGetal1 = (byte)5;

            byte kleinGetal2 = 10, kleineSom;

            kleineSom = (byte)(int)kleinGetal1 + (int)kleinGetal2);

            //INPUT
            // VRAAG getal1
            Console.Write("Geef het eerste getal");
            getal1 = int.Parse( Console.ReadLine());

            // VRAAG getal2
            Console.WriteLine("Geef het tweede getal");
            getal2 = int.Parse( Console.ReadLine());

            //POCESSING
            // BEREKEN som (getal1 + getal2)
            som = getal1 + getal2;

            //OUTPUT
            // TOON  som
            Console.WriteLine($"{getal1} + {getal2} = {som}");

            //WACHTEN
            Console.WriteLine();
            Console.Write("Druk op Enter af te sluiten...");
        }
    }
}

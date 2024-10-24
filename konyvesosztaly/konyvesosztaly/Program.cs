using System;

namespace konyvesosztaly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Add meg hogy hány konyvet szeretnél megadni: ");
            n = Convert.ToInt32(Console.ReadLine());

            Konyv[] konyvek = new Konyv[n];

            for (int i = 0; i < konyvek.Length; i++)
            {
                Console.WriteLine($"Add meg az {i+1}. konyv cimet:");
                string cim = Console.ReadLine();

                Console.WriteLine($"Add meg az {i + 1}. konyv szerzojet:");
                string szerzo = Console.ReadLine();

                Console.WriteLine($"Add meg az {i + 1}. konyv oldalszamat:");
                int oldalszam =Convert.ToInt32( Console.ReadLine());

                Console.WriteLine($"Add meg az {i + 1}. konyv arat vagy hagyd uresen:");
                string belvasAr = Console.ReadLine();
                if (string.IsNullOrEmpty(belvasAr))
                {
                    konyvek[i] = new Konyv(cim, szerzo, oldalszam);
                }
                else 
                {
                    double ar = Convert.ToDouble(belvasAr);
                    konyvek[i]= new Konyv(cim, szerzo, oldalszam,ar);
                }


            }


            Console.WriteLine("Adatok kiirása:");

            foreach (var konyv in konyvek)
            {
                Console.WriteLine(konyv.ToString());
                Console.WriteLine($"ez a konyv draga:{konyv.dragae()}");
                Console.WriteLine($"ez a konyv vastag:{konyv.vastage()}");

            }





        }
    }
}

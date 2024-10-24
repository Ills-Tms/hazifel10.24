using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvesosztaly
{
    class Konyv
    {
        private string Cim { get; set; }
        private string Szerzo { get; set; }
        private int Oldalszam { get; set; }
        private double Ar { get; set; }


        public Konyv(string cim, string szerzo, int oldalszam, double ar)
        {
            Cim = cim;
            Szerzo = szerzo;
            Oldalszam = oldalszam;
            Ar = ar;
        }

        public Konyv(string cim, string szerzo, int oldalszam)
        {
            Cim = cim;
            Szerzo = szerzo;
            Oldalszam = oldalszam;
            Ar = 3000;
        }

        public override string ToString()
        {
            return $"A könyv címe: {Cim},szerző: {Szerzo},oldalak száma: {Oldalszam},Ára: {Ar} ";
        }

        public bool vastage()
        {
            if (Oldalszam > 500)
            {
                return true;
            }
            else { return false; }
        }

        public bool dragae()
        {
            if (Ar > 5000)
            {
                return true;
            }
            else { return false; }
        }




    }
}

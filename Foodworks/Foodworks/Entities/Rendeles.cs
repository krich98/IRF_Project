using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodworks.Entities
{
    
    class Rendeles
    {
        public static List<Tetel> tetelek = new List<Tetel>();
        private int _szallitasiKoltseg = 0;
        public Rendeles()
        {
            
        }
        public int SzallitasiKoltseg
        {
            get { return _szallitasiKoltseg; }
            set
            {
                //var osszeadas = (from a in tetelek
                //                 select new { Osszeg = a.Mennyiseg * a.Ar }).ToList();
                //var vegosszeg = (from x in osszeadas select x.Osszeg).Sum();

                _szallitasiKoltseg = 0;
            }
        }

    }
}

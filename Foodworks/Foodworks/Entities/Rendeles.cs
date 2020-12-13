using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodworks.Entities
{
    
    class Rendeles
    {
        public List<Tetel> tetelek = new List<Tetel>();
        private int _szallitasiKoltseg;
        public Rendeles()
        {

        }
        public int SzallitasiKoltseg 
        {
            get { return _szallitasiKoltseg; } 
            set 
            {
                var asd = from a in tetelek
                          select new { Nev = a.Nev , Osszeg = a.Mennyiseg * a.Ar };
                var osszeg1 = from b in asd
                              group b by b.Nev into c
                              select new { Vegosszeg = c.Sum(d => d.Osszeg) };
                              
                var osszeg = from x in tetelek
                             group x by x.Nev into y
                             select new { Nev = y.Key, Osszesen = y.Sum(z => z.Ar * z.Mennyiseg) };
                
            } 
        }

    }
}

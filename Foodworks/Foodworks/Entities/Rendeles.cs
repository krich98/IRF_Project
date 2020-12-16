using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodworks.Entities
{
    
    class Rendeles
    {
        public static List<Tetel> tetelek = new List<Tetel>();
        private int _szallitasiKoltseg;
        private int vegosszeg;
        public Rendeles()
        {
            OsszegSzamolas();
            SzallitasiKoltseg = vegosszeg;
            Osszeg = vegosszeg;
            
        }
        public int SzallitasiKoltseg
        {
            get { return _szallitasiKoltseg; }
            set
            {
                _szallitasiKoltseg = value;
                if (value < 5000)
                    _szallitasiKoltseg = value / 5;
                else if (value > 5000 && value < 10000)
                    _szallitasiKoltseg = value / 10;
                else if (value >= 10000 && value < 15000)
                    _szallitasiKoltseg = value / 20;
                else
                    _szallitasiKoltseg = 0;
                 

            }
        }
        public int Osszeg { get { return vegosszeg; } set { vegosszeg = value; } }
        private void OsszegSzamolas()
        {
            try
            {
                var osszeadas = (from a in tetelek
                                 select new { Osszeg = a.Mennyiseg * a.Ar }).ToList();
                vegosszeg = (from x in osszeadas select x.Osszeg).Sum();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

    }
}

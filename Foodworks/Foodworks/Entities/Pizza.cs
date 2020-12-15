using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodworks.Entities
{
    class Pizza
    {
        private int _sorszam;
        public int Sorszam
        {
            get { return _sorszam; }
            set
            {
                _sorszam = value;
                if (_sorszam < 0)               
                    _sorszam = 0;
                 
            }
        }
        public string Nev { get; set; }
        public int Ar { get; set; }
        public string Leiras { get; set; }
    }
}

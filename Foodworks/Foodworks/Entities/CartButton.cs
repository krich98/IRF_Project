using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Foodworks.Entities;

namespace Foodworks.Entities
{
    class CartButton : Button
    {
        List<Pizza> pizzak = new List<Pizza>();
        
        public int ID { get; set; }
        public CartButton()
        {
            MouseClick += CartButton_MouseClick;
        }

        private void CartButton_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        
    }
}

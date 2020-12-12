using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Foodworks.Entities
{
    class CustomButton : Button
    {
        public CustomButton(Color color)
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Font = new Font("Microsoft Sans Serif", 25);
            BackColor = color;
            ForeColor = Color.White;
        }
        public CustomButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Font = new Font("Microsoft Sans Serif", 25);
            ForeColor = Color.White;
        }
        
    }
}

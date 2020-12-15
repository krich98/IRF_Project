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
        public int ID { get; set; }
        public CustomButton(Color color)
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = color;
            ForeColor = Color.White;
        }
        public CustomButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            ForeColor = Color.White;
        }
        
        
    }
}

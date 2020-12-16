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
        private int _id;
        
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
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                if(_id < 0 )
                {
                    _id = 0;
                }
                
            }
        }


    }
}

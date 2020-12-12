using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodworks.UserControls
{
    public partial class UcHome : UserControl
    {
        public int meret;
        public UcHome()
        {
            InitializeComponent();
            UIRajzolas();
        }
        void UIRajzolas()
        {
            int kepmeret = 100;
            meret = 0;
            for (int i = 0; i < 6; i++)
            {
                meret += kepmeret + 20;
                string picturePath = "Files/" + (i + 1).ToString() + ".png";
                PictureBox pbPizza = new PictureBox();
                pbPizza.Left = i*kepmeret;
                pbPizza.Width = kepmeret;
                pbPizza.Height = kepmeret;
                pbPizza.Top = 200;
                pbPizza.BackgroundImage = Image.FromFile(picturePath);
                pbPizza.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pbPizza);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Foodworks.Entities;
using Foodworks.UserControls;

namespace Foodworks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel3.Top = 51;
            UcHomeBetolt();
            LogokBetolt();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            UcHomeBetolt();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            UcPizzaBetolt();
        }

        private void AboutUsBtn_Click(object sender, EventArgs e)
        {
            UcAboutUsBetolt();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            UcCartBetolt();
        }
        private void UcHomeBetolt()
        {
            UcHome ucHome = new UcHome();
            panel3.Controls.Clear();
            panel3.Size = ucHome.Size;
            panel3.Left = (this.Width - ucHome.Width) / 2;
            panel3.Controls.Add(ucHome);
            ucHome.Dock = DockStyle.Fill;
        }
        private void UcPizzaBetolt()
        {
            UcPizza ucPizza = new UcPizza();
            panel3.Controls.Clear();
            panel3.Left = this.Width / 4;
            panel3.Size = ucPizza.Size;
            panel3.Controls.Add(ucPizza);
            ucPizza.Dock = DockStyle.Fill;
        }
        private void UcAboutUsBetolt()
        {
            UcAboutUs ucAbout = new UcAboutUs();
            panel3.Controls.Clear();
            panel3.Size = ucAbout.Size;
            panel3.Left = (this.Width - ucAbout.Width) / 2;
            panel3.Controls.Add(ucAbout);
            ucAbout.Dock = DockStyle.Fill;
        }
        private void UcCartBetolt()
        {
            UcCart ucCart = new UcCart();
            panel3.Controls.Clear();
            panel3.Left = this.Width / 4 + 25;
            panel3.Height = ucCart.Height;
            panel3.Width = ucCart.Width;
            panel3.Controls.Add(ucCart);
            ucCart.Dock = DockStyle.Fill;
        }
        private void LogokBetolt()
        {
            PictureBox logo = new PictureBox();
            logo.Left = -40;
            logo.Top = 15;
            logo.BackgroundImage = Image.FromFile("Files/logo_transparent.png");
            logo.Width = 200;
            logo.Height = 200;
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            this.Controls.Add(logo);

            PictureBox logo2 = new PictureBox();
            logo2.Left = this.Width - 201;
            logo2.Top = 15;
            logo2.BackgroundImage = Image.FromFile("Files/logo_transparent.png");
            logo2.Width = 200;
            logo2.Height = 200;
            logo2.BackgroundImageLayout = ImageLayout.Stretch;
            this.Controls.Add(logo2);
        }
    }
}


namespace Foodworks
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customButton1 = new Foodworks.Entities.CustomButton();
            this.AboutUsBtn = new Foodworks.Entities.CustomButton();
            this.HomeBtn = new Foodworks.Entities.CustomButton();
            this.MenuBtn = new Foodworks.Entities.CustomButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Controls.Add(this.AboutUsBtn);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.MenuBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 41);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Location = new System.Drawing.Point(147, 75);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 380);
            this.panel3.TabIndex = 1;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.ID = 0;
            this.customButton1.Location = new System.Drawing.Point(945, 0);
            this.customButton1.Margin = new System.Windows.Forms.Padding(2);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(65, 40);
            this.customButton1.TabIndex = 4;
            this.customButton1.Text = "Cart";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // AboutUsBtn
            // 
            this.AboutUsBtn.AutoSize = true;
            this.AboutUsBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AboutUsBtn.FlatAppearance.BorderSize = 0;
            this.AboutUsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutUsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.AboutUsBtn.ForeColor = System.Drawing.Color.White;
            this.AboutUsBtn.ID = 0;
            this.AboutUsBtn.Location = new System.Drawing.Point(673, 0);
            this.AboutUsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AboutUsBtn.Name = "AboutUsBtn";
            this.AboutUsBtn.Size = new System.Drawing.Size(338, 49);
            this.AboutUsBtn.TabIndex = 3;
            this.AboutUsBtn.Text = "About Us";
            this.AboutUsBtn.UseVisualStyleBackColor = false;
            this.AboutUsBtn.Click += new System.EventHandler(this.AboutUsBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.ID = 0;
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(338, 41);
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.AutoSize = true;
            this.MenuBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.MenuBtn.FlatAppearance.BorderSize = 0;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.MenuBtn.ForeColor = System.Drawing.Color.White;
            this.MenuBtn.ID = 0;
            this.MenuBtn.Location = new System.Drawing.Point(338, 0);
            this.MenuBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(338, 49);
            this.MenuBtn.TabIndex = 2;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1012, 505);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "KRICH\'S FOODWORKS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Entities.CustomButton AboutUsBtn;
        private Entities.CustomButton MenuBtn;
        private Entities.CustomButton HomeBtn;
        private System.Windows.Forms.Panel panel3;
        private Entities.CustomButton customButton1;
    }
}


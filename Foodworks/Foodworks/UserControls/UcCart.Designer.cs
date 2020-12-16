
namespace Foodworks.UserControls
{
    partial class UcCart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelOsszeg = new System.Windows.Forms.Label();
            this.labelOsszesen = new System.Windows.Forms.Label();
            this.labelSzallDij = new System.Windows.Forms.Label();
            this.labelSzallDijSzam = new System.Windows.Forms.Label();
            this.labelKosar = new System.Windows.Forms.Label();
            this.labelNev = new System.Windows.Forms.Label();
            this.labelCim = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.textBoxCim = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.customButton2 = new Foodworks.Entities.CustomButton();
            this.customButton1 = new Foodworks.Entities.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.customButton3 = new Foodworks.Entities.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(23, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(446, 82);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelOsszeg
            // 
            this.labelOsszeg.AutoSize = true;
            this.labelOsszeg.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOsszeg.Location = new System.Drawing.Point(369, 247);
            this.labelOsszeg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOsszeg.Name = "labelOsszeg";
            this.labelOsszeg.Size = new System.Drawing.Size(19, 20);
            this.labelOsszeg.TabIndex = 1;
            this.labelOsszeg.Text = "0";
            // 
            // labelOsszesen
            // 
            this.labelOsszesen.AutoSize = true;
            this.labelOsszesen.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOsszesen.Location = new System.Drawing.Point(276, 247);
            this.labelOsszesen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOsszesen.Name = "labelOsszesen";
            this.labelOsszesen.Size = new System.Drawing.Size(89, 20);
            this.labelOsszesen.TabIndex = 2;
            this.labelOsszesen.Text = "Összesen:";
            // 
            // labelSzallDij
            // 
            this.labelSzallDij.AutoSize = true;
            this.labelSzallDij.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSzallDij.Location = new System.Drawing.Point(199, 230);
            this.labelSzallDij.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSzallDij.Name = "labelSzallDij";
            this.labelSzallDij.Size = new System.Drawing.Size(166, 20);
            this.labelSzallDij.TabIndex = 3;
            this.labelSzallDij.Text = "Szállítási díj(xx%):";
            // 
            // labelSzallDijSzam
            // 
            this.labelSzallDijSzam.AutoSize = true;
            this.labelSzallDijSzam.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSzallDijSzam.Location = new System.Drawing.Point(369, 227);
            this.labelSzallDijSzam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSzallDijSzam.Name = "labelSzallDijSzam";
            this.labelSzallDijSzam.Size = new System.Drawing.Size(60, 20);
            this.labelSzallDijSzam.TabIndex = 4;
            this.labelSzallDijSzam.Text = "label2";
            // 
            // labelKosar
            // 
            this.labelKosar.AutoSize = true;
            this.labelKosar.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKosar.Location = new System.Drawing.Point(136, 0);
            this.labelKosar.Name = "labelKosar";
            this.labelKosar.Size = new System.Drawing.Size(202, 41);
            this.labelKosar.TabIndex = 7;
            this.labelKosar.Text = "A kosarad:";
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNev.Location = new System.Drawing.Point(94, 145);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(43, 20);
            this.labelNev.TabIndex = 9;
            this.labelNev.Text = "Név:";
            // 
            // labelCim
            // 
            this.labelCim.AutoSize = true;
            this.labelCim.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCim.Location = new System.Drawing.Point(93, 171);
            this.labelCim.Name = "labelCim";
            this.labelCim.Size = new System.Drawing.Size(44, 20);
            this.labelCim.TabIndex = 10;
            this.labelCim.Text = "Cím:";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTel.Location = new System.Drawing.Point(31, 195);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(106, 20);
            this.labelTel.TabIndex = 11;
            this.labelTel.Text = "Telefonszám:";
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(143, 145);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(249, 20);
            this.textBoxNev.TabIndex = 12;
            // 
            // textBoxCim
            // 
            this.textBoxCim.Location = new System.Drawing.Point(143, 171);
            this.textBoxCim.Name = "textBoxCim";
            this.textBoxCim.Size = new System.Drawing.Size(249, 20);
            this.textBoxCim.TabIndex = 13;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(143, 197);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(249, 20);
            this.textBoxTel.TabIndex = 14;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.DarkRed;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.ID = 0;
            this.customButton2.Location = new System.Drawing.Point(25, 295);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(141, 53);
            this.customButton2.TabIndex = 8;
            this.customButton2.Text = "Kosár ürítése\r\n";
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.DarkRed;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.ID = 0;
            this.customButton1.Location = new System.Drawing.Point(25, 230);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(141, 53);
            this.customButton1.TabIndex = 6;
            this.customButton1.Text = "Rendelés";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 104);
            this.label1.TabIndex = 15;
            this.label1.Text = "Szállítási díj:\r\nha a tételek összege, \r\nkisebb, mint 5000 Ft -> 20%\r\n5001 Ft és " +
    "10000 Ft között -> 10%\r\n10001 Ft és 15000 Ft -> 5%\r\n15000 Ft felett -> 0%\r\n(elre" +
    "jtésért kattints a segítség gombra)\r\n\r\n";
            this.label1.Visible = false;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.ID = 0;
            this.customButton3.Location = new System.Drawing.Point(172, 231);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(22, 20);
            this.customButton3.TabIndex = 16;
            this.customButton3.Text = "?";
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // UcCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxCim);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelCim);
            this.Controls.Add(this.labelNev);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.labelKosar);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.labelSzallDijSzam);
            this.Controls.Add(this.labelSzallDij);
            this.Controls.Add(this.labelOsszesen);
            this.Controls.Add(this.labelOsszeg);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcCart";
            this.Size = new System.Drawing.Size(488, 385);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelOsszeg;
        private System.Windows.Forms.Label labelOsszesen;
        private System.Windows.Forms.Label labelSzallDij;
        private System.Windows.Forms.Label labelSzallDijSzam;
        private Entities.CustomButton customButton1;
        private System.Windows.Forms.Label labelKosar;
        private Entities.CustomButton customButton2;
        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.Label labelCim;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.TextBox textBoxCim;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label label1;
        private Entities.CustomButton customButton3;
    }
}

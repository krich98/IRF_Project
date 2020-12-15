
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(594, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelOsszeg
            // 
            this.labelOsszeg.AutoSize = true;
            this.labelOsszeg.Location = new System.Drawing.Point(591, 242);
            this.labelOsszeg.Name = "labelOsszeg";
            this.labelOsszeg.Size = new System.Drawing.Size(16, 17);
            this.labelOsszeg.TabIndex = 1;
            this.labelOsszeg.Text = "0";
            // 
            // labelOsszesen
            // 
            this.labelOsszesen.AutoSize = true;
            this.labelOsszesen.Location = new System.Drawing.Point(447, 242);
            this.labelOsszesen.Name = "labelOsszesen";
            this.labelOsszesen.Size = new System.Drawing.Size(101, 17);
            this.labelOsszesen.TabIndex = 2;
            this.labelOsszesen.Text = "labelOsszesen";
            // 
            // labelSzallDij
            // 
            this.labelSzallDij.AutoSize = true;
            this.labelSzallDij.Location = new System.Drawing.Point(447, 225);
            this.labelSzallDij.Name = "labelSzallDij";
            this.labelSzallDij.Size = new System.Drawing.Size(46, 17);
            this.labelSzallDij.TabIndex = 3;
            this.labelSzallDij.Text = "label1";
            // 
            // labelSzallDijSzam
            // 
            this.labelSzallDijSzam.AutoSize = true;
            this.labelSzallDijSzam.Location = new System.Drawing.Point(561, 225);
            this.labelSzallDijSzam.Name = "labelSzallDijSzam";
            this.labelSzallDijSzam.Size = new System.Drawing.Size(46, 17);
            this.labelSzallDijSzam.TabIndex = 4;
            this.labelSzallDijSzam.Text = "label2";
            // 
            // UcCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSzallDijSzam);
            this.Controls.Add(this.labelSzallDij);
            this.Controls.Add(this.labelOsszesen);
            this.Controls.Add(this.labelOsszeg);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UcCart";
            this.Size = new System.Drawing.Size(650, 364);
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
    }
}

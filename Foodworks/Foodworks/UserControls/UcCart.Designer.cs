
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
            this.customButton1 = new Foodworks.Entities.CustomButton();
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
            this.dataGridView1.Location = new System.Drawing.Point(23, 87);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.labelOsszeg.Location = new System.Drawing.Point(359, 210);
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
            this.labelOsszesen.Location = new System.Drawing.Point(239, 210);
            this.labelOsszesen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOsszesen.Name = "labelOsszesen";
            this.labelOsszesen.Size = new System.Drawing.Size(125, 20);
            this.labelOsszesen.TabIndex = 2;
            this.labelOsszesen.Text = "labelOsszesen";
            // 
            // labelSzallDij
            // 
            this.labelSzallDij.AutoSize = true;
            this.labelSzallDij.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSzallDij.Location = new System.Drawing.Point(239, 194);
            this.labelSzallDij.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSzallDij.Name = "labelSzallDij";
            this.labelSzallDij.Size = new System.Drawing.Size(60, 20);
            this.labelSzallDij.TabIndex = 3;
            this.labelSzallDij.Text = "label1";
            // 
            // labelSzallDijSzam
            // 
            this.labelSzallDijSzam.AutoSize = true;
            this.labelSzallDijSzam.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSzallDijSzam.Location = new System.Drawing.Point(359, 194);
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
            this.labelKosar.Location = new System.Drawing.Point(129, 0);
            this.labelKosar.Name = "labelKosar";
            this.labelKosar.Size = new System.Drawing.Size(202, 41);
            this.labelKosar.TabIndex = 7;
            this.labelKosar.Text = "A kosarad:";
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.DarkRed;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.ID = 0;
            this.customButton1.Location = new System.Drawing.Point(23, 194);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(141, 53);
            this.customButton1.TabIndex = 6;
            this.customButton1.Text = "Nyugta megtekintése";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // UcCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelKosar);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.labelSzallDijSzam);
            this.Controls.Add(this.labelSzallDij);
            this.Controls.Add(this.labelOsszesen);
            this.Controls.Add(this.labelOsszeg);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UcCart";
            this.Size = new System.Drawing.Size(488, 296);
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
    }
}

namespace chuong4_2
{
    partial class frmC4_Vd4_6
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
            this.cboLopdanhnghia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLopHP = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboLopdanhnghia
            // 
            this.cboLopdanhnghia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLopdanhnghia.FormattingEnabled = true;
            this.cboLopdanhnghia.Location = new System.Drawing.Point(363, 102);
            this.cboLopdanhnghia.Name = "cboLopdanhnghia";
            this.cboLopdanhnghia.Size = new System.Drawing.Size(312, 30);
            this.cboLopdanhnghia.TabIndex = 0;
            this.cboLopdanhnghia.SelectedIndexChanged += new System.EventHandler(this.cboLopdanhnghia_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lop danh nghia";
            // 
            // lstLopHP
            // 
            this.lstLopHP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLopHP.FormattingEnabled = true;
            this.lstLopHP.ItemHeight = 22;
            this.lstLopHP.Location = new System.Drawing.Point(140, 192);
            this.lstLopHP.Name = "lstLopHP";
            this.lstLopHP.Size = new System.Drawing.Size(535, 158);
            this.lstLopHP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sach mo lop thanh phan";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(314, 381);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 47);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "DANH SACH MO LOP HOC PHAN";
            // 
            // frmC4_Vd4_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstLopHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLopdanhnghia);
            this.Name = "frmC4_Vd4_6";
            this.Text = "frmC4_Vd4_6";
            this.Load += new System.EventHandler(this.frmC4_Vd4_6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLopdanhnghia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLopHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
    }
}


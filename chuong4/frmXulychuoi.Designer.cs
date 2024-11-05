namespace chuong4
{
    partial class frmXulychuoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChuoi1 = new System.Windows.Forms.TextBox();
            this.txtChuoi2 = new System.Windows.Forms.TextBox();
            this.txtChuoi3 = new System.Windows.Forms.TextBox();
            this.rdoNoichuoi = new System.Windows.Forms.RadioButton();
            this.rdoChenchuoi = new System.Windows.Forms.RadioButton();
            this.txtVitri = new System.Windows.Forms.TextBox();
            this.btnThuchien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "XU LY CHUOI KY TU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chuoi 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chuoi 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chuoi 3";
            // 
            // txtChuoi1
            // 
            this.txtChuoi1.Location = new System.Drawing.Point(287, 117);
            this.txtChuoi1.Name = "txtChuoi1";
            this.txtChuoi1.Size = new System.Drawing.Size(230, 22);
            this.txtChuoi1.TabIndex = 0;
            // 
            // txtChuoi2
            // 
            this.txtChuoi2.Location = new System.Drawing.Point(287, 177);
            this.txtChuoi2.Name = "txtChuoi2";
            this.txtChuoi2.Size = new System.Drawing.Size(230, 22);
            this.txtChuoi2.TabIndex = 1;
            // 
            // txtChuoi3
            // 
            this.txtChuoi3.Location = new System.Drawing.Point(287, 234);
            this.txtChuoi3.Name = "txtChuoi3";
            this.txtChuoi3.Size = new System.Drawing.Size(230, 22);
            this.txtChuoi3.TabIndex = 2;
            // 
            // rdoNoichuoi
            // 
            this.rdoNoichuoi.AutoSize = true;
            this.rdoNoichuoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNoichuoi.Location = new System.Drawing.Point(287, 282);
            this.rdoNoichuoi.Name = "rdoNoichuoi";
            this.rdoNoichuoi.Size = new System.Drawing.Size(211, 26);
            this.rdoNoichuoi.TabIndex = 3;
            this.rdoNoichuoi.TabStop = true;
            this.rdoNoichuoi.Text = "Noi chuoi 1 va chuoi 2";
            this.rdoNoichuoi.UseVisualStyleBackColor = true;
            this.rdoNoichuoi.CheckedChanged += new System.EventHandler(this.rdoNoichuoi_CheckedChanged);
            // 
            // rdoChenchuoi
            // 
            this.rdoChenchuoi.AutoSize = true;
            this.rdoChenchuoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChenchuoi.Location = new System.Drawing.Point(287, 327);
            this.rdoChenchuoi.Name = "rdoChenchuoi";
            this.rdoChenchuoi.Size = new System.Drawing.Size(212, 26);
            this.rdoChenchuoi.TabIndex = 4;
            this.rdoChenchuoi.TabStop = true;
            this.rdoChenchuoi.Text = "Chen chuoi 3 vao vi tri";
            this.rdoChenchuoi.UseVisualStyleBackColor = true;
            this.rdoChenchuoi.CheckedChanged += new System.EventHandler(this.rdoChenchuoi_CheckedChanged);
            // 
            // txtVitri
            // 
            this.txtVitri.Location = new System.Drawing.Point(531, 327);
            this.txtVitri.Name = "txtVitri";
            this.txtVitri.Size = new System.Drawing.Size(133, 22);
            this.txtVitri.TabIndex = 5;
            // 
            // btnThuchien
            // 
            this.btnThuchien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuchien.Location = new System.Drawing.Point(287, 407);
            this.btnThuchien.Name = "btnThuchien";
            this.btnThuchien.Size = new System.Drawing.Size(133, 31);
            this.btnThuchien.TabIndex = 8;
            this.btnThuchien.Text = "Thuc hien";
            this.btnThuchien.UseVisualStyleBackColor = true;
            this.btnThuchien.Click += new System.EventHandler(this.btnThuchien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(454, 406);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 32);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ket qua";
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoSize = true;
            this.lblKetqua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetqua.Location = new System.Drawing.Point(287, 369);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(60, 22);
            this.lblKetqua.TabIndex = 11;
            this.lblKetqua.Text = "label6";
            // 
            // frmXulychuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThuchien);
            this.Controls.Add(this.txtVitri);
            this.Controls.Add(this.rdoChenchuoi);
            this.Controls.Add(this.rdoNoichuoi);
            this.Controls.Add(this.txtChuoi3);
            this.Controls.Add(this.txtChuoi2);
            this.Controls.Add(this.txtChuoi1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmXulychuoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xu ly chuoi ky tu";
            this.Load += new System.EventHandler(this.frmXulychuoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChuoi1;
        private System.Windows.Forms.TextBox txtChuoi2;
        private System.Windows.Forms.TextBox txtChuoi3;
        private System.Windows.Forms.RadioButton rdoNoichuoi;
        private System.Windows.Forms.RadioButton rdoChenchuoi;
        private System.Windows.Forms.TextBox txtVitri;
        private System.Windows.Forms.Button btnThuchien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKetqua;
    }
}


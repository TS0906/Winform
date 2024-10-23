namespace chuong2
{
    partial class frmPractice_c2_1
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
            this.btnDoitieude = new System.Windows.Forms.Button();
            this.btnThemForm = new System.Windows.Forms.Button();
            this.btnGoiFormKhac = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THIẾT LẬP CÁC THUỘC TÍNH CỦA FORM";
            // 
            // btnDoitieude
            // 
            this.btnDoitieude.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoitieude.Location = new System.Drawing.Point(67, 173);
            this.btnDoitieude.Name = "btnDoitieude";
            this.btnDoitieude.Size = new System.Drawing.Size(271, 100);
            this.btnDoitieude.TabIndex = 1;
            this.btnDoitieude.Text = "Đổi tiêu đề Form";
            this.btnDoitieude.UseVisualStyleBackColor = true;
            this.btnDoitieude.Click += new System.EventHandler(this.btnDoitieude_Click);
            // 
            // btnThemForm
            // 
            this.btnThemForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemForm.Location = new System.Drawing.Point(451, 172);
            this.btnThemForm.Name = "btnThemForm";
            this.btnThemForm.Size = new System.Drawing.Size(271, 100);
            this.btnThemForm.TabIndex = 2;
            this.btnThemForm.Text = "Tạo Form mới";
            this.btnThemForm.UseVisualStyleBackColor = true;
            this.btnThemForm.Click += new System.EventHandler(this.btnThemForm_Click);
            // 
            // btnGoiFormKhac
            // 
            this.btnGoiFormKhac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoiFormKhac.Location = new System.Drawing.Point(67, 282);
            this.btnGoiFormKhac.Name = "btnGoiFormKhac";
            this.btnGoiFormKhac.Size = new System.Drawing.Size(271, 100);
            this.btnGoiFormKhac.TabIndex = 3;
            this.btnGoiFormKhac.Text = "Gọi hiển thị Form khác";
            this.btnGoiFormKhac.UseVisualStyleBackColor = true;
            this.btnGoiFormKhac.Click += new System.EventHandler(this.btnGoiFormKhac_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(451, 281);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(271, 100);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát chương trình";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmPractice_c2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGoiFormKhac);
            this.Controls.Add(this.btnThemForm);
            this.Controls.Add(this.btnDoitieude);
            this.Controls.Add(this.label1);
            this.Name = "frmPractice_c2_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài thực hành hướng dẫn 01 – Chương 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoitieude;
        private System.Windows.Forms.Button btnThemForm;
        private System.Windows.Forms.Button btnGoiFormKhac;
        private System.Windows.Forms.Button btnThoat;
    }
}
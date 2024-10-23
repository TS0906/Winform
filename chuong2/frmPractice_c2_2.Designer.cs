namespace chuong2
{
    partial class frmPractice_c2_2
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
            this.lblSuKien = new System.Windows.Forms.Label();
            this.btnMoveMouse = new System.Windows.Forms.Button();
            this.btnClick = new System.Windows.Forms.Button();
            this.btnTextChange = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSuKien
            // 
            this.lblSuKien.AutoSize = true;
            this.lblSuKien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuKien.Location = new System.Drawing.Point(269, 93);
            this.lblSuKien.Name = "lblSuKien";
            this.lblSuKien.Size = new System.Drawing.Size(242, 25);
            this.lblSuKien.TabIndex = 0;
            this.lblSuKien.Text = "SỰ KIỆN CỦA FORM";
            // 
            // btnMoveMouse
            // 
            this.btnMoveMouse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveMouse.Location = new System.Drawing.Point(163, 168);
            this.btnMoveMouse.Name = "btnMoveMouse";
            this.btnMoveMouse.Size = new System.Drawing.Size(210, 100);
            this.btnMoveMouse.TabIndex = 1;
            this.btnMoveMouse.Text = "Sự kiện MoveMouse";
            this.btnMoveMouse.UseVisualStyleBackColor = true;
            this.btnMoveMouse.Click += new System.EventHandler(this.btnMoveMouse_Click);
            // 
            // btnClick
            // 
            this.btnClick.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.Location = new System.Drawing.Point(388, 168);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(210, 100);
            this.btnClick.TabIndex = 2;
            this.btnClick.Text = "Sự kiện Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnTextChange
            // 
            this.btnTextChange.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextChange.Location = new System.Drawing.Point(163, 298);
            this.btnTextChange.Name = "btnTextChange";
            this.btnTextChange.Size = new System.Drawing.Size(210, 100);
            this.btnTextChange.TabIndex = 3;
            this.btnTextChange.Text = "Sự kiện TextChange";
            this.btnTextChange.UseVisualStyleBackColor = true;
            this.btnTextChange.Click += new System.EventHandler(this.btnTextChange_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(388, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(210, 100);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát chương trình";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmPractice_c2_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTextChange);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.btnMoveMouse);
            this.Controls.Add(this.lblSuKien);
            this.Name = "frmPractice_c2_2";
            this.Text = "Bài thực hành tự làm số 01 - Chương 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuKien;
        private System.Windows.Forms.Button btnMoveMouse;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnTextChange;
        private System.Windows.Forms.Button btnExit;
    }
}
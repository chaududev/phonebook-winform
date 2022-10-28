
namespace QLDanhBaDu
{
    partial class ThemLienLac
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnTenGoi = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.TextBox();
            this.btnSoDienThoai = new System.Windows.Forms.TextBox();
            this.btnDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbNhom = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên gọi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTenGoi
            // 
            this.btnTenGoi.Location = new System.Drawing.Point(233, 59);
            this.btnTenGoi.Name = "btnTenGoi";
            this.btnTenGoi.Size = new System.Drawing.Size(258, 26);
            this.btnTenGoi.TabIndex = 0;
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(233, 102);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(258, 26);
            this.btnEmail.TabIndex = 1;
            // 
            // btnSoDienThoai
            // 
            this.btnSoDienThoai.Location = new System.Drawing.Point(233, 146);
            this.btnSoDienThoai.Name = "btnSoDienThoai";
            this.btnSoDienThoai.Size = new System.Drawing.Size(258, 26);
            this.btnSoDienThoai.TabIndex = 2;
            // 
            // btnDiaChi
            // 
            this.btnDiaChi.Location = new System.Drawing.Point(233, 190);
            this.btnDiaChi.Name = "btnDiaChi";
            this.btnDiaChi.Size = new System.Drawing.Size(258, 26);
            this.btnDiaChi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nhóm";
            // 
            // cbbNhom
            // 
            this.cbbNhom.FormattingEnabled = true;
            this.cbbNhom.Location = new System.Drawing.Point(233, 231);
            this.cbbNhom.Name = "cbbNhom";
            this.cbbNhom.Size = new System.Drawing.Size(258, 28);
            this.cbbNhom.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(395, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Trở lại";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ThemLienLac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(535, 391);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbbNhom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDiaChi);
            this.Controls.Add(this.btnSoDienThoai);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnTenGoi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemLienLac";
            this.Text = "Thêm liên lạc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox btnTenGoi;
        private System.Windows.Forms.TextBox btnEmail;
        private System.Windows.Forms.TextBox btnSoDienThoai;
        private System.Windows.Forms.TextBox btnDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbNhom;
        private System.Windows.Forms.Button button2;
    }
}
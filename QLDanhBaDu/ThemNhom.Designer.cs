
namespace QLDanhBaDu
{
    partial class ThemNhom
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
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.btnThemNhomOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhóm";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(205, 62);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(275, 26);
            this.txtTenNhom.TabIndex = 0;
            // 
            // btnThemNhomOK
            // 
            this.btnThemNhomOK.Location = new System.Drawing.Point(289, 151);
            this.btnThemNhomOK.Name = "btnThemNhomOK";
            this.btnThemNhomOK.Size = new System.Drawing.Size(88, 38);
            this.btnThemNhomOK.TabIndex = 1;
            this.btnThemNhomOK.Text = "Thêm";
            this.btnThemNhomOK.UseVisualStyleBackColor = true;
            this.btnThemNhomOK.Click += new System.EventHandler(this.btnThemNhomOK_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(393, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Trở lại";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ThemNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(531, 227);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThemNhomOK);
            this.Controls.Add(this.txtTenNhom);
            this.Controls.Add(this.label1);
            this.Name = "ThemNhom";
            this.Text = "Thêm nhóm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.Button btnThemNhomOK;
        private System.Windows.Forms.Button button1;
    }
}
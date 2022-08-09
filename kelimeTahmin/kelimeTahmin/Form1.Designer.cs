
namespace kelimeTahmin
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
            this.listHarf = new System.Windows.Forms.ListBox();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.textKontrol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listHarf
            // 
            this.listHarf.FormattingEnabled = true;
            this.listHarf.Location = new System.Drawing.Point(47, 42);
            this.listHarf.Name = "listHarf";
            this.listHarf.Size = new System.Drawing.Size(326, 485);
            this.listHarf.TabIndex = 0;
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.Location = new System.Drawing.Point(939, 504);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(75, 23);
            this.btnYeniOyun.TabIndex = 1;
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = true;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(632, 273);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(121, 33);
            this.btnKontrol.TabIndex = 1;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // textKontrol
            // 
            this.textKontrol.Location = new System.Drawing.Point(614, 216);
            this.textKontrol.Name = "textKontrol";
            this.textKontrol.Size = new System.Drawing.Size(154, 20);
            this.textKontrol.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 608);
            this.Controls.Add(this.textKontrol);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.listHarf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listHarf;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.TextBox textKontrol;
    }
}


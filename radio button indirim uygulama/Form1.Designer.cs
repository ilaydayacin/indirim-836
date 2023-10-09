namespace radio_button_indirim_uygulama
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.rb25 = new System.Windows.Forms.RadioButton();
            this.rb50 = new System.Windows.Forms.RadioButton();
            this.rb75 = new System.Windows.Forms.RadioButton();
            this.rb90 = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Fiyatı";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(12, 176);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(142, 25);
            this.lblSonuc.TabIndex = 1;
            this.lblSonuc.Text = "İndirimli fiyatı:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(164, 34);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(256, 29);
            this.txtFiyat.TabIndex = 2;
            // 
            // rb25
            // 
            this.rb25.AutoSize = true;
            this.rb25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb25.Location = new System.Drawing.Point(23, 106);
            this.rb25.Name = "rb25";
            this.rb25.Size = new System.Drawing.Size(59, 24);
            this.rb25.TabIndex = 3;
            this.rb25.TabStop = true;
            this.rb25.Text = "%25";
            this.rb25.UseVisualStyleBackColor = true;
            // 
            // rb50
            // 
            this.rb50.AutoSize = true;
            this.rb50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb50.Location = new System.Drawing.Point(164, 106);
            this.rb50.Name = "rb50";
            this.rb50.Size = new System.Drawing.Size(59, 24);
            this.rb50.TabIndex = 4;
            this.rb50.TabStop = true;
            this.rb50.Text = "%50";
            this.rb50.UseVisualStyleBackColor = true;
            // 
            // rb75
            // 
            this.rb75.AutoSize = true;
            this.rb75.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb75.Location = new System.Drawing.Point(308, 106);
            this.rb75.Name = "rb75";
            this.rb75.Size = new System.Drawing.Size(59, 24);
            this.rb75.TabIndex = 5;
            this.rb75.TabStop = true;
            this.rb75.Text = "%75";
            this.rb75.UseVisualStyleBackColor = true;
            // 
            // rb90
            // 
            this.rb90.AutoSize = true;
            this.rb90.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb90.Location = new System.Drawing.Point(449, 106);
            this.rb90.Name = "rb90";
            this.rb90.Size = new System.Drawing.Size(59, 24);
            this.rb90.TabIndex = 6;
            this.rb90.TabStop = true;
            this.rb90.Text = "%90";
            this.rb90.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(308, 176);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(200, 113);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "İndirim Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.rb90);
            this.Controls.Add(this.rb75);
            this.Controls.Add(this.rb50);
            this.Controls.Add(this.rb25);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.RadioButton rb25;
        private System.Windows.Forms.RadioButton rb50;
        private System.Windows.Forms.RadioButton rb75;
        private System.Windows.Forms.RadioButton rb90;
        private System.Windows.Forms.Button btnHesapla;
    }
}


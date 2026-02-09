namespace bayrak_oyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.baslık = new System.Windows.Forms.Label();
            this.ulkeler_label = new System.Windows.Forms.Label();
            this.gonder_buton = new System.Windows.Forms.Button();
            this.sonraki_buton = new System.Windows.Forms.Button();
            this.dogruulke_label = new System.Windows.Forms.Label();
            this.dogruulke_textbox = new System.Windows.Forms.TextBox();
            this.puan_label = new System.Windows.Forms.Label();
            this.puan_textbox = new System.Windows.Forms.TextBox();
            this.ulkeler_combobox = new System.Windows.Forms.ComboBox();
            this.bayrak_picturebox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bayrak_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // baslık
            // 
            this.baslık.AutoSize = true;
            this.baslık.BackColor = System.Drawing.Color.Transparent;
            this.baslık.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold);
            this.baslık.ForeColor = System.Drawing.Color.Lavender;
            this.baslık.Location = new System.Drawing.Point(430, 9);
            this.baslık.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baslık.Name = "baslık";
            this.baslık.Size = new System.Drawing.Size(337, 51);
            this.baslık.TabIndex = 0;
            this.baslık.Text = "-Bayrak Oyunu-";
            this.baslık.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ulkeler_label
            // 
            this.ulkeler_label.AutoSize = true;
            this.ulkeler_label.BackColor = System.Drawing.Color.Transparent;
            this.ulkeler_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulkeler_label.ForeColor = System.Drawing.Color.Lavender;
            this.ulkeler_label.Location = new System.Drawing.Point(698, 214);
            this.ulkeler_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ulkeler_label.Name = "ulkeler_label";
            this.ulkeler_label.Size = new System.Drawing.Size(215, 38);
            this.ulkeler_label.TabIndex = 3;
            this.ulkeler_label.Text = "Ülke seçiniz:";
            // 
            // gonder_buton
            // 
            this.gonder_buton.BackColor = System.Drawing.Color.Pink;
            this.gonder_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.2F, System.Drawing.FontStyle.Bold);
            this.gonder_buton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(4)))), ((int)(((byte)(72)))));
            this.gonder_buton.Location = new System.Drawing.Point(705, 306);
            this.gonder_buton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gonder_buton.Name = "gonder_buton";
            this.gonder_buton.Size = new System.Drawing.Size(420, 57);
            this.gonder_buton.TabIndex = 4;
            this.gonder_buton.Text = "Gönder";
            this.gonder_buton.UseVisualStyleBackColor = false;
            this.gonder_buton.Click += new System.EventHandler(this.gonder_buton_Click);
            // 
            // sonraki_buton
            // 
            this.sonraki_buton.BackColor = System.Drawing.Color.Pink;
            this.sonraki_buton.Enabled = false;
            this.sonraki_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.2F, System.Drawing.FontStyle.Bold);
            this.sonraki_buton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(4)))), ((int)(((byte)(72)))));
            this.sonraki_buton.Location = new System.Drawing.Point(705, 390);
            this.sonraki_buton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sonraki_buton.Name = "sonraki_buton";
            this.sonraki_buton.Size = new System.Drawing.Size(420, 62);
            this.sonraki_buton.TabIndex = 5;
            this.sonraki_buton.Text = "Sonraki Bayrak";
            this.sonraki_buton.UseVisualStyleBackColor = false;
            this.sonraki_buton.Click += new System.EventHandler(this.sonraki_buton_Click);
            // 
            // dogruulke_label
            // 
            this.dogruulke_label.AutoSize = true;
            this.dogruulke_label.BackColor = System.Drawing.Color.Transparent;
            this.dogruulke_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.dogruulke_label.ForeColor = System.Drawing.Color.Lavender;
            this.dogruulke_label.Location = new System.Drawing.Point(77, 587);
            this.dogruulke_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dogruulke_label.Name = "dogruulke_label";
            this.dogruulke_label.Size = new System.Drawing.Size(208, 39);
            this.dogruulke_label.TabIndex = 6;
            this.dogruulke_label.Text = "Doğru Ülke:";
            // 
            // dogruulke_textbox
            // 
            this.dogruulke_textbox.Enabled = false;
            this.dogruulke_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogruulke_textbox.Location = new System.Drawing.Point(276, 583);
            this.dogruulke_textbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dogruulke_textbox.Name = "dogruulke_textbox";
            this.dogruulke_textbox.ReadOnly = true;
            this.dogruulke_textbox.Size = new System.Drawing.Size(392, 45);
            this.dogruulke_textbox.TabIndex = 7;
            // 
            // puan_label
            // 
            this.puan_label.AutoSize = true;
            this.puan_label.BackColor = System.Drawing.Color.Transparent;
            this.puan_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.puan_label.ForeColor = System.Drawing.Color.Lavender;
            this.puan_label.Location = new System.Drawing.Point(118, 659);
            this.puan_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.puan_label.Name = "puan_label";
            this.puan_label.Size = new System.Drawing.Size(167, 39);
            this.puan_label.TabIndex = 8;
            this.puan_label.Text = "Puanınız:";
            // 
            // puan_textbox
            // 
            this.puan_textbox.Enabled = false;
            this.puan_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puan_textbox.Location = new System.Drawing.Point(276, 653);
            this.puan_textbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.puan_textbox.Name = "puan_textbox";
            this.puan_textbox.ReadOnly = true;
            this.puan_textbox.Size = new System.Drawing.Size(101, 45);
            this.puan_textbox.TabIndex = 9;
            // 
            // ulkeler_combobox
            // 
            this.ulkeler_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulkeler_combobox.FormattingEnabled = true;
            this.ulkeler_combobox.Location = new System.Drawing.Point(918, 212);
            this.ulkeler_combobox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ulkeler_combobox.Name = "ulkeler_combobox";
            this.ulkeler_combobox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ulkeler_combobox.Size = new System.Drawing.Size(216, 46);
            this.ulkeler_combobox.TabIndex = 2;
            // 
            // bayrak_picturebox
            // 
            this.bayrak_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.bayrak_picturebox.Location = new System.Drawing.Point(52, 156);
            this.bayrak_picturebox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bayrak_picturebox.Name = "bayrak_picturebox";
            this.bayrak_picturebox.Size = new System.Drawing.Size(658, 390);
            this.bayrak_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bayrak_picturebox.TabIndex = 0;
            this.bayrak_picturebox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(297, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bayrak";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1152, 783);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bayrak_picturebox);
            this.Controls.Add(this.puan_textbox);
            this.Controls.Add(this.puan_label);
            this.Controls.Add(this.dogruulke_textbox);
            this.Controls.Add(this.dogruulke_label);
            this.Controls.Add(this.sonraki_buton);
            this.Controls.Add(this.gonder_buton);
            this.Controls.Add(this.ulkeler_label);
            this.Controls.Add(this.ulkeler_combobox);
            this.Controls.Add(this.baslık);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bayrak_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baslık;
        private System.Windows.Forms.Label ulkeler_label;
        private System.Windows.Forms.Button gonder_buton;
        private System.Windows.Forms.Button sonraki_buton;
        private System.Windows.Forms.Label dogruulke_label;
        private System.Windows.Forms.TextBox dogruulke_textbox;
        private System.Windows.Forms.Label puan_label;
        private System.Windows.Forms.TextBox puan_textbox;
        private System.Windows.Forms.ComboBox ulkeler_combobox;
        private System.Windows.Forms.PictureBox bayrak_picturebox;
        private System.Windows.Forms.Label label1;
    }
}


namespace asdfghjk
{
    partial class Form2
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
            this.button_parayatirma = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_bakiyesorgu = new System.Windows.Forms.Button();
            this.button_cikis = new System.Windows.Forms.Button();
            this.button_borcode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_yatirilann = new System.Windows.Forms.TextBox();
            this.button_yatirmaonay = new System.Windows.Forms.Button();
            this.button_gerii = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_cekilenn = new System.Windows.Forms.TextBox();
            this.button_cekmeonay = new System.Windows.Forms.Button();
            this.button_cekmegeri = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_bakiye = new System.Windows.Forms.TextBox();
            this.button_bakiyegeri = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_borcode = new System.Windows.Forms.TextBox();
            this.button_borcodeonay = new System.Windows.Forms.Button();
            this.button_borcodegeri = new System.Windows.Forms.Button();
            this.button_borcsorgu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_parayatirma
            // 
            this.button_parayatirma.Location = new System.Drawing.Point(73, 68);
            this.button_parayatirma.Name = "button_parayatirma";
            this.button_parayatirma.Size = new System.Drawing.Size(133, 24);
            this.button_parayatirma.TabIndex = 0;
            this.button_parayatirma.Text = "Para Yatırma";
            this.button_parayatirma.UseVisualStyleBackColor = true;
            this.button_parayatirma.Click += new System.EventHandler(this.button_parayatirma_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Para Çekme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_bakiyesorgu
            // 
            this.button_bakiyesorgu.Location = new System.Drawing.Point(75, 154);
            this.button_bakiyesorgu.Name = "button_bakiyesorgu";
            this.button_bakiyesorgu.Size = new System.Drawing.Size(132, 23);
            this.button_bakiyesorgu.TabIndex = 2;
            this.button_bakiyesorgu.Text = "Bakiye Sorgulama";
            this.button_bakiyesorgu.UseVisualStyleBackColor = true;
            this.button_bakiyesorgu.Click += new System.EventHandler(this.button_bakiyesorgu_Click);
            // 
            // button_cikis
            // 
            this.button_cikis.Location = new System.Drawing.Point(74, 212);
            this.button_cikis.Name = "button_cikis";
            this.button_cikis.Size = new System.Drawing.Size(133, 23);
            this.button_cikis.TabIndex = 3;
            this.button_cikis.Text = "Çıkış";
            this.button_cikis.UseVisualStyleBackColor = true;
            this.button_cikis.Click += new System.EventHandler(this.button_cikis_Click);
            // 
            // button_borcode
            // 
            this.button_borcode.Location = new System.Drawing.Point(73, 183);
            this.button_borcode.Name = "button_borcode";
            this.button_borcode.Size = new System.Drawing.Size(133, 23);
            this.button_borcode.TabIndex = 4;
            this.button_borcode.Text = "Borç Ödeme";
            this.button_borcode.UseVisualStyleBackColor = true;
            this.button_borcode.Click += new System.EventHandler(this.button_borcode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yatırmak İstediğiniz Tutar";
            this.label1.Visible = false;
            // 
            // textBox_yatirilann
            // 
            this.textBox_yatirilann.Location = new System.Drawing.Point(155, 62);
            this.textBox_yatirilann.Name = "textBox_yatirilann";
            this.textBox_yatirilann.Size = new System.Drawing.Size(100, 20);
            this.textBox_yatirilann.TabIndex = 6;
            this.textBox_yatirilann.Visible = false;
            // 
            // button_yatirmaonay
            // 
            this.button_yatirmaonay.Location = new System.Drawing.Point(75, 89);
            this.button_yatirmaonay.Name = "button_yatirmaonay";
            this.button_yatirmaonay.Size = new System.Drawing.Size(132, 23);
            this.button_yatirmaonay.TabIndex = 7;
            this.button_yatirmaonay.Text = "İşlemi Onayla";
            this.button_yatirmaonay.UseVisualStyleBackColor = true;
            this.button_yatirmaonay.Visible = false;
            this.button_yatirmaonay.Click += new System.EventHandler(this.button_yatirmaonay_Click);
            // 
            // button_gerii
            // 
            this.button_gerii.Location = new System.Drawing.Point(74, 118);
            this.button_gerii.Name = "button_gerii";
            this.button_gerii.Size = new System.Drawing.Size(131, 23);
            this.button_gerii.TabIndex = 8;
            this.button_gerii.Text = "Geri";
            this.button_gerii.UseVisualStyleBackColor = true;
            this.button_gerii.Visible = false;
            this.button_gerii.Click += new System.EventHandler(this.button_gerii_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Çekmek İstediğiniz Tutar";
            this.label2.Visible = false;
            // 
            // textBox_cekilenn
            // 
            this.textBox_cekilenn.Location = new System.Drawing.Point(155, 91);
            this.textBox_cekilenn.Name = "textBox_cekilenn";
            this.textBox_cekilenn.Size = new System.Drawing.Size(99, 20);
            this.textBox_cekilenn.TabIndex = 10;
            this.textBox_cekilenn.Visible = false;
            // 
            // button_cekmeonay
            // 
            this.button_cekmeonay.Location = new System.Drawing.Point(75, 119);
            this.button_cekmeonay.Name = "button_cekmeonay";
            this.button_cekmeonay.Size = new System.Drawing.Size(132, 23);
            this.button_cekmeonay.TabIndex = 11;
            this.button_cekmeonay.Text = "İşlemi Onayla";
            this.button_cekmeonay.UseVisualStyleBackColor = true;
            this.button_cekmeonay.Visible = false;
            this.button_cekmeonay.Click += new System.EventHandler(this.button_cekmeonay_Click);
            // 
            // button_cekmegeri
            // 
            this.button_cekmegeri.Location = new System.Drawing.Point(73, 148);
            this.button_cekmegeri.Name = "button_cekmegeri";
            this.button_cekmegeri.Size = new System.Drawing.Size(130, 23);
            this.button_cekmegeri.TabIndex = 12;
            this.button_cekmegeri.Text = "Geri";
            this.button_cekmegeri.UseVisualStyleBackColor = true;
            this.button_cekmegeri.Visible = false;
            this.button_cekmegeri.Click += new System.EventHandler(this.button_cekmegeri_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bakiyeniz:";
            this.label3.Visible = false;
            // 
            // textBox_bakiye
            // 
            this.textBox_bakiye.Location = new System.Drawing.Point(132, 75);
            this.textBox_bakiye.Name = "textBox_bakiye";
            this.textBox_bakiye.Size = new System.Drawing.Size(100, 20);
            this.textBox_bakiye.TabIndex = 14;
            this.textBox_bakiye.Visible = false;
            this.textBox_bakiye.TextChanged += new System.EventHandler(this.textBox_bakiye_TextChanged);
            // 
            // button_bakiyegeri
            // 
            this.button_bakiyegeri.Location = new System.Drawing.Point(74, 110);
            this.button_bakiyegeri.Name = "button_bakiyegeri";
            this.button_bakiyegeri.Size = new System.Drawing.Size(132, 23);
            this.button_bakiyegeri.TabIndex = 15;
            this.button_bakiyegeri.Text = "Geri";
            this.button_bakiyegeri.UseVisualStyleBackColor = true;
            this.button_bakiyegeri.Visible = false;
            this.button_bakiyegeri.Click += new System.EventHandler(this.button_bakiyegeri_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ödemek İstediğiniz Miktar:";
            this.label4.Visible = false;
            // 
            // textBox_borcode
            // 
            this.textBox_borcode.Location = new System.Drawing.Point(155, 111);
            this.textBox_borcode.Name = "textBox_borcode";
            this.textBox_borcode.Size = new System.Drawing.Size(100, 20);
            this.textBox_borcode.TabIndex = 17;
            this.textBox_borcode.Visible = false;
            // 
            // button_borcodeonay
            // 
            this.button_borcodeonay.Location = new System.Drawing.Point(75, 139);
            this.button_borcodeonay.Name = "button_borcodeonay";
            this.button_borcodeonay.Size = new System.Drawing.Size(130, 23);
            this.button_borcodeonay.TabIndex = 18;
            this.button_borcodeonay.Text = "İşlemi Onayla";
            this.button_borcodeonay.UseVisualStyleBackColor = true;
            this.button_borcodeonay.Visible = false;
            this.button_borcodeonay.Click += new System.EventHandler(this.button_borcodeonay_Click);
            // 
            // button_borcodegeri
            // 
            this.button_borcodegeri.Location = new System.Drawing.Point(73, 168);
            this.button_borcodegeri.Name = "button_borcodegeri";
            this.button_borcodegeri.Size = new System.Drawing.Size(131, 23);
            this.button_borcodegeri.TabIndex = 19;
            this.button_borcodegeri.Text = "Geri";
            this.button_borcodegeri.UseVisualStyleBackColor = true;
            this.button_borcodegeri.Visible = false;
            this.button_borcodegeri.Click += new System.EventHandler(this.button_borcodegeri_Click_1);
            // 
            // button_borcsorgu
            // 
            this.button_borcsorgu.Location = new System.Drawing.Point(75, 127);
            this.button_borcsorgu.Name = "button_borcsorgu";
            this.button_borcsorgu.Size = new System.Drawing.Size(130, 23);
            this.button_borcsorgu.TabIndex = 20;
            this.button_borcsorgu.Text = "Borç Sorgulama";
            this.button_borcsorgu.UseVisualStyleBackColor = true;
            this.button_borcsorgu.Click += new System.EventHandler(this.button_borcsorgu_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_borcode);
            this.Controls.Add(this.button_cikis);
            this.Controls.Add(this.button_parayatirma);
            this.Controls.Add(this.button_yatirmaonay);
            this.Controls.Add(this.button_borcodegeri);
            this.Controls.Add(this.textBox_cekilenn);
            this.Controls.Add(this.textBox_yatirilann);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_bakiye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_bakiyegeri);
            this.Controls.Add(this.button_borcodeonay);
            this.Controls.Add(this.textBox_borcode);
            this.Controls.Add(this.button_cekmeonay);
            this.Controls.Add(this.button_gerii);
            this.Controls.Add(this.button_borcsorgu);
            this.Controls.Add(this.button_bakiyesorgu);
            this.Controls.Add(this.button_cekmegeri);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_parayatirma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_bakiyesorgu;
        private System.Windows.Forms.Button button_cikis;
        private System.Windows.Forms.Button button_borcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_yatirilann;
        private System.Windows.Forms.Button button_yatirmaonay;
        private System.Windows.Forms.Button button_gerii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cekilenn;
        private System.Windows.Forms.Button button_cekmeonay;
        private System.Windows.Forms.Button button_cekmegeri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_bakiye;
        private System.Windows.Forms.Button button_bakiyegeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_borcode;
        private System.Windows.Forms.Button button_borcodeonay;
        private System.Windows.Forms.Button button_borcodegeri;
        private System.Windows.Forms.Button button_borcsorgu;
    }
}
namespace asdfghjk
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
            this.components = new System.ComponentModel.Container();
            this.texbox_tc = new System.Windows.Forms.TextBox();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.button_giris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_cikis1 = new System.Windows.Forms.Button();
            this.lblBir = new System.Windows.Forms.Label();
            this.appTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // texbox_tc
            // 
            this.texbox_tc.Location = new System.Drawing.Point(134, 72);
            this.texbox_tc.Name = "texbox_tc";
            this.texbox_tc.Size = new System.Drawing.Size(63, 20);
            this.texbox_tc.TabIndex = 0;
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Location = new System.Drawing.Point(134, 98);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.Size = new System.Drawing.Size(63, 20);
            this.textBox_sifre.TabIndex = 1;
            // 
            // button_giris
            // 
            this.button_giris.Location = new System.Drawing.Point(82, 140);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(115, 44);
            this.button_giris.TabIndex = 2;
            this.button_giris.Text = "GİRİŞ";
            this.button_giris.UseVisualStyleBackColor = true;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // button_cikis1
            // 
            this.button_cikis1.Location = new System.Drawing.Point(189, 12);
            this.button_cikis1.Name = "button_cikis1";
            this.button_cikis1.Size = new System.Drawing.Size(75, 23);
            this.button_cikis1.TabIndex = 5;
            this.button_cikis1.Text = "ÇIKIŞ";
            this.button_cikis1.UseVisualStyleBackColor = true;
            this.button_cikis1.Click += new System.EventHandler(this.button_cikis1_Click);
            // 
            // lblBir
            // 
            this.lblBir.AutoSize = true;
            this.lblBir.Location = new System.Drawing.Point(13, 12);
            this.lblBir.Name = "lblBir";
            this.lblBir.Size = new System.Drawing.Size(35, 13);
            this.lblBir.TabIndex = 6;
            this.lblBir.Text = "label3";
            // 
            // appTimer
            // 
            this.appTimer.Tick += new System.EventHandler(this.appTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 229);
            this.Controls.Add(this.lblBir);
            this.Controls.Add(this.button_cikis1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_giris);
            this.Controls.Add(this.textBox_sifre);
            this.Controls.Add(this.texbox_tc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texbox_tc;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button button_giris;
        private System.Windows.Forms.Button button_cikis1;
        private System.Windows.Forms.Label lblBir;
        private System.Windows.Forms.Timer appTimer;
    }
}


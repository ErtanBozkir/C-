using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asdfghjk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            appTimer.Start();

        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            if ((int.Parse(texbox_tc.Text) == 123) && (int.Parse(textBox_sifre.Text)== 456))
            {   
                Form2 form2 =new Form2();
                form2.Show();
                form2.para = 100;//bu tc nin parası 100
                
                Hide();
            }else if ((int.Parse(texbox_tc.Text) == 987) && (int.Parse(textBox_sifre.Text)== 456))//if den snra ; olmaz
            {   
                Form2 form2 =new Form2();
                form2.Show();
                form2.para = 200;//bu tc nin parası 200
                
                Hide();
            }
            else 
            {

                MessageBox.Show("Hatalı Giriş Yaptınız.");
            }
            
        
        }

        private void button_cikis1_Click(object sender, EventArgs e)
        {
            this.Close();   //form ekranını kapatır
            Application.Exit();  //debugı sonlandırır

        }

        private void appTimer_Tick(object sender, EventArgs e)
        {
            lblBir.Text = DateTime.Now.ToLongTimeString(); // saat ekler
           // lblBir.Text = DateTime.Now.ToShortDateString();    tarih ekler
        }
    }
}

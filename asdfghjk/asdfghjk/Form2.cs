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
    public partial class Form2 : Form
    {

        public int para;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_cikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button_parayatirma_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button_bakiyesorgu.Visible= false;
            button_borcode.Visible = false;
            button_cikis.Visible = false;
            button_parayatirma.Visible = false;
            label1.Visible = true;
            textBox_yatirilann.Visible = true;
            button_yatirmaonay.Visible = true;
            button_gerii.Visible = true;
            button_borcsorgu.Visible = false;
        }

        private void button_gerii_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button_bakiyesorgu.Visible = true;
            button_borcode.Visible = true;
            button_cikis.Visible = true;
            button_parayatirma.Visible = true;
            label1.Visible = false;
            textBox_yatirilann.Visible = false;
            button_yatirmaonay.Visible = false;
            button_gerii.Visible = false;
            button_borcsorgu.Visible = true;

        }

        private void button_yatirmaonay_Click(object sender, EventArgs e)
        {
            para = para + int.Parse(textBox_yatirilann.Text);//strgin i int e cevirdim
            MessageBox.Show("İşlem Gerçekleşti Güncel Bakiyeniz: "+para+" TL");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button_bakiyesorgu.Visible = false;
            button_borcode.Visible = false;
            button_cikis.Visible = false;
            button_parayatirma.Visible = false;
            label1.Visible = false;
            textBox_yatirilann.Visible = false;
            button_yatirmaonay.Visible = false;
            button_gerii.Visible = false;
            label2.Visible = true;
            textBox_cekilenn.Visible = true;
            button_cekmeonay.Visible = true;
            button_cekmegeri.Visible = true;
            button_borcsorgu.Visible = false;

            
        }

        private void button_cekmegeri_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button_bakiyesorgu.Visible = true;
            button_borcode.Visible = true;
            button_cikis.Visible = true;
            button_parayatirma.Visible = true;
            label1.Visible = false;
            textBox_yatirilann.Visible = false;
            button_yatirmaonay.Visible = false;
            button_gerii.Visible = false;
            label2.Visible = false;
            textBox_cekilenn.Visible = false;
            button_cekmeonay.Visible = false;
            button_cekmegeri.Visible = false;
            button_borcsorgu.Visible = true;
        }

        private void button_bakiyegeri_Click(object sender, EventArgs e)
        {

            button1.Visible = true;
            button_bakiyesorgu.Visible = true;
            button_borcode.Visible = true;
            button_cikis.Visible = true;
            button_parayatirma.Visible = true;
            button_bakiyegeri.Visible = false;
            label3.Visible = false;
            textBox_bakiye.Visible = false;
            button_borcsorgu.Visible = true;
        }

        private void button_bakiyesorgu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güncel Bakiyeniz: " + para + " TL");
            /*button1.Visible = false;
            button_bakiyesorgu.Visible = false;
            button_borcode.Visible = false;
            button_cikis.Visible = false;
            button_parayatirma.Visible = false;
            button_bakiyegeri.Visible = true;
            label3.Visible = true;
            textBox_bakiye.Visible = true;*/
        }

        private void button_borcode_Click(object sender, EventArgs e)
        {
            {
                if ((para) < (0))
                {

                    button1.Visible = false;
                    button_bakiyesorgu.Visible = false;
                    button_borcode.Visible = false;
                    button_cikis.Visible = false;
                    button_parayatirma.Visible = false;
                    label4.Visible = true;
                    textBox_borcode.Visible = true;
                    button_borcodegeri.Visible = true;
                    button_borcodeonay.Visible = true;
                    button_borcsorgu.Visible = false;


                }
                else
                {
                    MessageBox.Show("Borcunuz Bulunmamaktadır");
                }
            }
        }

        private void button_borcodegeri_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button_bakiyesorgu.Visible = true;
            button_borcode.Visible = true;
            button_cikis.Visible = true;
            button_parayatirma.Visible = true;
            label4.Visible = false;
            button_borcsorgu.Visible = true;
;
            //textBox_borcode.Visible = true;
            //button_borcodegeri.Visible = true;
            //button_borcodeonay.Visible = true;
        }private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void button_borcodegeri_Click_1(object sender, EventArgs e)
        {
            button1.Visible = true;
            button_bakiyesorgu.Visible = true;
            button_borcode.Visible = true;
            button_cikis.Visible = true;
            button_parayatirma.Visible = true;
            label4.Visible = false;
            textBox_borcode.Visible = false;
            button_borcodegeri.Visible = false;
            button_borcodeonay.Visible = false;
            button_borcsorgu.Visible = true;
        }

        private void textBox_bakiye_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_cekmeonay_Click(object sender, EventArgs e)
        {
            para = para - int.Parse(textBox_cekilenn.Text);
            MessageBox.Show("İşleminiz Gerçekleşti Bakiyeniz: " + para + " TL");
        }

        private void button_borcsorgu_Click(object sender, EventArgs e)
        {
            if ((para) < (0))

                MessageBox.Show("Toplam Borcunuz: " + para + " TL");
            else
                MessageBox.Show("Borcunuz Bulunmamaktadır");
        }

        private void button_borcodeonay_Click(object sender, EventArgs e)
        {
            para = para + int.Parse(textBox_borcode.Text);
            MessageBox.Show("Bakiyeniz: " + para + " TL");
        }

        
    }
}

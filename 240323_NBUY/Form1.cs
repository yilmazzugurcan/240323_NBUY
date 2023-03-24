using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _240323_NBUY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            #region Text Boxlara girilen 2 sayıyı toplama , boş bırakılırsa uyarı verir
            /* int sayi1 = Convert.ToInt32(textBox1.Text);
     int sayi2 = Convert.ToInt32(textBox2.Text);
     int toplam = sayi1 + sayi2;
     if (textBox1=)
     {
         MessageBox.Show("Değer Girin");
     }

      MessageBox.Show("Toplam: " + toplam.ToString());*/

            /*  if (textBox1.Text != "" && textBox2.Text != "")
              {
                  // TextBox'ların içi doluysa, işlemleri yap
                  int sayi1 = Convert.ToInt32(textBox1.Text);
                  int sayi2 = Convert.ToInt32(textBox2.Text);
                  int toplam = sayi1 + sayi2;
                  // MessageBox.Show("Toplam: " + toplam.ToString());
                  label3.Text = toplam.ToString();
              }
              else
              {
                  MessageBox.Show("Lütfen tüm alanları doldurun.");
              } */
            #endregion

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                // TextBox'ların içi doluysa, işlemleri yap
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int ort = (sayi1 + sayi2) / 2;
                // MessageBox.Show("Toplam: " + toplam.ToString());
                label3.Text = ort.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _240323_NBUY
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                double ort = (sayi1*0.4 + sayi2*0.6);
                // MessageBox.Show("Toplam: " + toplam.ToString());
                label1.Text = ort.ToString();

                if (ort >= 60)
                {
                    MessageBox.Show("Geçti");
                }
                else
                {
                    MessageBox.Show("Kaldı");
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

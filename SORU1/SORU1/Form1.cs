using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SORU1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct AritmatikOrtalama
        {
            public double sayi1;
            public double sayi2;
            public double sayi3;
            public double hesapla()
            {
                return (sayi1 + sayi2 + sayi3) / 3;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AritmatikOrtalama ao = new AritmatikOrtalama();
            ao.sayi1 =Convert.ToDouble(textBox1.Text);
            ao.sayi2 = Convert.ToDouble(textBox2.Text);
            ao.sayi3 = Convert.ToDouble(textBox3.Text);
            MessageBox.Show(ao.hesapla().ToString());
        }
    }
}

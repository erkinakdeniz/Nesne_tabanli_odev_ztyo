using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru3
{
    public partial class Form1 : Form
    {

     class cerezci
        {
            public cerezci()
            {
                MessageBox.Show("Hoş Geldiniz");
            }
           
            private int kg;
            public string cinsi="çetin";
            public bool tuzlu;
            public string cekirdekAl(int KG)
            {
                kg = KG;
                if (tuzlu)
                {
                    return kg + " KG tuzlu Çekirdek Aldınız";
                    
                }
                else
                    return kg + " KG tuzsuz Çekirdek Aldınız";

            }
            public string cevizAl(int KG)
            {
                kg = KG;
                return kg + " KG "+cinsi+" Ceviz Aldınız";
                
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cerezci cerezim = new cerezci();
            listBox1.Items.Add(cerezim.cevizAl(Convert.ToInt32(textBox1.Text)));
            MessageBox.Show("Güle Güle");

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cerezci cerezcim = new cerezci();
            listBox1.Items.Add(cerezcim.cekirdekAl(Convert.ToInt32(textBox1.Text)));
            MessageBox.Show("Güle Güle");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cerezci cerez1 = new cerezci();
            cerezci cerez2 = new cerezci();

            cerez1.tuzlu = true;
            listBox1.Items.Add(cerez1.cevizAl(6));
            MessageBox.Show("Güle Güle");
            cerez2.cinsi = "Normal";
            listBox1.Items.Add(cerez2.cevizAl(2));
            MessageBox.Show("Güle Güle");


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SORU2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(veriler.ERKİNAKDENİZ);
            comboBox1.Items.Add(veriler.Maküybst);
            comboBox1.Items.Add(veriler.MehmetAkifErsoyÜniversitesi);
            comboBox1.Items.Add(veriler.YazılımSensin);
            comboBox1.Items.Add(veriler.YazılımHeryerde);
           
        }
        enum veriler
        {
            Maküybst,
            MehmetAkifErsoyÜniversitesi,
            YazılımSensin,
            YazılımHeryerde,
            ERKİNAKDENİZ
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mesaj="";
            if (comboBox1.SelectedIndex>-1)
            {
                mesaj = comboBox1.SelectedItem.ToString();
            }
            byte[] hexadec = Encoding.Default.GetBytes(mesaj);
            var hexString = BitConverter.ToString(hexadec);
            hexString = hexString.Replace("-", "");
            MessageBox.Show(hexString);
        }
    }
}
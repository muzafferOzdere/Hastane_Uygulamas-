using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane0._2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string isim;
        Random r = new Random();
        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Hoşgeldiniz Sayın " + isim;
            label2.Text = r.Next(0, 6).ToString() + " Adet hastanız sizi beklemekte.... \r\nDaha detaylı bakmak için butona tıklayınız";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

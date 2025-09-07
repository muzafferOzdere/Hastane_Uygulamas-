using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hastane0._2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DialogResult cevap;
        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 ac = new Form1();
            ac.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            string sifre = textBox2.Text;

            if (string.IsNullOrWhiteSpace(isim))
            {
                MessageBox.Show("Ad boş bırakılamaz", "Hata");
                textBox1.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Şifre boş bırakılamaz", "Hata");
                textBox2.Focus();
                return;
            }

            string sorgu = "SELECT * FROM doktorlar_giris WHERE doktorAd = @isim AND doktorSifre = @sifre";
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Uid=root;Pwd=1234;Database=hastane");
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@isim", isim);
            komut.Parameters.AddWithValue("@sifre", sifre);

            try
            {
                baglanti.Open();
                MySqlDataAdapter adaptor = new MySqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);

                if (tablo.Rows.Count > 0)
                {
                    MessageBox.Show("Giriş başarılı!");
                    Form3 ac = new Form3();
                    ac.isim = isim;
                    cevap = ac.ShowDialog();
                }
                else
                {
                    MessageBox.Show("İsim veya Şifre yanlış, tekrar deneyiniz", "Giriş başarısız", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void girişYapamıyorumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İs");
        }
    }
}

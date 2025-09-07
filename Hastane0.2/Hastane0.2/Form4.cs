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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        void listeleme()
        {
            try
            {
            string sorgu = "SELECT hastaNo,hastaAd,hastaSoyad FROM hasta";
            MySqlConnection baglanti = new MySqlConnection("Server = localhost ; Uid = root; Pwd = 1234 ; Database =hastane");
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataAdapter adaptor = new MySqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adaptor.Fill(tablo);
            dataGridView1.DataSource = tablo;
            }
            catch (Exception)
            {
                MessageBox.Show("Data da bir hata ortaya geldi(Büyük ihtimalle şifreden)");
            }

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            listeleme();
            comboBox1.Items.Add("Karın Ağrısı");
            comboBox1.Items.Add("Kulak Ağrısı");
            comboBox1.Items.Add("Baş Ağrısı");
            comboBox1.Items.Add("İşitme Sorunları");
            comboBox1.Items.Add("Burun Tıkanıklığı");
            comboBox1.Items.Add("Göz bozuklukları");
            comboBox1.Items.Add("Eklem Ağrıları");
            comboBox1.Items.Add("Şiddetli Öksürük");
            comboBox1.Items.Add("Boğaz Ağrısı");
            comboBox1.Items.Add("Baş Dönmesi");
            comboBox1.Items.Add("Halsizlik");
            comboBox1.Items.Add("Uzun Süreli İshal");
            comboBox1.Items.Add("Kasık Bölgelerinde Ağrı");
            comboBox1.Items.Add("Dişlerde Kanama");
            comboBox1.Items.Add("Vücutta Şişlikler");
            comboBox1.Items.Add("Ağızdan Kan Gelmesi");
            comboBox1.Items.Add("Ayak/El bileklerinde Şişlik");
            comboBox1.Items.Add("Kol/El/Bacak/Ayak Kemiklerinde Çıkıntı/Kırılma");
            comboBox1.Items.Add("Vücutta Kızarıklık");

            comboBox2.Items.Add("Kulak,Burun,Boğaz");
            comboBox2.Items.Add("Çocuk Hastalıkları");
            comboBox2.Items.Add("Göz Hastalıkları");

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                listBox1.Items.Add(comboBox1.SelectedItem);
                comboBox1.SelectedIndex = -1;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.SelectedIndex = -1;
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("İsim kısmını boş bırakılamaz","Eksik doldurdunuz",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                }
                else if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Soyad kısmını boş bırakılamaz","Eksik doldurdunuz",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                }
                else if (string.IsNullOrEmpty(maskedTextBox1.Text) || string.IsNullOrWhiteSpace(maskedTextBox1.Text))
                {
                    MessageBox.Show("TC kısmı boş bırakmayınız", "Eksik doldurdunuz", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("Bir cinsiyet seçiniz", "Eksik doldurdunuz", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (string.IsNullOrEmpty(maskedTextBox2.Text) || string.IsNullOrWhiteSpace(maskedTextBox2.Text))
                {
                    MessageBox.Show("Doğum tarihi kısmını boş bırakmayınız", "Eksik doldurdunuz", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Anne ismi kısmını boş bırakmayınız", "Eksik doldurdunuz", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Baba ismi kısmını boş bırakmayınız", "Eksik doldurdunuz", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (string.IsNullOrEmpty(maskedTextBox3.Text) || string.IsNullOrWhiteSpace(maskedTextBox3.Text))
                {
                    MessageBox.Show("Telefon numarası kısmını boş bırakmayınız", "Eksik doldurdunuz", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    MessageBox.Show("Adres kısmını boş bırakmayınız", "Eksik doldurdunuz", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }   
                else if (listBox1.Items.Count == 0)
                {
                    MessageBox.Show("Şikayet kısmını  kısmını boş bırakmayınız", "Eksik doldurdunuz", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (comboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show(" kısmını boş bırakmayınız", "Eksik doldurdunuz", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (!maskedTextBox1.MaskFull)
                {
                    MessageBox.Show("TC kimlik kısmını yarım bırakmayınız","Eksik doldurdunuz",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                }
                else if (!maskedTextBox2.MaskFull)
                {
                    MessageBox.Show("Doğum tarihi kısmını yarım bırakmayınız", "Eksik doldurdunuz", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (!maskedTextBox3.MaskFull)
                {
                    MessageBox.Show("Hasta telefon kısmını yarım bırakmayınız", "Eksik doldurdunuz", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                else
                {
                    string cin = "";
                    string si = "";
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        si += listBox1.Items[i].ToString();
                    }
                    if (radioButton1.Checked)
                    {
                        cin = "Erkek";
                    }
                    else if (radioButton2.Checked)
                    {
                        cin = "Kadın";
                    }

                    string sorgu = "INSERT INTO hasta (hastaAd, hastaSoyad, hastaTC, hastaCinsiyet, hastaDT, hastaAnnead, hastaBabaad, hastaTN, hastaSikayetleri, hastaAP, hastaAdres) " +
                        "VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + maskedTextBox1.Text + "', '" + cin + "', '" +
                        maskedTextBox2.Text + "', '" + textBox4.Text + "', '" + textBox3.Text + "', '" + maskedTextBox3.Text + "', '" +
                        si + "', '" + comboBox2.Text + "', '" + textBox5.Text + "')";

                    MySqlConnection bag = new MySqlConnection("Server = localhost ; Uid = root ; Pwd = 1234 ; Database =hastane");
                    MySqlCommand komut = new MySqlCommand(sorgu,bag);
                    DialogResult cevap;
                    cevap = MessageBox.Show(textBox1.Text +" "+ textBox2.Text+" Adlı hasta\r\nkaydedilsin mi?","Kayıt onay",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes)
                    {
                        bag.Open();
                        komut.ExecuteNonQuery();
                        bag.Close();
                        MessageBox.Show("Hasta başarıyla kaydedilmiştir","İşlem başaralı");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        maskedTextBox1.Clear();
                        maskedTextBox2.Clear();
                        maskedTextBox3.Clear();
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        listBox1.Items.Clear();
                        comboBox1.SelectedIndex = -1;
                        comboBox2.SelectedIndex = -1;
                        listeleme();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir şeyler yolunda gitmedi \r\n"+ex.Message);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

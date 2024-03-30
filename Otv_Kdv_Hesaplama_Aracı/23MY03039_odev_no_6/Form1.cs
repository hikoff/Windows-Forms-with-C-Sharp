using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23MY03039_odev_no_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool binaltiYuz = false;
        bool binaltiYuz_Iki = false;
        bool ikiUzeri = false;

        bool motIkigecme = false;
        bool motIkigecen = false;

        double AracFiyat = 0;
        double AracKDV = 0;
        double AracOTV = 0;
        double AracTop = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Otomobil")
            {
                comboBox3.SelectedItem = null;
                comboBox4.SelectedItem = null;

                label3.Enabled = true;
                comboBox2.Enabled = true;

                label5.Enabled = false;
                comboBox3.Enabled = false;

                label6.Enabled = false;
                comboBox4.Enabled = false;
            }
            else if (comboBox1.Text == "Motosiklet")
            {
                comboBox3.SelectedItem = null;
                comboBox4.SelectedItem = null;

                label3.Enabled = true;
                comboBox2.Enabled = true;

                label5.Enabled = false;
                comboBox3.Enabled = false;

                label6.Enabled = false;
                comboBox4.Enabled = false;
            }
            else if (comboBox1.Text == "Otobüs")
            {
                comboBox2.SelectedItem = null;
                comboBox3.SelectedItem = null;
                comboBox4.SelectedItem = null;

                label3.Enabled = false;
                comboBox2.Enabled = false;

                label5.Enabled = false;
                comboBox3.Enabled = false;

                label6.Enabled = false;
                comboBox4.Enabled = false;
            }
            else if (comboBox1.Text == "Midibüs")
            {
                comboBox2.SelectedItem = null;
                comboBox3.SelectedItem = null;
                comboBox4.SelectedItem = null;

                label3.Enabled = false;
                comboBox2.Enabled = false;

                label5.Enabled = false;
                comboBox3.Enabled = false;

                label6.Enabled = false;
                comboBox4.Enabled = false;
            }
            else if (comboBox1.Text == "Minibüs")
            {
                comboBox2.SelectedItem = null;
                comboBox3.SelectedItem = null;
                comboBox4.SelectedItem = null;

                label3.Enabled = true;
                comboBox2.Enabled = true;

                label5.Enabled = false;
                comboBox3.Enabled = false;

                label6.Enabled = false;
                comboBox4.Enabled = false;
            }
            else if (comboBox1.Text == "Hibrit Otomobil")
            {
                comboBox2.SelectedItem = null;
                comboBox4.SelectedItem = null;

                label5.Enabled = true;
                comboBox3.Enabled = true;

                label3.Enabled = false;
                comboBox2.Enabled = false;
            }
            else if (comboBox1.Text == "Elektrikli Otomobil")
            {
                comboBox2.SelectedItem = null;
                comboBox3.SelectedItem = null;

                label6.Enabled = true;
                comboBox4.Enabled = true;

                label5.Enabled = false;
                comboBox3.Enabled = false;

                label3.Enabled = false;
                comboBox2.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Otomobil");
            comboBox1.Items.Add("Motosiklet");
            comboBox1.Items.Add("Otobüs");
            comboBox1.Items.Add("Midibüs");
            comboBox1.Items.Add("Minibüs");
            comboBox1.Items.Add("Hibrit Otomobil");
            comboBox1.Items.Add("Elektrikli Otomobil");


            comboBox2.Items.Add("1600 cm³e kadar");
            comboBox2.Items.Add("1601 cm³ ile 2000cm³ arası");
            comboBox2.Items.Add("2001 cm³ üzeri");
            comboBox2.Items.Add("-Alt Taraf Motosiklet için-");
            comboBox2.Items.Add("250 cm³'ü geçmeyen");
            comboBox2.Items.Add("250 cm³'ü geçen");

            comboBox3.Items.Add("50 kW'ı geçip, 1800 cm³'ü geçmeyen");
            comboBox3.Items.Add("100 kW'ı geçip, 2500 cm3'ü geçmeyen");
            comboBox3.Items.Add("100 kW’ı geçip, 2000 cm³'- 2500 cm³ arasında");
            comboBox3.Items.Add("Diğer");

            comboBox4.Items.Add("160 kW altı");
            comboBox4.Items.Add("160 kW üzeri");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen Araç Türünü Seçin");
            }
            else if (comboBox1.Text == "Otomobil")
            {
                if (textBox1.Text == "" && comboBox2.Text == "")
                    MessageBox.Show("Lütfen Değerleri Tamamlayın");
                else if (textBox1.Text == "")
                    MessageBox.Show("Lütfen Aracın Ham Fiyatını Girin");
                else if (comboBox2.Text == "")
                    MessageBox.Show("Lütfen Motor Hacmini seçin");
                else
                {
                    AracFiyat = Convert.ToDouble(textBox1.Text);
                    if (comboBox2.Text == "1600 cm³e kadar")
                        binaltiYuz = true;
                    else if (comboBox2.Text == "1601 cm³ ile 2000cm³ arası")
                        binaltiYuz_Iki = true;
                    else if (comboBox2.Text == "2001 cm³ üzeri")
                        ikiUzeri = true;
                }
            }
            else if (comboBox1.Text == "Motosiklet")
            {
                if (textBox1.Text == "" && comboBox2.Text == "")
                    MessageBox.Show("Lütfen iki Değeri Girin");
                else if (textBox1.Text == "")
                    MessageBox.Show("Lütfen Aracın Ham Fiyatını Girin");
                else if (comboBox2.Text == "")
                    MessageBox.Show("Lütfen Motor Hacmini girin");
                else
                {
                    AracFiyat = Convert.ToDouble(textBox1.Text);
                    if (comboBox2.Text == "250 cm³'ü geçmeyen")
                        motIkigecme = true;
                    else if (comboBox2.Text == "250 cm³'ü geçen")
                        motIkigecen = true;

                }
            }
            else if (comboBox1.Text == "Otobüs")
            {
                if (textBox1.Text == "")
                    MessageBox.Show("Lütfen Aracın Ham Fiyatını Girin");
                else
                    AracFiyat = Convert.ToDouble(textBox1.Text);
            }
            else if (comboBox1.Text == "Midibüs")
            {
                if (textBox1.Text == "")
                    MessageBox.Show("Lütfen Aracın Ham Fiyatını Girin");
                else
                    AracFiyat = Convert.ToDouble(textBox1.Text);

            }
            else if (comboBox1.Text == "Minibüs")
            {
                if (textBox1.Text == "")
                    MessageBox.Show("Lütfen Aracın Ham Fiyatını Girin");
                else
                {
                    AracFiyat = Convert.ToDouble(textBox1.Text);

                }
            }
            else if (comboBox1.Text == "Hibrit Otomobil")
            {
                if (comboBox3.Text == "" && textBox1.Text == "")
                    MessageBox.Show("Lütfen Değerleri Girin");
                else if (textBox1.Text == "")
                    MessageBox.Show("Lütfen Aracın Ham Fiyatını Girin");
                else if (comboBox3.Text == "")
                    MessageBox.Show("Lütfen Elektrik Motorunun Gücünü Seçin");
                else
                    AracFiyat = Convert.ToDouble(textBox1.Text);

            }
            else if (comboBox1.Text == "Elektrikli Otomobil")
            {
                if (textBox1.Text == "" && comboBox4.Text == "")
                    MessageBox.Show("Lütfen Değerleri Girin");
                else if (textBox1.Text == "")
                    MessageBox.Show("Lütfen Aracın Ham Fiyatını Girin");
                else if (comboBox4.Text == "")
                    MessageBox.Show("Lütfen Lütfen Elektrik Motorunun Gücünü Seçin");
                else
                    AracFiyat = Convert.ToDouble(textBox1.Text);
            }


            //Otomobil
            if (comboBox1.Text == "Otomobil" && AracFiyat < 184000 && binaltiYuz == true)
            {
                AracOTV = (AracFiyat * 0.45);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }
            else if (comboBox1.Text == "Otomobil" && AracFiyat >= 184000 && AracFiyat < 220000 && binaltiYuz == true)
            {
                AracOTV = (AracFiyat * 0.50);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }
            else if (comboBox1.Text == "Otomobil" && AracFiyat >= 220000 && AracFiyat < 250000 && binaltiYuz == true)
            {
                AracOTV = (AracFiyat * 0.60);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }
            else if (comboBox1.Text == "Otomobil" && AracFiyat >= 250000 && AracFiyat < 280000 && binaltiYuz == true)
            {
                AracOTV = (AracFiyat * 0.70);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }
            else if (comboBox1.Text == "Otomobil" && AracFiyat >= 280000 && binaltiYuz == true)
            {
                AracOTV = (AracFiyat * 0.80);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }
            else if (comboBox1.Text == "Otomobil" && AracFiyat < 170000 && binaltiYuz_Iki == true)
            {
                AracOTV = (AracFiyat * 1.3);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }
            else if (comboBox1.Text == "Otomobil" && AracFiyat >= 170000 && binaltiYuz_Iki == true)
            {
                AracOTV = (AracFiyat * 1.5);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }
            else if (comboBox1.Text == "Otomobil" && ikiUzeri == true)
            {
                AracOTV = (AracFiyat * 2.2);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }

            //Motosiklet
            if (comboBox1.Text == "Motosiklet" && comboBox2.Text == "250 cm³'ü geçmeyen" && motIkigecme == true)
            {
                AracOTV = (AracFiyat * 0.08);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }
            else if (comboBox1.Text == "Motosiklet" && comboBox2.Text == "250 cm³'ü geçen" && motIkigecen == true)
            {
                AracOTV = (AracFiyat * 0.37);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }

            //Otobüs,Midibüs,Minibüs
            if (comboBox1.Text == "Otobüs")
            {
                AracOTV = (AracFiyat * 0.01);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }
            else if (comboBox1.Text == "Midibüs")
            {
                AracOTV = (AracFiyat * 0.04);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }
            else if (comboBox1.Text == "Minibüs")
            {
                AracOTV = (AracFiyat * 0.09);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }

            //Hibrit
            if (comboBox1.Text == "Hibrit Otomobil" && comboBox3.Text == "50 kW'ı geçip, 1800 cm³'ü geçmeyen" && AracFiyat < 228000)
            {
                AracOTV = (AracFiyat * 0.45);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);

                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }
            else if (comboBox1.Text == "Hibrit Otomobil" && comboBox3.Text == "50 kW'ı geçip, 1800 cm³'ü geçmeyen" && AracFiyat >= 228000 && AracFiyat < 350000)
            {
                AracOTV = (AracFiyat * 0.50);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }
            else if (comboBox1.Text == "Hibrit Otomobil" && comboBox3.Text == "50 kW'ı geçip, 1800 cm³'ü geçmeyen" && AracFiyat >= 350000)
            {
                AracOTV = (AracFiyat * 0.80);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }
            else if (comboBox1.Text == "Hibrit Otomobil" && comboBox3.Text == "100 kW’ı geçip, 2000 cm³'- 2500 cm³ arasında" && AracFiyat < 170000)
            {
                AracOTV = (AracFiyat * 1.30);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }
            else if (comboBox1.Text == "Hibrit Otomobil" && comboBox3.Text == "100 kW'ı geçip, 2500 cm3'ü geçmeyen")
            {
                AracOTV = (AracFiyat * 1.50);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }
            else if (comboBox1.Text == "Hibrit Otomobil" && comboBox3.Text == "Diğer")
            {
                AracOTV = (AracFiyat * 2.2);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }


            //elektrik
            if (comboBox1.Text == "Elektrikli Otomobil" && comboBox4.Text == "160 kW altı" && AracFiyat < 700000)
            {
                AracOTV = (AracFiyat * 0.1);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }
            else if (comboBox1.Text == "Elektrikli Otomobil" && comboBox4.Text == "160 kW altı" && AracFiyat >= 700000)
            {
                AracOTV = (AracFiyat * 0.4);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracFiyat);
                textBox6.Text = Convert.ToString(AracKDV);
            }
            else if (comboBox1.Text == "Elektrikli Otomobil" && comboBox4.Text == "160 kW üzeri" && AracFiyat < 750000)
            {
                AracOTV = (AracFiyat * 0.5);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }
            else if (comboBox1.Text == "Elektrikli Otomobil" && comboBox4.Text == "160 kW üzeri" && AracFiyat >= 750000)
            {
                AracOTV = (AracFiyat * 0.6);
                AracKDV = (AracFiyat + AracOTV) * 0.2;
                AracTop = Math.Round(AracOTV + AracKDV + AracFiyat);
                textBox2.Text = Convert.ToString(AracTop);
                textBox5.Text = Convert.ToString(AracOTV);
                textBox6.Text = Convert.ToString(AracKDV);
            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

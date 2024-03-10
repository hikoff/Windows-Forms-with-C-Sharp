using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alan_Cevre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double uzunKenar = Convert.ToDouble(textBox1.Text);
            double kisaKenar = Convert.ToDouble(textBox2.Text);

            if (radioButton4.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("Lütfen İşlem Yapmak İstediğiniz Uzunluk Türünü Seçin.");
            }
            else
            {
                if (radioButton1.Checked==false && radioButton2.Checked==false)
                {
                    MessageBox.Show("Lütfen İstenilen Değeri Seçin.");
                }
                else
                {
                    if (radioButton1.Checked == true)
                    {
                        double dikAlan = uzunKenar * kisaKenar;
                        string dikA = Convert.ToString(dikAlan);
                        //Label sıfırlama
                        if (label3.Text == "___")
                            label3.Text = "";
                        else
                            label3.Text = "";


                        if (radioButton4.Checked == true)
                            label3.Text = "Alanı= " + dikA + "cm";
                        else
                            label3.Text = "Alanı= " + dikA + "m";
                    }

                    if (radioButton2.Checked == true)
                    {
                        double dikCevre = 2 * (uzunKenar + kisaKenar);
                        string dikC = Convert.ToString(dikCevre);
                        //Label sıfırlama
                        if (label3.Text == "___")
                            label3.Text = "";
                        else
                            label3.Text = "";


                        if (radioButton4.Checked == true)

                            label3.Text = "Alanı= " + dikC + "cm";
                        else
                            label3.Text = "Alanı= " + dikC + "m";
                    }
                
                
                
                
                }
            }













        }
    }
}

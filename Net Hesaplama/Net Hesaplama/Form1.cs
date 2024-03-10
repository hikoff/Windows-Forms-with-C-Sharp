using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net_Hesaplama
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
            double toplamNet=0;
            double matDoru = Convert.ToInt32(textBox10.Text);
            double matYanlis = Convert.ToInt32(textBox9.Text);

            double matBos;


            if (textBox8.Text == "")
            matBos = 0;
            else
            matBos=Convert.ToInt32(textBox8.Text);


            if (matDoru + matYanlis+matBos==40)
            {
                double matNet = matDoru - (matYanlis / 4);
                toplamNet += matNet;
            }else
            {
                MessageBox.Show("Soru Sayısını Düzelt");
            }

            double turkceDoru = Convert.ToInt32(textBox1.Text);
            double turkceYanlis = Convert.ToInt32(textBox2.Text);

            double turkceBos;
            

            if (textBox11.Text=="")
            turkceBos = 0;
            else
            turkceBos=Convert.ToInt32(textBox11.Text);


            if (turkceDoru + turkceYanlis+turkceBos == 40)
            {
                double turkceNet = turkceDoru - (turkceYanlis / 4);
                toplamNet += turkceNet;
            }
            else
            {
                MessageBox.Show("Soru Sayısını Düzelt");
            }

            double sosyalDoru = Convert.ToInt32(textBox3.Text);
            double sosyalYanlis = Convert.ToInt32(textBox4.Text);

            double sosyalBos;


            if (textBox12.Text == "")
                sosyalBos = 0;
            else
                sosyalBos = Convert.ToInt32(textBox12.Text);


            if (sosyalDoru + sosyalYanlis+sosyalBos == 20)
            {
                double sosyalNet = sosyalDoru - (sosyalYanlis / 4);
                toplamNet += sosyalNet;
            }
            else
            {
                MessageBox.Show("Soru Sayısını Düzelt");
            }


            double fenDoru = Convert.ToInt32(textBox5.Text);
            double fenYanlis = Convert.ToInt32(textBox6.Text);

            double fenBos;


            if (textBox13.Text == "")
                fenBos = 0;
            else
                fenBos = Convert.ToInt32(textBox13.Text);


            if (fenDoru + fenYanlis + fenBos == 20)
            {
                double fenNet = fenDoru - (fenYanlis / 4);
                toplamNet += fenNet;
            }
            else
            {
                MessageBox.Show("Soru Sayısını Düzelt");
            }



            textBox7.Text = Convert.ToString(toplamNet);

        }
    }
}

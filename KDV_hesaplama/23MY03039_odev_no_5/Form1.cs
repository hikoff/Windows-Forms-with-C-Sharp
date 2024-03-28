using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23MY03039_odev_no_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double altutar=0;
            bool kont = false;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Alışveriş Tutarını Girin");
            }
            else
            {
                kont = true;
                altutar = Convert.ToDouble(textBox1.Text);
            }
            if (kont == true && altutar < 0)
            {
                MessageBox.Show("Girdiğin Sayıyı Düzelt😡");
            }
            else if (kont == true && checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                MessageBox.Show("Lütfen Ürün Türünü Seçin");
            }
            else
            {
                if (checkBox1.Checked == true)
                {
                    label2.Font = new Font("Times New Roman", 12);
                    double kdv = altutar * 1 / 100;
                    altutar = altutar + kdv;
                    altutar = Math.Round(altutar, 2);
                    label2.Text = altutar.ToString();
                }
                else if (checkBox2.Checked == true)
                {

                    label2.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                    double kdv = altutar * 10 / 100;
                    altutar += kdv;
                    altutar = Math.Round(altutar, 2);
                    label2.Text = altutar.ToString();
                }
                else if (checkBox3.Checked == true)
                {

                    label2.Font = new Font("Times New Roman", 12, FontStyle.Italic);
                    double kdv = altutar * 20 / 100;
                    altutar += kdv;
                    altutar = Math.Round(altutar, 2);
                    label2.Text = altutar.ToString();
                }
            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
        }
    }
}

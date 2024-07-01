using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);

            if (sayi<20)
            {
                Sonuc.Text = "Sayı 20'den Küçüktür";
                Sonuc.ForeColor = Color.Red;
            }
            else if (sayi>20)
            {
                Sonuc.Text = "Sayı 20'den Büyüktür.";
                Sonuc.ForeColor = Color.Blue;
            }
            else if (sayi==20)
            {
                Sonuc.Text = "Sayı 20'ye Eşittir.";
                Sonuc.ForeColor = Color.Black;
            }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


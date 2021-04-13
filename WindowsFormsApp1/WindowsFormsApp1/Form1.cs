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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int output))
            {
                label2.ForeColor = Color.SpringGreen;
                string euro = "€";
                float strahovka, pensioon, palk, tulumaks, palk2;
                string arv1 = textBox1.Text;
                int b = int.Parse(arv1);
                int year = b * 12;
                if (year <= 6000)
                {
                    pensioon = b * 2f / 100;
                    strahovka = b * 1.6f / 100;
                    palk = b - (pensioon + strahovka);
                    label2.Text = palk + euro;
                }
                if (year > 6000)
                {
                    pensioon = b * 2f / 100;
                    strahovka = b * 1.6f / 100;
                    tulumaks = (b - 500 - pensioon - strahovka) * 0.2f;
                    palk = (b - tulumaks - pensioon - strahovka);
                    label2.Text = palk + euro;
                }
                if (year >= 14400)
                {
                    pensioon = b * 2f / 100;
                    strahovka = b * 1.6f / 100;
                    tulumaks = (6000 - ((year - 14400) * 0.55556f)) / 12;
                    palk = (b - tulumaks - pensioon - strahovka) * 0.2f;
                    palk2 = (b - palk - pensioon - strahovka);
                    label2.Text = palk2 + euro;
                }
                if (year >= 25200)
                {
                    pensioon = b * 2f / 100;
                    strahovka = b * 1.6f / 100;
                    tulumaks = 0;
                    palk = (b - tulumaks - pensioon - strahovka) * 0.2f;
                    palk2 = (b - palk - pensioon - strahovka);
                    label2.Text = palk2 + euro;
                }
            }
            else
            {
                textBox1.Text = "";
                label2.ForeColor = Color.Red;
                label2.Text = "error";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}

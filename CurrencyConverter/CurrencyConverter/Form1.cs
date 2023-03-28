using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBox1.Text);
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                amount = amount * 1;
                label5.Text = amount.ToString() + "$";
            }
            if (comboBox1.SelectedIndex==0 && comboBox2.SelectedIndex==1)
            {
                amount = amount * 0.93;
                label5.Text = amount.ToString() + "€";
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                amount = amount * 19;
                label5.Text = amount.ToString() + "TL";
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                amount = amount * 1.07;
                label5.Text = amount.ToString() + "$";
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
            {
                amount = amount * 1;
                label5.Text = amount.ToString() + "€";
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
            {
                amount = amount * 20;
                label5.Text = amount.ToString() + "TL";
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                amount = amount * 0.053;
                label5.Text = amount.ToString() + "$";
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
            {
                amount = amount * 0.05;
                label5.Text = amount.ToString() + "€";
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 2)
            {
                amount = amount * 1;
                label5.Text = amount.ToString() + "TL";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.xe.com/currencyconverter/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://onurtotos.com/");
        }
 
    }
}

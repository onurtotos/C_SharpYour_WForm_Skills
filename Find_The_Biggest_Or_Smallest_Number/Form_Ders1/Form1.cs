using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Ders1
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
            int sayi1, sayi2, sayi3, enkucuk, enbuyuk;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sayi3 = Convert.ToInt32(textBox3.Text);
           

            //Find the biggest number
            if (sayi1>sayi2 && sayi1 > sayi3)
            {
                enbuyuk = sayi1;
            } else if (sayi2>sayi1 && sayi2 > sayi3)
            {
                enbuyuk = sayi2;
            }
            else
            {
                enbuyuk = sayi3;
            }

            //Find the smallest number
            if (sayi1 < sayi2 && sayi1 < sayi3)
            {
                enkucuk = sayi1;
            }
            else if (sayi2 < sayi1 && sayi2 < sayi3)
            {
                enkucuk = sayi2;
            }
            else
            {
                enkucuk = sayi3;
            }

            textBox4.Text = enbuyuk.ToString();
            textBox5.Text = enkucuk.ToString();
        }
    }
}

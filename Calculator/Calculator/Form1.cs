using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double optionS = 0;
        double number1, number2, results;
       
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void Butonlar(object sender, EventArgs e)
        {
            
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "";
            }
            txtdisplay.Text = txtdisplay.Text + ((Button)sender).Text;
           
        }

        private void btnarti_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtdisplay.Text);
            optionS = 1.0;
            txtdisplay.Text = "";
        }

        private void btneksi_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtdisplay.Text);
            optionS = 2.0;
            txtdisplay.Text = "0";
        }

        private void btncarpi_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtdisplay.Text);
            optionS = 3.0;
            txtdisplay.Text = "0";
        }

        private void btnbolu_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtdisplay.Text);
            optionS = 4.0;
            txtdisplay.Text = "0";
        }

        private void btnesittir_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(txtdisplay.Text);
            if (number2==0.0)
            {
                
                MessageBox.Show("0 a bolumler tanimsizdir");
                
            }
            if (optionS==1.0)
            {
                results = number1 + number2;
            }
            txtdisplay.Text = results.ToString();
            if (optionS == 2.0)
            {
                results = number1 - number2;
            }
            txtdisplay.Text = results.ToString();
            if (optionS == 3.0)
            {
                results = number1 * number2;
            }
            txtdisplay.Text = results.ToString();
            if (optionS == 4.0)
            {
                results = number1/number2;
            }
            txtdisplay.Text = results.ToString();
          
            
          

        }

        private void btnvirgul_Click(object sender, EventArgs e)
        { 

           txtdisplay.Text += ".";
            
        }

        private void btneksiarti_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text != "0")
            {
                if (txtdisplay.Text.StartsWith("-"))
                {
                    txtdisplay.Text = txtdisplay.Text.Replace("-","");
                }
                else if (txtdisplay.Text.StartsWith(""))
                {
                    txtdisplay.Text = "-" + txtdisplay.Text;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtdisplay.Text);
            optionS = 5.0;
            txtdisplay.Text = "0";
            txtdisplay.Text = Math.Pow(number1, 2.0).ToString();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtdisplay.Text);
            optionS = 6.0;
            txtdisplay.Text = "0";
            txtdisplay.Text = Math.Exp(number1).ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtdisplay.Text);
            optionS = 7.0;
            txtdisplay.Text = "0";
            txtdisplay.Text = Math.Sqrt(number1).ToString();
            
        }


        private void btnsil_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "0";
        }

        private void btnbckspc_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text.Substring(0, txtdisplay.Text.Length - 1);
            if (txtdisplay.Text =="")
            {
                txtdisplay.Text ="0";
            }
        }
    }
}

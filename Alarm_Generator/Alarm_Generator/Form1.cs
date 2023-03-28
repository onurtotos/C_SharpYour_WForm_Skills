using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SoundPlayer soundPlayer = new SoundPlayer();
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = "Your Alarm has created.";
            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            DateTime alarmTime = dateTimePicker1.Value;

            if (dateTime.Hour==alarmTime.Hour && dateTime.Minute==alarmTime.Minute)
            {
                timer1.Stop();
                label2.Text = "Alarm is ringing";

             //here you need to put the path of the music that you would like to use in this application.
                soundPlayer.SoundLocation =@"C:\Users\onurt\Desktop\file_example_WAV_1MG.wav";


                soundPlayer.PlayLooping();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            label2.Text = "Alarm stopped";
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button1.Enabled==false)
            {
                soundPlayer.Stop();
                button1.Enabled = true;
                label2.Text = "...";

            }
               
        }
    }
}

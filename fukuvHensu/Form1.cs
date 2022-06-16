using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuvHensu
{
    public partial class Form1 : Form
    {
        int vx;
        int vy;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("齋藤麗也");
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = -5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx = -5;
            vy = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vx = 5;
            vy = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = 5;
            }
            else if (label1.Top < 0)
            {
                vy = 5;
            }
            else if (label1.Left > ClientSize.Width)
            {
                vx = -5;
            }
            else if (label1.Top > ClientSize.Height)
            {
                vy = -5;
            }
        }
    }
}

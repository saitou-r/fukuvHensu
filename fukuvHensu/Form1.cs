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
            vy = -2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx = -2;
            vy = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vx = 2;
            vy = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
        }
    }
}

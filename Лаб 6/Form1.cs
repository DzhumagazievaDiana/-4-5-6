using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime time1 = new DateTime(0, 0);
        private void timer1_Tick(object sender, EventArgs e)
        {
            time1 = time1.AddSeconds(1);
            textBox1.Text = time1.ToString("mm");
            textBox2.Text = time1.ToString("ss");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
          


    
}

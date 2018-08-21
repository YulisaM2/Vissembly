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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 1000000;
            progressBar1.Step = 1000;
            timer1.Interval = 1;
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {


             progressBar1.PerformStep();
            if(progressBar1.Value == 1000000)
            {
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.Show();
                timer1.Stop();
            }
            
        }

        }
    }



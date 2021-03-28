using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDate
{
    public partial class Form1 : Form
    {

        int i = 0;
        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Interval = 1000; // 1 sec
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           

            i++;

            if (i>3)
            {
                // move to form2 after 3 seconds

                this.Hide();
                Form2 frm2 = new Form2();
                frm2.Show();
                timer1.Stop();

            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}

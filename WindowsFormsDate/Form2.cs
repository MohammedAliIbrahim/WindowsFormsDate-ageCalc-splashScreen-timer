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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        string dateNow  =  DateTime.Now.ToString();

            label1.Text =  dateNow + " " +"تايخ اليوم";


        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            int yearOfBirth = int.Parse(textBox1.Text);
            int currentYear = DateTime.Now.Year;
            int age = currentYear - yearOfBirth;
            label3.Text = age.ToString();

        }
    }
}

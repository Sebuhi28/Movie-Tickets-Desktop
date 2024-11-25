using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csdesktop
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ad = maskedTextBox1.Text;
            string parol = maskedTextBox2.Text;
            if (ad == "sebuhi" && parol == "sebuhi123")
            {
                Form2 form2 = new Form2();
                form2.Show();

            }
            else
            {
                label3.Visible = true;
                label4.Visible = true;
            }
        }
    }

}

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
    public partial class Form2 : Form
    {
        int balance = 0;
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Visible = true;
            maskedTextBox1.Visible = true;
            label1.Text = $"Toplam məbləğ : {balance}azn";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            maskedTextBox1.Visible = true;
            int elave = int.Parse(maskedTextBox1.Text);
            balance += elave;
            label1.Text = $"Toplam məbləğ : {balance.ToString()}azn";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            maskedTextBox1.Visible = true;
            int çıxart = int.Parse(maskedTextBox1.Text);
            if(çıxart > balance)
            {
                label1.Text = $"Balansınızda kifatət qədər məbləğ yoxdur!";
            }
            else
            {
                balance -= çıxart;
                label1.Text = $"Toplam məbləğ : {balance.ToString()}azn";
            }
        }
    }
}

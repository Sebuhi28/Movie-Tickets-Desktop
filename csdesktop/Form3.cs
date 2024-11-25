using MessagingToolkit.QRCode.Codec;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        decimal totalprice = 0M;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"
                                Kod: 101 | Lays
                                Kod: 102 | Doritos
                                Kod: 103 | Pringles
            ");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] code = { "101", "102", "103" };
            string[] product = { "Lays", "Doritos", "Pringles" };
            decimal[] price = { 2.90M, 3.00M, 5.90M };


            if (textBox1.Text == code[0])
            {
                listBox1.Items.Add($"Kod: {code[0]} | Ad: {product[0]} | Qiymət: {price[0]}azn");
                totalprice = totalprice + price[0];
            }
            else if (textBox1.Text == code[1])
            {
                listBox1.Items.Add($"Kod: {code[1]} | Ad: {product[1]} | Qiymət: {price[1]}azn");
                totalprice = totalprice + price[1];
            }
            else if (textBox1.Text == code[2])
            {
                listBox1.Items.Add($"Kod: {code[2]} | Ad: {product[2]} | Qiymət: {price[2]}azn");
                totalprice = totalprice + price[2];
            }

            total.Text = totalprice.ToString() + " " + "azn";
            decimal edv = totalprice / 100;
            decimal per = edv * 18;

            QRCodeEncoder enc = new QRCodeEncoder();
            pictureBox1.Image = enc.Encode(per.ToString());
        }

        private void btnenter_Click(object sender, EventArgs e)
        {


            decimal qalıq = Convert.ToDecimal(textBox2.Text) - totalprice;
            decimal a = Convert.ToDecimal(totalprice);
            decimal b = Convert.ToDecimal(textBox2.Text);


            if (b >= a)
            {
                pay.Text = $"{b.ToString()} azn";
                returned.Text = $"{qalıq.ToString()} azn";
                error.Visible = false;
            }
            else
            {
                error.Visible = true;

            }
        }

        
    }
}

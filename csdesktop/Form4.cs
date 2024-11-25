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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        decimal total;

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form5 form5 = new Form5();
            form5.Show();


            string[] name = { "Thor", "Spider-Man", "Shang-Chi", "Ant-Man" };
            decimal[] price = { 25.99M, 20.99M, 24.99M, 26.99M };
            decimal[] discount = { 19.99M, 17.99M, 20.99M, 21.99M };
            

            if (numericUpDown1.Value > 0)
            {
                decimal result = numericUpDown1.Value * discount[0];
                form5.listBox1.Items.Add($"Movie: {name[0]} | Price: {price[0]} | Discount: {discount[0]} | Number: {numericUpDown1.Value} | Result: ${result}");
                
                total = total + result;
                form5.label2.Text= $"Total: {total}";
            }

            if (numericUpDown2.Value > 0)
            {
                decimal result = numericUpDown2.Value * discount[1];
                form5.listBox1.Items.Add($"Movie: {name[1]} | Price: {price[1]} | Discount: {discount[1]} | Number: {numericUpDown2.Value} | Result: ${result}");
                
                total = total + result;
                form5.label2.Text = $"Total: {total}";
            }

            if (numericUpDown3.Value > 0)
            {
                decimal result = numericUpDown3.Value * discount[2];
                form5.listBox1.Items.Add($"Movie: {name[2]} | Price: {price[2]} | Discount: {discount[2]} | Number: {numericUpDown3.Value} | Result: ${result}");
                
                total = total + result;
                form5.label2.Text = $"Total: {total}";
            }

            if (numericUpDown4.Value > 0)
            {
                decimal result = numericUpDown4.Value * discount[3];
                form5.listBox1.Items.Add($"Movie: {name[3]} | Price: ${price[3]} | Discount: ${discount[3]} | Number: {numericUpDown4.Value} | Result: ${result}");
                
                total = total + result;
                form5.label2.Text = $"Total: {total}";
            }
        }

        
    }
}

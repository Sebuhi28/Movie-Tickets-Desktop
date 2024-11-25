namespace csdesktop
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            total = new System.Windows.Forms.Label();
            pay = new System.Windows.Forms.Label();
            returned = new System.Windows.Forms.Label();
            error = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btn0 = new System.Windows.Forms.Button();
            btndot = new System.Windows.Forms.Button();
            btnx = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            btnenter = new System.Windows.Forms.Button();
            btn9 = new System.Windows.Forms.Button();
            btn8 = new System.Windows.Forms.Button();
            btn7 = new System.Windows.Forms.Button();
            btn6 = new System.Windows.Forms.Button();
            btn5 = new System.Windows.Forms.Button();
            btn4 = new System.Windows.Forms.Button();
            btn3 = new System.Windows.Forms.Button();
            btn2 = new System.Windows.Forms.Button();
            btn1 = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 23);
            label1.TabIndex = 0;
            label1.Text = "Məhsul kodu";
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(16, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(109, 30);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(140, 15);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(129, 29);
            button1.TabIndex = 2;
            button1.Text = "Kod siyahısı";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(141, 60);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(128, 29);
            button2.TabIndex = 3;
            button2.Text = "Əlavə et";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(456, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(140, 23);
            label2.TabIndex = 4;
            label2.Text = "Ümumi məbləğ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(443, 66);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(153, 23);
            label3.TabIndex = 6;
            label3.Text = "Ödənilən məbləğ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(432, 111);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(164, 23);
            label4.TabIndex = 7;
            label4.Text = "Qaytarılan məbləğ:";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            total.Location = new System.Drawing.Point(705, 21);
            total.Name = "total";
            total.Size = new System.Drawing.Size(77, 23);
            total.TabIndex = 8;
            total.Text = "0.00 azn";
            // 
            // pay
            // 
            pay.AutoSize = true;
            pay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            pay.Location = new System.Drawing.Point(705, 66);
            pay.Name = "pay";
            pay.Size = new System.Drawing.Size(77, 23);
            pay.TabIndex = 9;
            pay.Text = "0.00 azn";
            // 
            // returned
            // 
            returned.AutoSize = true;
            returned.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            returned.Location = new System.Drawing.Point(705, 111);
            returned.Name = "returned";
            returned.Size = new System.Drawing.Size(77, 23);
            returned.TabIndex = 10;
            returned.Text = "0.00 azn";
            // 
            // error
            // 
            error.AutoSize = true;
            error.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            error.ForeColor = System.Drawing.Color.Red;
            error.Location = new System.Drawing.Point(404, 152);
            error.Name = "error";
            error.Size = new System.Drawing.Size(378, 23);
            error.TabIndex = 11;
            error.Text = "Ödənilən məbləğ ümumi məbləğdən kiçikdir!";
            error.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn0);
            groupBox1.Controls.Add(btndot);
            groupBox1.Controls.Add(btnx);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(btnenter);
            groupBox1.Controls.Add(btn9);
            groupBox1.Controls.Add(btn8);
            groupBox1.Controls.Add(btn7);
            groupBox1.Controls.Add(btn6);
            groupBox1.Controls.Add(btn5);
            groupBox1.Controls.Add(btn4);
            groupBox1.Controls.Add(btn3);
            groupBox1.Controls.Add(btn2);
            groupBox1.Controls.Add(btn1);
            groupBox1.Location = new System.Drawing.Point(482, 209);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(300, 294);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btn0
            // 
            btn0.Location = new System.Drawing.Point(234, 183);
            btn0.Name = "btn0";
            btn0.Size = new System.Drawing.Size(45, 45);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btndot
            // 
            btndot.Location = new System.Drawing.Point(234, 130);
            btndot.Name = "btndot";
            btndot.Size = new System.Drawing.Size(45, 45);
            btndot.TabIndex = 12;
            btndot.Text = ",";
            btndot.UseVisualStyleBackColor = true;
            btndot.Click += btndot_Click;
            // 
            // btnx
            // 
            btnx.Location = new System.Drawing.Point(234, 74);
            btnx.Name = "btnx";
            btnx.Size = new System.Drawing.Size(45, 45);
            btnx.TabIndex = 11;
            btnx.Text = "x";
            btnx.UseVisualStyleBackColor = true;
            btnx.Click += btnx_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(21, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(258, 27);
            textBox2.TabIndex = 10;
            // 
            // btnenter
            // 
            btnenter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnenter.Location = new System.Drawing.Point(74, 238);
            btnenter.Name = "btnenter";
            btnenter.Size = new System.Drawing.Size(161, 39);
            btnenter.TabIndex = 9;
            btnenter.Text = "Hesablamaq";
            btnenter.UseVisualStyleBackColor = true;
            btnenter.Click += btnenter_Click;
            // 
            // btn9
            // 
            btn9.Location = new System.Drawing.Point(158, 183);
            btn9.Name = "btn9";
            btn9.Size = new System.Drawing.Size(45, 45);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new System.Drawing.Point(88, 183);
            btn8.Name = "btn8";
            btn8.Size = new System.Drawing.Size(45, 45);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new System.Drawing.Point(21, 183);
            btn7.Name = "btn7";
            btn7.Size = new System.Drawing.Size(45, 45);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Location = new System.Drawing.Point(158, 130);
            btn6.Name = "btn6";
            btn6.Size = new System.Drawing.Size(45, 45);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new System.Drawing.Point(88, 130);
            btn5.Name = "btn5";
            btn5.Size = new System.Drawing.Size(45, 45);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new System.Drawing.Point(21, 130);
            btn4.Name = "btn4";
            btn4.Size = new System.Drawing.Size(45, 45);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Location = new System.Drawing.Point(158, 74);
            btn3.Name = "btn3";
            btn3.Size = new System.Drawing.Size(45, 45);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Location = new System.Drawing.Point(88, 74);
            btn2.Name = "btn2";
            btn2.Size = new System.Drawing.Size(45, 45);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Location = new System.Drawing.Point(21, 74);
            btn1.Name = "btn1";
            btn1.Size = new System.Drawing.Size(45, 45);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new System.Drawing.Point(16, 223);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(311, 284);
            listBox1.TabIndex = 13;
            
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(284, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(89, 72);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 526);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(error);
            Controls.Add(returned);
            Controls.Add(pay);
            Controls.Add(total);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label pay;
        private System.Windows.Forms.Label returned;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
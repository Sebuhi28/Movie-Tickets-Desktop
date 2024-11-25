namespace csdesktop
{
    partial class Form2
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button1.Location = new System.Drawing.Point(12, 52);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(292, 75);
            button1.TabIndex = 0;
            button1.Text = "Məbləği Göstər";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button2.Location = new System.Drawing.Point(762, 52);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(292, 75);
            button2.TabIndex = 1;
            button2.Text = "Məbləği Çək";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button3.Location = new System.Drawing.Point(12, 194);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(292, 75);
            button3.TabIndex = 2;
            button3.Text = "Məbləği Əlavə Et";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button4.Location = new System.Drawing.Point(759, 194);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(295, 75);
            button4.TabIndex = 3;
            button4.Text = "Əməliyyatı dayandır";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new System.Drawing.Point(360, 447);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new System.Drawing.Size(234, 27);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(360, 414);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(121, 20);
            label1.TabIndex = 7;
            label1.Text = "Toplam Məbləğ :";
            label1.Visible = false;
            
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1066, 629);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
    }
}
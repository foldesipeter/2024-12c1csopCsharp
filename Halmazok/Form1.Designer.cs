namespace Halmazok
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGeneral = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            listBox5 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // btnGeneral
            // 
            btnGeneral.Location = new Point(295, 347);
            btnGeneral.Name = "btnGeneral";
            btnGeneral.Size = new Size(75, 23);
            btnGeneral.TabIndex = 0;
            btnGeneral.Text = "Generálj";
            btnGeneral.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(43, 347);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(169, 347);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(43, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 229);
            listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(183, 32);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 229);
            listBox2.TabIndex = 7;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(318, 32);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 229);
            listBox3.TabIndex = 8;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(465, 32);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(120, 229);
            listBox4.TabIndex = 9;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 15;
            listBox5.Location = new Point(603, 32);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(120, 229);
            listBox5.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox5);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(btnGeneral);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGeneral;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListBox listBox5;
    }
}

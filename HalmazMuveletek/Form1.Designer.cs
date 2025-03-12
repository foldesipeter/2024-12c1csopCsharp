namespace HalmazMuveletek
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
            numericUpDownA = new NumericUpDown();
            numericUpDownB = new NumericUpDown();
            A_halmaz = new ListBox();
            B_halmaz = new ListBox();
            A_unio_B = new ListBox();
            A_metszet_B = new ListBox();
            A_B = new ListBox();
            B_A = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).BeginInit();
            SuspendLayout();
            // 
            // btnGeneral
            // 
            btnGeneral.Location = new Point(293, 308);
            btnGeneral.Name = "btnGeneral";
            btnGeneral.Size = new Size(75, 23);
            btnGeneral.TabIndex = 0;
            btnGeneral.Text = "Generálj";
            btnGeneral.UseVisualStyleBackColor = true;
            btnGeneral.Click += btnGeneral_Click;
            // 
            // numericUpDownA
            // 
            numericUpDownA.Location = new Point(41, 308);
            numericUpDownA.Name = "numericUpDownA";
            numericUpDownA.Size = new Size(120, 23);
            numericUpDownA.TabIndex = 1;
            // 
            // numericUpDownB
            // 
            numericUpDownB.Location = new Point(167, 308);
            numericUpDownB.Name = "numericUpDownB";
            numericUpDownB.Size = new Size(120, 23);
            numericUpDownB.TabIndex = 2;
            // 
            // A_halmaz
            // 
            A_halmaz.FormattingEnabled = true;
            A_halmaz.ItemHeight = 15;
            A_halmaz.Location = new Point(17, 24);
            A_halmaz.Name = "A_halmaz";
            A_halmaz.Size = new Size(120, 94);
            A_halmaz.TabIndex = 3;
            // 
            // B_halmaz
            // 
            B_halmaz.FormattingEnabled = true;
            B_halmaz.ItemHeight = 15;
            B_halmaz.Location = new Point(143, 24);
            B_halmaz.Name = "B_halmaz";
            B_halmaz.Size = new Size(120, 94);
            B_halmaz.TabIndex = 4;
            // 
            // A_unio_B
            // 
            A_unio_B.FormattingEnabled = true;
            A_unio_B.ItemHeight = 15;
            A_unio_B.Location = new Point(269, 24);
            A_unio_B.Name = "A_unio_B";
            A_unio_B.Size = new Size(120, 94);
            A_unio_B.TabIndex = 5;
            // 
            // A_metszet_B
            // 
            A_metszet_B.FormattingEnabled = true;
            A_metszet_B.ItemHeight = 15;
            A_metszet_B.Location = new Point(395, 24);
            A_metszet_B.Name = "A_metszet_B";
            A_metszet_B.Size = new Size(120, 94);
            A_metszet_B.TabIndex = 6;
            // 
            // A_B
            // 
            A_B.FormattingEnabled = true;
            A_B.ItemHeight = 15;
            A_B.Location = new Point(521, 24);
            A_B.Name = "A_B";
            A_B.Size = new Size(120, 94);
            A_B.TabIndex = 7;
            // 
            // B_A
            // 
            B_A.FormattingEnabled = true;
            B_A.ItemHeight = 15;
            B_A.Location = new Point(647, 24);
            B_A.Name = "B_A";
            B_A.Size = new Size(120, 94);
            B_A.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(B_A);
            Controls.Add(A_B);
            Controls.Add(A_metszet_B);
            Controls.Add(A_unio_B);
            Controls.Add(B_halmaz);
            Controls.Add(A_halmaz);
            Controls.Add(numericUpDownB);
            Controls.Add(numericUpDownA);
            Controls.Add(btnGeneral);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGeneral;
        private NumericUpDown numericUpDownA;
        private NumericUpDown numericUpDownB;
        private ListBox A_halmaz;
        private ListBox B_halmaz;
        private ListBox A_unio_B;
        private ListBox A_metszet_B;
        private ListBox A_B;
        private ListBox B_A;
    }
}

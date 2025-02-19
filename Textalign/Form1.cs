namespace Textalign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            int n = e.X / (label1.Width / 3); //vízszintes méret harmada
            int m = e.X / (label1.Height / 3); //függõleges méret harmada

            // A képernyõ 9 négyszögre van osztva és itt számolom ki, hogy hanyadik négyszögbekattintottam
            switch (m * 3 + n)
            {
                case 0: label1.TextAlign = ContentAlignment.TopLeft; break;
                case 1: label1.TextAlign = ContentAlignment.TopCenter; break;
                case 2: label1.TextAlign = ContentAlignment.TopRight; break;
                case 3: label1.TextAlign = ContentAlignment.MiddleLeft; break;
                case 4: label1.TextAlign = ContentAlignment.MiddleCenter; break;
                case 5: label1.TextAlign = ContentAlignment.MiddleRight; break;
                case 6: label1.TextAlign = ContentAlignment.BottomLeft; break;
                case 7: label1.TextAlign = ContentAlignment.BottomCenter; break;
                case 8: label1.TextAlign = ContentAlignment.BottomRight; break;


            }
        }
    }
}

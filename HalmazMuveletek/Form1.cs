using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms;

namespace HalmazMuveletek
{
    public partial class Form1 : Form
    {

        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneral_Click(object sender, EventArgs e)

        {

            int countA = (int)numericUpDownA.Value;

            int countB = (int)numericUpDownB.Value;

            HashSet<int> setA = GenerateSet(countA);

            HashSet<int> setB = GenerateSet(countB);

            A_halmaz.Items.Clear();

            B_halmaz.Items.Clear();

            A_unio_B.Items.Clear();

            A_metszet_B.Items.Clear();

            A_B.Items.Clear();

            B_A.Items.Clear();

            foreach (var item in setA)

                A_halmaz.Items.Add(item);

            foreach (var item in setB)

                B_halmaz.Items.Add(item);

            foreach (var item in setA.Union(setB))

                A_unio_B.Items.Add(item);

            foreach (var item in setA.Intersect(setB))

                A_metszet_B.Items.Add(item);

            foreach (var item in setA.Except(setB))

                A_B.Items.Add(item);

            foreach (var item in setB.Except(setA))

                B_A.Items.Add(item);

        }

        private HashSet<int> GenerateSet(int count)

        {
            HashSet<int> set = new HashSet<int>();

            while (set.Count < count)

            {

                set.Add(rand.Next(0, 10001));

            }

            return set;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

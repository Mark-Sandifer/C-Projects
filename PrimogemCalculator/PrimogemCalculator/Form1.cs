namespace PrimogemCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void blessingCheck_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void commissionCheck_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void abyssCheck_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pPP = 1;

            if (blessingCheck.Checked == true && commissionCheck.Checked == true)
            {
                pPP = 150;
            }
            else if (blessingCheck.Checked == true && commissionCheck.Checked == false)
            {
                pPP = 90;
            }
            else if (commissionCheck.Checked == true && blessingCheck.Checked == false)
            {
                pPP = 60;
            }

            int currentPrimos;
            if (int.TryParse(textBox1.Text, out currentPrimos) == false)
            {
                return;
            }

            int currentFates = 0;
            if (int.TryParse(textBox2.Text, out currentFates) == false)
            {
                return;
            }

            int currentTotalPrimo = currentPrimos + (currentFates * 160);
            int onePull = 14400;
            int twoPull = 28800;
            if (radioButton1.Checked == true)
            {
                if (currentTotalPrimo >= onePull)
                {
                    Console.WriteLine("You have enough!");
                    Environment.Exit(0);
                }
                labelTotal.Text = $"{BigCalc(onePull, currentTotalPrimo, pPP, abyssCheck.Checked)} days";
                //Console.WriteLine($"{BigCalc(onePull, currentTotalPrimo, pPP, abyssCheck.Checked)} days");
            }
            else if (radioButton2.Checked == true)
            {
                if (currentTotalPrimo >= twoPull)
                {
                    Console.WriteLine("You have enough!");
                    Environment.Exit(0);
                }
                labelTotal.Text = $"{BigCalc(twoPull, currentTotalPrimo, pPP, abyssCheck.Checked)} days";
                //Console.WriteLine($"{BigCalc(twoPull, currentTotalPrimo, pPP, abyssCheck.Checked)} days");
            }
        }

        public static int BigCalc(int pull, int cTP, int pPP, bool abyss)
        {
            int remainingCount = pull - cTP;
            Console.WriteLine(remainingCount);

            int preResult = remainingCount / pPP;
            Console.WriteLine(preResult);
            int abyssCalc = preResult / 15;
            Console.WriteLine(abyssCalc);
            int incAbyss = 0;
            if (abyss == true)
            {

                incAbyss = 150 + (abyssCalc * 600);
                Console.WriteLine(incAbyss);
            }
            int postResult = (remainingCount - incAbyss) / pPP;
            return postResult;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
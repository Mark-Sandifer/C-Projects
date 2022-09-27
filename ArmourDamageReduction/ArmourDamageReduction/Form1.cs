using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmourDamageReduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public float netDamRed(int arm, int dRaw)
        {
            int damRedS1 = dRaw * 10;
            int damRedS2 = damRedS1 + arm;
            float damRedS3 = (float)arm / (float)damRedS2;
            float rDR = (float)Math.Round(damRedS3 * 100f) / 100f;
            float netDamRedS1 = dRaw * rDR;
            float netDamRedS2 = dRaw - netDamRedS1;
            return netDamRedS2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int armour;
            if(int.TryParse(textBox1.Text, out armour) == false)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
                return;
            }
            labelLENC.Text = netDamRed(armour, 8919).ToString();
            labelHENC.Text = netDamRed(armour, 13377).ToString();
            labelLEC.Text = netDamRed(armour, 11595).ToString();
            labelHEC.Text = netDamRed(armour, 17390).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}

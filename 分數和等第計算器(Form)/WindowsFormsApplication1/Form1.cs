using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //作者:林紘毅
    //日期:107/10/17
    //專案名稱:分數和等第換算器





    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            average.Text = "";
            SCORE.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void coculation_Click(object sender, EventArgs e)
        {
            const double High_Score = 95.0;
            double Average;
            try
            {
                Average = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text)) / 3.0;
                average.Text = Average.ToString();

                if (Average >= 90)
                {
                    SCORE.Text = "A";
                }
                if (Average >= 80)
                {
                    SCORE.Text = "B";
                }
                if (Average >= 70)
                {
                    SCORE.Text = "C";
                }
                if (Average >= 60)
                {
                    SCORE.Text = "D";
                }
                else
                {
                    SCORE.Text = "F";
                }
                if (Average >= High_Score)
                {
                    MessageBox.Show("棒棒喔!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
        }
    }    
}





        
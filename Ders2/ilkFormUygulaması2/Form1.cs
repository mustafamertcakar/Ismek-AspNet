using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilkFormUygulaması2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double s1, s2, sonuc;

        private void button2_Click(object sender, EventArgs e)
        {
            s1=Convert.ToDouble(cikarBox1.Text); 
            s2=Convert.ToDouble(cikarBox2.Text);
            sonuc=s1-s2;
            label5.Text=sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s1=Convert.ToDouble(carpBox1.Text);
            s2=Convert.ToDouble(carpBox2.Text);
            sonuc = s1 * s2;
            label9.Text=sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sonuc; 

            s1=Convert.ToDouble(bolBox1.Text);
            s2= Convert.ToDouble(bolBox2.Text);
            sonuc = s1/s2;
            label13.Text=sonuc.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s1=Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            sonuc = s1 + s2;
            label4.Text=sonuc.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

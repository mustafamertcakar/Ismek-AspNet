using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            int salise, saniye, dakika, saat;
            salise = int.Parse(label7.Text);
            saniye = int.Parse(label5.Text);
            dakika = int.Parse(label3.Text);
            saat = int.Parse(label1.Text);

            if (salise < 60)
            {
                salise++;
                
               
            }
            else if (salise == 60)
            {
               
                saniye++;
                salise = 0;

                
                if (saniye == 60)
                {
                    saniye = 0;
                    dakika++;
                   

                }
                else if (dakika==60) {
                    dakika = 0;
                    saat++;

                }

            }
            label1.Text= saat.ToString();
            label3.Text = dakika.ToString(); 
            label5.Text = saniye.ToString();
            label7.Text = salise.ToString();



        }
        int ilkdeğer = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text= ilkdeğer.ToString();
            label3.Text = ilkdeğer.ToString();
            label5.Text = ilkdeğer.ToString();
            label7.Text = ilkdeğer.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {timer1.Interval = 1;
            timer1.Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(saat + ":" + dakika + ":" + saniye + ":" + salise);

            listBox1.Items.Add(label1.Text +       ":" + label3.Text + ":" + label5.Text + ":" + label7.Text);
        }

       
    }
}

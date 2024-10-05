using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asansor
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }
        int secim = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            if (secim == 0)
            {
                if (asansorBtn.Top>zeminKatBtn.Top) 
                {
                    asansorBtn.Top = asansorBtn.Top -1;
                    
                   
                }
                if (asansorBtn.Top < zeminKatBtn.Top) 
                {
                    asansorBtn.Top = asansorBtn.Top + 1;
                    
                }
                if (asansorBtn.Top == zeminKatBtn.Top)
                {
                    timer1.Enabled = false;
                }
            }
            if (secim == 1)
            {
                if (asansorBtn.Top > kat1Btn.Top)
                {
                    asansorBtn.Top=asansorBtn.Top -1;
                   

                }
                if (asansorBtn.Top < kat1Btn.Top) 
                {
                    asansorBtn.Top = asansorBtn.Top + 1;
                   

                }
                if (asansorBtn.Top == kat1Btn.Top)
                {
                    timer1.Enabled = false;
                }

            }
            if (secim == 2)
            {
                if (asansorBtn.Top > kat2Btn.Top)
                {
                    asansorBtn.Top = asansorBtn.Top - 1;
                   
                }
                if (asansorBtn.Top < kat2Btn.Top)
                {
                    asansorBtn.Top = asansorBtn.Top + 1;
                   
                }
                if (asansorBtn.Top == kat2Btn.Top)
                {
                    timer1.Enabled = false;
                }
            }
            if (secim == 3)
            {
                if (asansorBtn.Top > kat3Btn.Top)
                {
                    asansorBtn.Top = asansorBtn.Top - 1;
                }
                if (asansorBtn.Top < kat3Btn.Top)
                {
                    asansorBtn.Top = asansorBtn.Top + 1;
                }
                if (asansorBtn.Top == kat3Btn.Top)
                {
                    timer1.Enabled = false;
                }
            }
            if (secim == 4)
            {
                if (asansorBtn.Top > kat4Btn.Top)
                {
                    asansorBtn.Top = asansorBtn.Top - 1;
                }
                if (asansorBtn.Top < kat4Btn.Top)
                {
                    asansorBtn.Top = asansorBtn.Top + 1;
                }
                if (asansorBtn.Top == kat4Btn.Top)
                {
                    timer1.Enabled = false;
                }
            }
            if (secim == 5)
            {
                if (asansorBtn.Top > kat5Btn.Top)
                {
                    asansorBtn.Top = asansorBtn.Top - 1;
                }
                if (asansorBtn.Top < kat5Btn.Top)
                {
                    asansorBtn.Top = asansorBtn.Top + 1;
                }
                if (asansorBtn.Top == kat5Btn.Top)
                {
                    timer1.Enabled = false;
                }
            }
            if (timer1.Enabled == true) 
            {
                textBox1.BackColor = Color.Red;
                textBox1.Text = "Meşgul";
            }
            else if(timer1.Enabled==false)
            {
                textBox1.BackColor = Color.Green;
                textBox1.Text = "Müsait";
            }
        }
        
        private void zeminKatBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            secim = 0;
        }

        private void kat1Btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            secim = 1;
        }

        private void kat2Btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            secim = 2;
        }

        private void kat3Btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            secim = 3;
        }

        private void kat4Btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled= true;
            secim = 4;  
        }

        private void kat5Btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            secim = 5;
        }
    }
}

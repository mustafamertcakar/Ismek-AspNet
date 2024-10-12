using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HafızaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Timer t = new Timer();
        Timer t1 = new Timer(); 
        int iconIndex;
        Random rnd = new Random();
        Button ilkTiklanan, ikinciTiklanan;

        List<string> icons = new List<string>()
        {
            "A","B","C","D","E","F","G","H","K","L","M","N","O","P","R",
            "A","B","C","D","E","F","G","H","K","L","M","N","O","P","R",

        };


        private void Form1_Load(object sender, EventArgs e)
        {
            t.Tick += T_Tick ;
            t.Start();
            t.Interval = 3000;
            iconAtama();
            t1.Tick += T1_Tick;
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            t1.Stop();
            ilkTiklanan.ForeColor = ilkTiklanan.BackColor;
            ikinciTiklanan.ForeColor = ikinciTiklanan.BackColor;
            ilkTiklanan = null;
            ikinciTiklanan = null;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            t.Stop();
            foreach(Button item in Controls )
            {
                item.ForeColor = item.BackColor;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn= sender as Button;   
            if( ilkTiklanan == null) 
            {
                ilkTiklanan = btn; 
                ilkTiklanan.ForeColor = Color.Black;
                return;
            }
            ikinciTiklanan= btn;
            ikinciTiklanan.ForeColor= Color.Black;

            if( ilkTiklanan.Text == ikinciTiklanan.Text) 
            {
                ilkTiklanan.ForeColor=Color.Black;
                ikinciTiklanan.ForeColor = Color.Black;
                ilkTiklanan = null;
                ikinciTiklanan = null;

            }
            else
            {
                t1.Start(); 
                t1.Interval = 1000;
                
            }

        }

        private void iconAtama()
        {
            Button btn;
            foreach (Button item in Controls)
            {
                btn = item as Button;
                iconIndex=rnd.Next(icons.Count);
                btn.Text = icons[iconIndex];
                btn.ForeColor = Color.Black;
                icons.RemoveAt(iconIndex);
            }

        }
    }
}
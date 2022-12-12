using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color colorX;
        Color colorO;

        string nickg1;
        string nickg2;


        private void button2_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorPanelX.BackColor = colorDialog1.Color;
                colorX = colorDialog1.Color;
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                colorPanelY.BackColor = colorDialog2.Color;
                colorO = colorDialog2.Color;
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            nickg1 = podany_nick1.Text;
            nickg2 = podany_nick2.Text;

            Form2 form = new Form2(colorX, colorO, nickg1,nickg2);
            form.ShowDialog();
        }
    }
}

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

    public partial class Form2 : Form
    {
        Color colorX;
        Color colorO;
        string nickg1;
        string nickg2;
        string obecny_gracz;
        Color obecn_kolor;

        Random rand = new Random();

        public Form2(Color colorX, Color colorO, string nickg1, string nickg2)
        {
            InitializeComponent();

            this.colorX = colorX;
            this.colorO = colorO;
            this.nickg1 = nickg1;
            this.nickg2 = nickg2;

            int rng = rand.Next(1, 3);

            if (rng == 1)
            {
                obecny_gracz = "X";
                obecn_kolor = colorX;
                wykonywany_ruch.Text = nickg1;
                
            }
            else
            {
                obecny_gracz = "O";
                obecn_kolor = colorO;
                wykonywany_ruch.Text = nickg2;
            }
        }


        public void Klikanie(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (!string.IsNullOrEmpty(button.Text))
            {
                return;
            }
            switch (obecny_gracz)
            {
                case "X":
                    button.Text = "X";
                    obecny_gracz = "O";
                    button.BackColor = obecn_kolor;
                    obecn_kolor = colorO;
                    wykonywany_ruch.Text = nickg1;
                    End();
                    break;
                case "O":
                    button.Text = "O";
                    obecny_gracz = "X";
                    button.BackColor = obecn_kolor;
                    obecn_kolor = colorX;
                    wykonywany_ruch.Text = nickg2;
                    End();
                    break;
            }
        }

        public void End()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
                button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
                button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
                button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
                button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
                button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
                button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
               MessageBox.Show("Gra zakończona. \nZwyciężył: " + nickg1);
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
                button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
                button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
                button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
                button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
                button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
                button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("Gra zakończona. \nZwyciężył: " + nickg2);
            }

        }

    }
}

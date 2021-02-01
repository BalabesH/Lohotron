using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lohotron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void t1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsLetter(number) || Char.IsWhiteSpace(number) || Char.IsPunctuation(number) || Char.IsSeparator(number))// forbiden for entering for letters and simbols 
            {
                e.Handled = true;
                return;
            }
        }

        private void t2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsLetter(number) || Char.IsWhiteSpace(number) || Char.IsPunctuation(number) || Char.IsSeparator(number))// forbiden for entering for letters and simbols 
            {
                e.Handled = true;
                return;
            }
        }

        private void t3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsLetter(number) || Char.IsWhiteSpace(number) || Char.IsPunctuation(number) || Char.IsSeparator(number))// forbiden for entering for letters and simbols 
            {
                e.Handled = true;
                return;
            }
        }

        private void t4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsLetter(number) || Char.IsWhiteSpace(number) || Char.IsPunctuation(number) || Char.IsSeparator(number))// forbiden for entering for letters and simbols 
            {
                e.Handled = true;
                return;
            }
        }

        private void t5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsLetter(number) || Char.IsWhiteSpace(number) || Char.IsPunctuation(number) || Char.IsSeparator(number))// forbiden for entering for letters and simbols 
            {
                e.Handled = true;
                return;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //проверка на правильность ввода
            if (t1.Text is null || t2.Text is null || t3.Text is null || t4.Text is null || t5.Text is null)
            {
                MessageBox.Show("Fill all fields of ticket numbers", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var a = t1.Text;
            var b = t2.Text;
            var c = t3.Text;
            var d = t4.Text;
            var f = t5.Text;

            var Play = new Lottery();
            Play.ChPlayer[0] = Convert.ToInt32(a);
            Play.ChPlayer[1] = Convert.ToInt32(b);
            Play.ChPlayer[2] = Convert.ToInt32(c);
            Play.ChPlayer[3] = Convert.ToInt32(d);
            Play.ChPlayer[4] = Convert.ToInt32(f);

            for (int i = 0; i < 5; i++)
            {
                if (Play.ChPlayer[i] < 1 || Play.ChPlayer[i] > 25)
                {
                    MessageBox.Show("Please, ticket have to currect numbers from 1 to 25", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            
            Play.Action();

            switch(Play.win)
            {
                case 1:
                    ResultLabel.Text = "Совпал один номер! \nВаш выигрыш составил 5 вымышленных рублей!";
                    break;
                case 2:
                    ResultLabel.Text = "Совпало два номера! \nВаш выигрыш составил 25 вымышленных рублей!";
                    break;
                case 3:
                    ResultLabel.Text = "Совпало три номера! \nВаш выигрыш составил 125 вымышленных рублей!";
                    break;
                case 4:
                    ResultLabel.Text = "Совпало четыре номера! \nВаш выигрыш составил 625 вымышленных рублей!";
                    break;
                case 5:
                    ResultLabel.Text = "Совпали все номера!!! \nВаш выигрыш составил 3125 вымышленных рублей!";
                    break;
                default:
                    ResultLabel.Text = "К сожалению, ни один номер не совпал :(";
                    break;
            }
        }
    }
}

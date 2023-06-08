using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Estándar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region "Variables"
            int buffer;
            string symbol;
            int result = 0;
        #endregion
        #region "Métodos"
            private void cleanScreen()
            {
                if (result != 0 && txt_screen.Text != null || txt_screen.Text == "ERROR")
                {
                    txt_screen.Text = "";
                    result = 0;
                }
            }

        #endregion

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_screen.Text = "";
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            cleanScreen();
            txt_screen.Text += btn_one.Text;
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            cleanScreen();
            txt_screen.Text += btn_two.Text;
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            cleanScreen();
            txt_screen.Text += btn_three.Text;
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            cleanScreen();
            txt_screen.Text += btn_four.Text;
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            cleanScreen();
            txt_screen.Text += btn_five.Text;
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            cleanScreen();
            txt_screen.Text += btn_six.Text;
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            cleanScreen();
            txt_screen.Text += btn_seven.Text;
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            cleanScreen();
            txt_screen.Text += btn_eight.Text;
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            cleanScreen();
            txt_screen.Text += btn_nine.Text;
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            cleanScreen();
            txt_screen.Text += btn_zero.Text;
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            this.buffer = Convert.ToInt32(txt_screen.Text);
            txt_screen.Text = "";
            this.symbol = "+";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            result = 0;
            switch(symbol)
            {
                case "+":
                    txt_screen.Text = Convert.ToString(buffer + Convert.ToInt32(txt_screen.Text));
                    break;
                case "-":
                    txt_screen.Text = Convert.ToString(buffer - Convert.ToInt32(txt_screen.Text));
                    break;
                case "/":
                    try
                    {
                        txt_screen.Text = Convert.ToString(buffer / Convert.ToInt32(txt_screen.Text));
                    }
                    catch (DivideByZeroException ex)
                    {
                        txt_screen.Text = "ERROR";
                    };
                    break;
                case "X":
                    txt_screen.Text = Convert.ToString(buffer * Convert.ToInt32(txt_screen.Text));
                    break;
                default:
                    break;
            }
            buffer = 0;
            symbol = "";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            this.buffer = Convert.ToInt32(txt_screen.Text);
            txt_screen.Text = "";
            this.symbol = "-";
        }

        private void btn_times_Click(object sender, EventArgs e)
        {
            this.buffer = Convert.ToInt32(txt_screen.Text);
            txt_screen.Text = "";
            this.symbol = "X";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            try
            {
                this.buffer = Convert.ToInt32(txt_screen.Text);
                txt_screen.Text = "";
                this.symbol = "/";
            }
            catch(DivideByZeroException ex)
            {
                txt_screen.Text = "ERROR";
            };
        }

        private void btn_erase_Click(object sender, EventArgs e)
        {
            txt_screen.Text = txt_screen.Text.Remove(txt_screen.Text.IndexOf(txt_screen.Text.Last()));
            //MessageBox.Show(Convert.ToString(txt_screen.Text.IndexOf(txt_screen.Text.Last())));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Numero numero1 = new Numero();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = "";
                lblResultado.Text += "1";
            } else
            {
                lblResultado.Text += "1";
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = "";
                lblResultado.Text += "2";
            }
            else
            {
                lblResultado.Text += "2";
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = "";
                lblResultado.Text += "3";
            }
            else
            {
                lblResultado.Text += "3";
            }

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = "";
                lblResultado.Text += "4";
            }
            else
            {
                lblResultado.Text += "4";
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = "";
                lblResultado.Text += "5";
            }
            else
            {
                lblResultado.Text += "5";
            }

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = "";
                lblResultado.Text += "6";
            }
            else
            {
                lblResultado.Text += "6";
            }

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = "";
                lblResultado.Text += "7";
            }
            else
            {
                lblResultado.Text += "7";
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = "";
                lblResultado.Text += "8";
            }
            else
            {
                lblResultado.Text += "8";
            }

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = "";
                lblResultado.Text += "9";
            }
            else
            {
                lblResultado.Text += "9";
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length == 1 && lblResultado.Text == "0")
            {
                lblResultado.Text = "";
                lblResultado.Text += "0";
            }
            else
            {
                lblResultado.Text += "0";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string screen = lblResultado.Text;
            char[] del = screen.ToCharArray();
            del = del.Take(del.Count() - 1).ToArray();

            screen = "";

            for (int i = 0; i < del.Length; i++)
            {
                screen += del[i];
            }
            
            lblResultado.Text = screen;
        }


        private void btnSumar_Click(object sender, EventArgs e)
        {
            bool res;
            int a;
            res = int.TryParse(lblResultado.Text, out a);
            numero1.N1 = int.Parse(lblResultado.Text);
            numero1.Operacion = "suma";
            lblResultado.Text = "";
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            bool res;
            int a;
            res = int.TryParse(lblResultado.Text, out a);
            numero1.N1 = int.Parse(lblResultado.Text);
            numero1.Operacion = "resta";
            lblResultado.Text = "";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            bool res;
            int a;
            res = int.TryParse(lblResultado.Text, out a);
            numero1.N1 = a;
            numero1.Operacion = "mult";
            lblResultado.Text = "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            bool res;
            int a;
            res = int.TryParse(lblResultado.Text, out a);
            numero1.N1 = int.Parse(lblResultado.Text);
            numero1.Operacion = "div";
            lblResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero1.N2 = int.Parse(lblResultado.Text);
            lblResultado.Text = "";

            int result = 0;

            switch (numero1.Operacion)
            {
                case "suma":
                    result = numero1.N1 + numero1.N2;
                    break;

                case "resta":
                    result = numero1.N1 - numero1.N2;
                    break;

                case "mult":
                    result = numero1.N1 * numero1.N2;
                    break;

                case "div":
                    result = numero1.N1 / numero1.N2;
                    break;
            }

            lblResultado.Text = Convert.ToString(result);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            numero1.N1 = 0;
            numero1.N2 = 1;
            numero1.Operacion = "";
            lblResultado.Text = "0";
        }
    }
}

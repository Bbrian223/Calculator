using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
 
    public partial class Form1 : Form
    {
        string operMath;
        double firstNum, secNum;

        Class.Sum objSum = new Class.Sum();
        Class.Subs objSubs = new Class.Subs();
        Class.Mult objMult = new Class.Mult();
        Class.Div objDiv = new Class.Div();

        public Form1()
        {
            InitializeComponent();
        }

        //No reconoce los numeros de teclado

        private void btnNum0_Click_1(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + '0';
        }


        private void btnNum1_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + '1';
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + '2';
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + '3';
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + '4';
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + '5';
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + '6';
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + '7';
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + '8';
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + '9';
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + ',';
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operMath = "+";
            firstNum = Double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operMath = "-";
            firstNum = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            operMath = "*";
            firstNum = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operMath = "/";
            firstNum = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            //si se preciona dos veces "=" genera que se repita
            //la ultima operacion, con resultado como parametro

            double result;

            switch (operMath)
            {
                case "+":

                    secNum = Double.Parse(txtScreen.Text);
                    result = objSum.sum(firstNum, secNum);
                    txtScreen.Text = result.ToString();

                    break;

                case "-":

                    secNum = Double.Parse(txtScreen.Text);
                    result = objSubs.subs(firstNum, secNum);
                    txtScreen.Text = result.ToString();

                    break;

                case "*":

                    secNum = Double.Parse(txtScreen.Text);
                    result = objMult.mult(firstNum, secNum);
                    txtScreen.Text = result.ToString();

                    break;

                case "/":

                    secNum = Double.Parse(txtScreen.Text);
                    result = objDiv.div(firstNum, secNum);
                    txtScreen.Text = result.ToString();

                    break;
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            firstNum = 0;
            secNum = 0;
            txtScreen.Clear();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {

            //Borra todo el ultimo contenido en el txbox, debe borrar de a un numero
            txtScreen.Clear();
        }
    }
}

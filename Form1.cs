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

        Class.OperData objOper = new Class.OperData();      //separar los datos de las operaciones

        public Form1()
        {
            InitializeComponent();
        }

        /*
         *Errores a mejorar:
         *  - Pocicion inicial al correr el programa ineficiente. Debe posicionarse en el txtbox. 
         *  - Mala pocicion del cursor al presionar '.' en el teclado.
         *  - Al presionar una tecla no vuelve a posicionarse en el txtbox.
         *  - Separar datos de operacion y las operaciones de la mmisma clase.
         *  - Modificar tecla de borrar. Debe borrar un caracter por vez.
         *  - Asignar la operacion '=' al boton 'enter', para mayor comodidad
         */

        private void btnNum0_Click(object sender, EventArgs e)
        {
            sendText("0");
        }


        private void btnNum1_Click(object sender, EventArgs e)
        {
            sendText("1");
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            sendText("2");
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            sendText("3");
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            sendText("4");
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            sendText("5");
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            sendText("6");
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            sendText("7");
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            sendText("8");
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            sendText("9");
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            sendText(",");
        }

        /************************************ Operations **************************************************/

        private void btnAdd_Click(object sender, EventArgs e)
        {
            saveOperation("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            saveOperation("-");
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            saveOperation("*");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            saveOperation("/");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double result;

            result = objOper.CalcResult(txtScreen.Text);
            txtScreen.Clear();
            sendText(result.ToString());
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtScreen.Clear();
        }

        private void txtScreen_KeyPress(object sender, KeyPressEventArgs e)
        { 
            //deteccion y discriminacion de las teclas presionadas

            if (e.KeyChar >= 42 && e.KeyChar <= 57)     // caracteres ASCII solo para numeros y operadores matematicos
            {

                switch (e.KeyChar)
                {
                    case '+':                   //accion suma

                        saveOperation("+");
                        e.Handled = true;

                        break;

                    case '-':                   //accion resta

                        saveOperation("-");
                        e.Handled = true;

                        break;


                    case '*':                   //accion multiplicacion

                        saveOperation("*");
                        e.Handled = true;

                        break;

                    case '/':                   //accion division

                        saveOperation("/");
                        e.Handled = true;

                        break;

                    case '.':       //cuando se lo reconoce posiciona el puntero delante de los numeros

                        sendText(",");
                        e.Handled = true;

                        break;

                        //si no es ninguno de los signos de operaciones
                        //imprime el valor de la tecla presionada, que es un numero.
                }
            }

            else                                        // no es un signo valido
            {
                e.Handled = true;
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
 
            //Borra todo el ultimo contenido en el txbox, debe borrar de a un numero
            txtScreen.Clear();
        }

        private void sendText(string txt)
        {
            //Envia los datos al txtBox

            txtScreen.Text = txtScreen.Text + txt;
        }

        private void saveOperation(string sign)
        {
            //Guarda el primer valor y la operacion que se desea realizar 
            //Borra el txtbox para ingresar el segundo valor de la operacion

            objOper.setData(txtScreen.Text, sign);
            txtScreen.Clear();
        }
    }
}

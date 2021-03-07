using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Class
{
    class OperData
    {
        // atributos
        
        protected double firstNum;
        protected double secNum;
        protected string sign;


        //metodos

        public void setData(string firstNum, string sign)
        {
            //recibe el primer numero y la operacion que desea realizar
            //para luego utilizarla

            this.firstNum = double.Parse(firstNum);
            this.sign = sign;
        }

        public double CalcResult(string secNum)
        {
            //ingresa el segundo valor de laoperacion
            //se procede a realizar el calculo

            this.secNum = double.Parse(secNum);
            double result = 0;

            switch (sign)
            {
                case "+":       //operacion de suma

                    result = firstNum + this.secNum;

                    break;

                case "-":       //operacion de resta

                    result = firstNum - this.secNum;

                    break;

                case "*":       //operacion de multiplicacion

                    result = firstNum * this.secNum;

                    break;
                case "/":       //operacion de division

                    result = firstNum / this.secNum;

                    break;

            }

            return result;

        }

    
    }
}

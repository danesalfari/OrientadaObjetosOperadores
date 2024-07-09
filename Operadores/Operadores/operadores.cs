using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores.Operadores
{
    public class operadores
    {
        private double operador1;
        private double operador2;
        private double operador3;
        private double operador4;
        private double Resultado;

        public double Operador1 { get => operador1; set => operador1 = value; }
        public double Operador2 { get => operador2; set => operador2 = value; }
        public double Operador3 { get => operador3; set => operador3 = value; }
        public double Operador4 { get => operador4; set => operador4 = value; }
        public double Resultado1 { get => Resultado; set => Resultado = value; }
        public void sumar(double op1,double op2,double op3,double op4)
        {
            Resultado1 = op1+op2+op3+op4;
        }
        public void restar(double op1, double op2, double op3, double op4)
        {
            Resultado1 = op1 - op2 - op3 - op4;
        }
        public void multiplicar(double op1, double op2, double op3, double op4)
        {
            Resultado1 = op1 * op2 * op3 * op4;
        }
        public void dividir(double op1, double op2, double op3, double op4)
        {
            Resultado1 = op1 / op2 / op3 / op4;
        }
        public void promediar(double op1, double op2, double op3, double op4)
        {
            Resultado1 = (op1 + op2 + op3 + op4)/4;
        }
        public void potencia(double op1, double op2, double op3, double op4)
        {
            Resultado1 = Math.Pow((op1 + op2 + op3 + op4),2);
        }
        public void raiz(double op1, double op2, double op3, double op4)
        {
            Resultado1 =Math.Sqrt(op1 + op2 + op3 + op4);
        }
    }
}

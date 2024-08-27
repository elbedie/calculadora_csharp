using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Operacoes
    {
        public static decimal Adicao(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static decimal Subtracao(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        public static decimal Multiplicacao(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        public static decimal Divisao(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
    }
}

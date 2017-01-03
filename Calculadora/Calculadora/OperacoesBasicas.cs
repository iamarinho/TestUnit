using System;


namespace Calculadora
{
    public class OperacoesBasicas
    {
        public double soma(double a, double b)
        {
            return (a + b);
        }
        public double subtracao(double a, double b)
        {
            return (a - b);
        }
        public double multiplicacao(double a, double b)
        {
            return (a * b);
        }
        public double divisao(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Não é permitido divisão por zero");
            }
            return (a / b);
        }
    }
}
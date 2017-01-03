using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Tests
{
    [TestClass()]
    public class OperacoesBasicasTests
    {
        [TestMethod()]
        public void somaTest()
        {
            OperacoesBasicas target = new OperacoesBasicas();
            double x = 0;
            double y = 0;
            double expected = 0;
            double actual;

            actual = target.soma(x , y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void subtracaoTest()
        {
            OperacoesBasicas target = new OperacoesBasicas();
            double x = 0;
            double y = 0;
            double expected = 0;
            double actual;

            actual = target.subtracao(x, y);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void multiplicacaoTest()
        {
            OperacoesBasicas target = new OperacoesBasicas();
            double x = 0;
            double y = 0;
            double expected = 0;
            double actual;

            actual = target.multiplicacao(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void divisaoTest()
        {
            OperacoesBasicas target = new OperacoesBasicas();
            double x = 8;
            double y = 2;
            double expected = 4;
            double actual;

            actual = target.divisao(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void divisaoPorZeroTest()
        {
            OperacoesBasicas target = new OperacoesBasicas();
            double x = 10;
            double y = 0;
           
            target.divisao(x, y);
           
        }
    }
}
using Xunit;
using Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Tests {
    public class CalculadoraTests {
        [Fact()]
        public void SumaTest() {
            var sut = new Calculadora();

            var actual = sut.Suma(1, 2);

            Assert.Equal(3, actual);
        }

        [Fact()]
        public void SumaKOTest() {
            var sut = new Calculadora();

            var actual = sut.Suma(0.1, 0.2);

            Assert.Equal(0.3, actual);
        }

    }
}
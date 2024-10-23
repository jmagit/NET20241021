using Xunit;
using Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Tests {
    public class CalculadoraTests {
        private Calculadora sut;

        public CalculadoraTests() {
            sut = new Calculadora();
        }

        [Fact(DisplayName = "Sumar dos valores enteros"), Trait("Category", "smoke")]
        public void SumaTest() {
            //var sut = new Calculadora();

            var actual = sut.Suma(1, 2);

            Assert.Equal(3, actual);
        }

        [Fact(DisplayName = "Sumar dos valores decimales")]
        public void SumaDecimalTest() {
            //var sut = new Calculadora();

            var actual = sut.Suma(0.1m, (decimal)0.2);

            Assert.Equal(0.3m, actual);
        }

        [Fact(DisplayName = "Sumar múltiples valores double")]
        public void SumaDoubleTest() {
            //var sut = new Calculadora();

            var actual = sut.Suma(0.1, 0.2, 1);

            Assert.Equal(1.3, actual);
        }


        [Fact(DisplayName = "Sumar múltiples valores double error")]
        public void SumaDoubleTestKO() {
            Assert.Throws<ArgumentNullException>(() => sut.Suma(0.1, 0.2, null));
        }

        [Fact(DisplayName = "Validar que no tiene problemas de IEEE 754")]
        public void Suma_IEEE_Test() {
            //var sut = new Calculadora();

            var actual = sut.Suma(0.1, 0.2);

            Assert.Equal(0.3, actual);
        }

        [Theory(DisplayName = "Sumar dos valores enteros")]
        [InlineData(2, 2, 4)]
        [InlineData(2, 3, 5)]
        [InlineData(1, -1, 0)]
        [InlineData(-2, 1, -1)]
        [InlineData(3, 0, 3)]
        [InlineData(int.MaxValue, 1, int.MinValue)]
        public void SumasIntTest(int operando1, int operando2, int expect) {
            // Arrange
            // var sut = new Calculadora();

            // Act
            try {
                var actual = sut.Suma(operando1, operando2);
                // Assert
                Assert.Equal(expect, actual);
            } catch(Exception ex) {
                Assert.Fail($"Excepcion no controlada: {ex.ToString()}");
            }

        }

        public static IEnumerable<object[]> SumasDoubleData => new object[][] {
            new object[] {0.1, 0.2, 0.3 },
            new object[] {2, 3, 5 },
            new object[] {3, 0.5, 3.5 },
            new object[] {1, -0.9, 0.1 },
        };

        [Theory(DisplayName = "Sumar dos valores double")]
        [MemberData(nameof(SumasDoubleData))]
        public void SumasDoubleTest(double operando1, double operando2, double expect) {
            // Arrange
            // var sut = new Calculadora();

            // Act
            var actual = sut.Suma(operando1, operando2);

            // Assert
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void DivideInt() {
            Assert.Equal(0, sut.Divide(1, 2));
        }

        [Fact]
        public void DivideDouble() {
            Assert.Equal(0.5, sut.Divide(1, 2.0));
        }
        [Fact]
        public void DivideIntKO() {
            Assert.Throws<DivideByZeroException>(() => sut.Divide(1, 0));
        }

        [Fact]
        public void DivideDoubleKO() {
            //var ex = Assert.ThrowsAny<ArithmeticException>(() => sut.Divide(1.0, 0));

            //Assert.Contains("cero", ex.Message);

            var ex = Record.Exception(() => {
                sut.Divide(1.0, 0);
            });

            Assert.IsType<DivideByZeroException>(ex);
            Assert.Contains("cero", ex.Message);
        }

        [Theory(DisplayName = "Sumar dos valores enteros")]
        [InlineData(2, 3, -1)]
        [InlineData(5, 2, 3)]
        [InlineData(1, 0, 1)]
        [InlineData(1, 0.9, 0.1)]
        public void RestaTest(double operando1, double operando2, double expect) {
            // Act
            var actual = sut.Resta(operando1, operando2);
            // Assert
            Assert.Equal(expect, actual);
        }


    }
}
using InvertirNumero2Cifras;
using System;
using Xunit;


namespace _33EjerciciosCSharpTest
{
    public class InvertirNumero2CifrasTest
    {
        [Fact]
        public void Invertir12()
        {
            var result = InvertirNumero2Cifras.InvertirNumero2Cifras.InversionNumbersWithStrings("12");

            Assert.Equal(result,"21");
        }

        [Fact]
        public void Invertir02()
        {
            var result = InvertirNumero2Cifras.InvertirNumero2Cifras.InversionNumbersWithStrings("02");

            Assert.Equal(result, "20");
        }

        [Fact]
        public void Invertir321()
        {
            var result = InvertirNumero2Cifras.InvertirNumero2Cifras.InversionNumbersWithStrings("321");
            Assert.Equal(result, "123");
        }
    }
}

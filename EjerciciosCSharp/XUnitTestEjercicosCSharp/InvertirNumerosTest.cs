using System;
using Xunit;
using EjerciciosCSharp;

namespace XUnitTestEjercicosCSharp
{
    public class UnitTest1
    {
        public class InvertirNumerosTest
        {
            [Fact]
            public void Invertir12()
            {
                var result = InvertirNumeros.InversionNumbersWithStrings("12");

                Assert.Equal(result, "21");
            }

            [Fact]
            public void Invertir02()
            {
                var result = InvertirNumeros.InversionNumbersWithStrings("02");

                Assert.Equal(result, "20");
            }

            [Fact]
            public void Invertir321()
            {
                var result = InvertirNumeros.InversionNumbersWithStrings("321");
                Assert.Equal(result, "123");
            }
    }
}

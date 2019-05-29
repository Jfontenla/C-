using System;
using System.Linq;

namespace EjerciciosCSharp
{
    public class InvertirNumeros
    {
        static void Main(string[] args)
        {
            //InvertirNumero();
            LibreriaMath.StartLibreriaMath();

        }

        private static void InvertirNumero()
        {
            Console.WriteLine("Escribe un numero de N cifras");
            var inputNumber = Console.ReadLine();
            var result = InversionNumbersWithStrings(inputNumber);
            Console.WriteLine($"El resultado inverso de {inputNumber} es {result}");
            Console.ReadLine();
            result = InversionNumberWithLinq(inputNumber);
            Console.WriteLine($"CON LINQ: El resultado inverso de {inputNumber} es {result}");
            Console.ReadLine();
        }

        public static string InversionNumbersWithStrings(string inputNumber)
        {
            var result = "";
            //TODO : Mirar los Parse de las conversiones. Las esccrituras
            var listChars = inputNumber.ToCharArray();
            for (int i = 0; i < listChars.Length; i++)
            {
                result = result + listChars[(listChars.Length - 1) - i];
            }
            return result;
        }

        public static string InversionNumberWithLinq(string inputNumber)
        {
            string result = "";
            var inputReverse = inputNumber.Reverse();
            //REVERSE DE LINQ : Te da un Enumerable de chars no un string.
            foreach (var element in inputReverse)
            {
                result += element;
            }
            return result;
        }
    }
}

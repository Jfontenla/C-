using System;

namespace InvertirNumero2Cifras
{
    public class InvertirNumero2Cifras
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero de 2 cifras");
            var inputNumber = Console.ReadLine();
            var result = InversionNumbersWithStrings(inputNumber);
            Console.WriteLine($"El resultado inverso de {inputNumber} es {result}");
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
    }
}

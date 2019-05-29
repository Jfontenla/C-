

using System;

namespace EjerciciosCSharp
{
    public class LibreriaMath
    {
        public static void StartLibreriaMath()
        {

            Console.Write("Escribe un numero: ");
            var Num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Valor absoluto :{Math.Abs(Num)}");
            Console.WriteLine($"Valor de la potencia de 2 : {Math.Pow(Num, 2)}");
            Console.WriteLine(@"Valor de la raíz cuadarada :{0}",Math.Sqrt(Num));

            Console.ReadLine();
        }
    }
}



using System;

namespace EjerciciosCSharp
{
    public class LibreriaMath
    {
        public static void StartLibreriaMath()
        {

            Console.Write("Escribe un numero: ");
            var Num = double.Parse(Console.ReadLine());
            Console.WriteLine($"Valor absoluto :{Math.Abs(Num)}");
            Console.WriteLine($"Valor de la potencia de 2 : {Math.Pow(Num, 2)}");
            Console.WriteLine(@"Valor de la raíz cuadarada :{0}",Math.Sqrt(Num));
            Console.WriteLine(@"Seno : {0}", Math.Sin(Num)*Math.PI / 180);
            Console.WriteLine("Coseno: " + Math.Cos(Num)* Math.PI / 180);
            Console.WriteLine(@"El mayor entre {0} y 50 es: {1}",Num, Math.Max(Num,50));
            Console.WriteLine(@"El menor entre {0} y 50 es: {1}",Num, Math.Min(Num,50));
            Console.WriteLine($"La parte entera de {Num} es {Math.Truncate(Num)}");
            Console.WriteLine($"La parte entera de {Num} es {Math.Floor(Num)}");
            Console.WriteLine($"El redondeo del numero {Num} es {Math.Round(Num)}");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosCSharp
{
    public class TipoDelChar
    {
        public static void RealType()
        {
            var result = "";
            Console.WriteLine("Escriba un caracter : ");
            var linea = Console.ReadLine();

            if (linea.Length > 1)
            {
                Console.WriteLine("Ha escrito mas de un caracter");
            }
            else
            {
                var character = char.Parse(Console.ReadLine());
                int number;
                var isNumber = int.TryParse(character.ToString(), out number);
                if (isNumber)
                {
                    Console.WriteLine("Es un numero");
                }
                else if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {
                    Console.WriteLine("Es una vocal");
                }
                else
                {
                    Console.WriteLine("Es una consonante");
                }
                Console.ReadLine(); 
            }
        }
    }
}

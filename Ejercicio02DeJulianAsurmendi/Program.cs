using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02DeJulianAsurmendi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese el primer lado: ");
                var a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo lado: ");
                var b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el tercer lado:");
                var c = Convert.ToDouble(Console.ReadLine());

                if (numero(a, b, c) && triangulo(a, b, c))
                {
                    forma(a, b, c);
                    calculadordato(a, b, c);
                }
                else
                {
                    Console.WriteLine("Los lados ingresados no corresponden a un triangulo.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese los datos en tipo enteros o double.");
            }
            Console.ReadKey();
        }

        private static void calculadordato(double a, double b, double c)
        {
            double perimetro = a + b + c;
            Console.WriteLine($"Su perimetro es:{perimetro}");
            double p = (a + b + c) / 2;
            double are = p * (p - a) * (p - b) * (p - c);
            double area = Math.Sqrt(are);
            Console.WriteLine($"Su area es:{area}");
        }
        private static void forma(double a, double b, double c)
        {
            double a2 = Math.Pow(a, 2);
            double b2 = Math.Pow(b, 2);
            double c2 = Math.Pow(c, 2);
            if (a2 == (b2 + c2))
            {
                Console.WriteLine("El triangulo es rectangulo.");
            }
            else if (a2 > b2 + c2)
            {
                Console.WriteLine("El triangulo es obtusangulo.");
            }
            else if (a2 < b2 + c2)
            {
                Console.WriteLine("El triangulo es acutangulo.");
            }
            else
            {
                Console.WriteLine("Algo salio mal.");
            }
        }

        private static bool triangulo(double a, double b, double c) => a + b > c && a + c > b && b + c > a;
        private static bool numero(double a, double b, double c) => a >= 1 && b >= 1 && c >= 1;
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriArCua
{
    class Program
    {
        static void Main(string[] args)
        {
            string duh="";
            while (duh != "No") {
                Console.Clear();
                Console.WriteLine("Sistema para calcular Area y Perimetro de un triangulo\nAdemas que tipo es\n");
                Console.WriteLine("Calculo del Area");
                Triangulo triang = new Triangulo();

                Console.WriteLine("Ingrese la Base:");
                triang.Base = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la Altura:");
                triang.Altura = Int32.Parse(Console.ReadLine());
                Console.WriteLine("El area del triangulo es: " + triang.Area());
                Console.ReadKey();

                Console.WriteLine("\nCalculo del Perimetro, ademas da el tipo de triangulo");
                Console.WriteLine("Ingrese el primer valor:");
                triang.Lado1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo valor:");
                triang.Lado2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("E ingrese el tercer valor:");
                triang.Lado3 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("El Perimetro del triangulo es: " + triang.Perimetro());
                Console.ReadKey();
                Console.WriteLine(triang.Verificacion());
                Console.ReadKey();
                Console.WriteLine("Desea continuar? Si o No?");
                duh = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n            CHAO!!!");
            Console.ReadKey();
        }
    }
}

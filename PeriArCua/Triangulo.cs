using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriArCua
{
    class Triangulo
    {
        private double base1;
        private double altura;
        private int lado1;
        private int lado2;
        private int lado3;

        public Triangulo()
        {
        }
        public double Base
        {
            get { return base1; }
            set { base1 = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public int Lado1
        {
            get { return lado1; }
            set { lado1 = value; }
        }
        public int Lado2
        {
            get { return lado2; }
            set { lado2 = value; }
        }
        public int Lado3
        {
            get { return lado3; }
            set { lado3 = value; }
        }

        public double Area()
        {
            double resul = (base1 * altura) / 2;
            return resul;
        }

        public int Perimetro()
        {
            int result = lado1 + lado2 + lado3;
            return result;
        }

        public string Verificacion()
        {
            string value;
            if ((lado1 == lado2) && (lado2 == lado3) && (lado1 == lado3))
            {
                value= "El triangulo es EQUILATERO";
            }
            else if ((lado1 == lado2) || (lado1 == lado3) || (lado2 == lado3))
            {
                value= "El triangulo es ISOCELES";
            }
            else
            {
                value= "El triangulo es ESCALENO";
            }
            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r = new Rectangulo();

            r.setBase1(13.2);
            r.setAltura1(21.1);
            Console.WriteLine("Area: " + r.calcularArea());
            Console.WriteLine("Perimetro: " + r.calcularPerimetro());

            Cuadrado c = new Cuadrado();

            c.setLado(13.2);
            Console.WriteLine("Area: " + c.calcularArea());
            Console.WriteLine("Perimetro: " + c.calcularPerimetro());

            Triangulo t = new Triangulo();
            t.setBase1(5.4);
            t.setLado1(7.2);
            t.setLado2(4);
            Console.WriteLine("Area: " + t.calcularArea());
            Console.WriteLine("Perimetro: " + t.calcularPerimetro());

            Triangulo t1 = new Triangulo();
            t1.setBase1(7);
            t1.setAltura(9);
            Console.WriteLine("Area: " + t1.calcularArea());
            Console.WriteLine("Perimetro: " + t1.calcularPerimetro());

            Console.ReadKey();
        }

    }
    }


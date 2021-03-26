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

            r.setBase1(13);
            r.setAltura1(216);
            Console.WriteLine(r.calcularArea());


            Console.ReadKey();
        }

    }
    }


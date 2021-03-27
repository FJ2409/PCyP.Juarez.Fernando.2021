using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Cuadrado
    {
        private double lado;
        
        public Cuadrado()
        {
            this.lado = 0;
        }

        public void setLado(double lado)
        {
            this.lado = lado;
        }

        public double getLado()
        {
            return lado;
        }

        public double calcularArea()
        {
            double area = 0;

            return area = lado * lado;
        }
        
        public double calcularPerimetro()
        {
            double perimetro = 0;

            return perimetro = lado*4;
        }   
    }
}

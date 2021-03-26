using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Cuadrado
    {
        private int lado;
        
        public Cuadrado()
        {
            this.lado = 0;
        }

        public void setLado(int lado)
        {
            this.lado = lado;
        }

        public int getLado()
        {
            return lado;
        }

        public int calcularArea()
        {
            int area = 0;

            return area = lado * lado;
        }
        
        public int calcularPerimetro()
        {
            int perimetro = 0;

            return perimetro = lado*4;
        }   
    }
}

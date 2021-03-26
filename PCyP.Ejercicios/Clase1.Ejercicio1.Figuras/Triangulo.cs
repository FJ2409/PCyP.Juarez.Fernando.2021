using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Triangulo
    {
        int lado1, lado2, base1, altura;

        public Triangulo()
        {
            this.lado1 = 0;
            this.lado2 = 0;
            this.base1 = 0;
            this.altura = 0;
        }

        public void setLado1(int lado1)
        {
            this.lado1 = lado1;

        }

        public int getLado1()
        {
            return lado1;
        }

        public void setLado2(int lado2)
        {
            this.lado2 = lado2;
        }

        public int getLado2()
        {
            return lado2;
        }

        public void setBase1(int base1)
        {
            this.base1 = base1;
        }

        public int getBase1()
        {
            return base1;
        }

        public int calcularArea()
        {
            int area=0;


            return area= (base1*altura)/2;

        }
    }

}

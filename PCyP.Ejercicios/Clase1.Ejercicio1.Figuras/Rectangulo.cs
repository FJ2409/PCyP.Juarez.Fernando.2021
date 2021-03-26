using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Rectangulo
    {
        private int base1;
        private int altura1;



        public Rectangulo()
        {
            this.base1 = 0;
            this.altura1 = 0;
        }

        public void setBase1(int base1)
        {
            this.base1 = base1;
        }

        public int getBase1()
        {
            return base1;
        }

        public void setAltura1(int altura1)
        {
            this.altura1 = altura1;
        }

        public int getAltura1()
        {
            return altura1;
        }

        public int calcularArea()
        {
            int area = 0;

            return area = base1 * altura1;

        }

        public int calcularPerimetro()
        {
            int perimetro = 0;

            return perimetro = base1 * 2 + altura1 * 2;
        }
    }

}

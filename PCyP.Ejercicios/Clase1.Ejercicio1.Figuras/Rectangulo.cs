using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Rectangulo
    {
        private double base1;
        private double altura1;



        public Rectangulo()
        {
            this.base1 = 0;
            this.altura1 = 0;
        }

        public void setBase1(double base1)
        {
            this.base1 = base1;
        }

        public double getBase1()
        {
            return base1;
        }

        public void setAltura1(double altura1)
        {
            this.altura1 = altura1;
        }

        public double getAltura1()
        {
            return altura1;
        }

        public double calcularArea()
        {
            double area = 0;

            return area = base1 * altura1;

        }

        public double calcularPerimetro()
        {
            double perimetro = 0;

            return perimetro = base1 * 2 + altura1 * 2;
        }
    }

}

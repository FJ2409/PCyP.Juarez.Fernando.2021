using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Triangulo
    {
        private double lado1, lado2, base1, altura;


        public Triangulo()
        {

        }


        public Triangulo(double lado1, double base1, double lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.base1 = base1;
           
            
        }
        public Triangulo(double base1, double altura)
        {
            this.base1 = base1;
            this.altura = altura;
         }

        public void setLado1(double lado1)
        {
            this.lado1 = lado1;

        }

        public double getLado1()
        {
            return lado1;
        }

        public void setLado2(double lado2)
        {
            this.lado2 = lado2;
        }

        public double getLado2()
        {
            return lado2;
        }

        public void setBase1(double base1)
        {
            this.base1 = base1;
        }

        public double getBase1()
        {
            return base1;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        public double getAltura()
        {
            return altura;
        }



        public double calcularArea()
        {
            double area = 0;
            double perimetro = 0;
            double subperimetro = 0;

            if (altura == 0)
            {
                perimetro = calcularPerimetro();
                subperimetro = perimetro / 2;
                area = Math.Sqrt(subperimetro*((subperimetro - lado1)*(subperimetro - lado2)*(subperimetro - base1)));

            }
            else
            {
                area = (base1 * altura) / 2;
            }

            return area;        
           
        }

        public double calcularPerimetro()
        {
            double perimetro = 0;

            return perimetro = lado1 + lado2 + base1;

        }
    }

}

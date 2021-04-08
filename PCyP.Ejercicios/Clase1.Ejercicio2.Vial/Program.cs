using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio2.Vial
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] archivo= File.ReadAllLines("C:/Users/FJUAREZ/Desktop/vial.csv");

            ArchivoCSV csv = new ArchivoCSV();
            int cont = 0;


            foreach (var linea in archivo)
            {
                var campo = linea.Split(',');
                csv = new ArchivoCSV(int.Parse(campo[0]), campo[1] , int.Parse(campo[2]), campo[3], int.Parse(campo[4]));
                csv.imprimir();
                cont++;
            }

            Console.WriteLine("\nRegistros: " + cont);
            Console.ReadLine();
        }
    }
}

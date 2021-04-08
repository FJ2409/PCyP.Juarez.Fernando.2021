using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio2.Color
{
    class Program
    {
        private static readonly string[] colors = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
        private static readonly string[] removeColors = { "RED", "WHITE", "BLUE" };


        public static void Main(string[] args)
        {

            List<string> colores = new List<string>();
           
            for (int i=0; i< colors.Length; i++)
            {
                colores.Add(colors[i]);
            }

            for (int j = 0; j < colores.FindIndex; j++)
            {
                Console.WriteLine(colores[j]);
            }
            //List<string> removerColores = new List<string>();

    
        }
        }
    }

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
            foreach(string color in colors)
            {
                colores.Add(color);
            }
           
            foreach(string color in colores)
            {
                Console.WriteLine(color);
            }
            //List<string> removerColores = new List<string>();


        }
        }
    }

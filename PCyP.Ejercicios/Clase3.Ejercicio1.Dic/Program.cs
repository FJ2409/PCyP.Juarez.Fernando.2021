using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio1.Dic
{
    class Program
    {
        public static void Main(string[] args)
        {

            string valor = "";
            Dictionary<string, string> values = new Dictionary<string, string>();
            values.Add("Juan", "55423412");
            values.Add("Ernesto", "56985623");
            values.Add("Mariana", "54787451");
            

            if (values.ContainsKey("Juan"))
            {
                Console.WriteLine( values["Juan"]);
            }
            else
            {
                Console.WriteLine("No contiene la llave");
            }

            if (values.TryGetValue("Pedro", out valor))
            {
                Console.WriteLine(values["Pedro"]);

            }
            else
            {
                Console.WriteLine("No contiene la llave");
            }


            foreach( var i in values)
            {
                Console.WriteLine("Indice: {0} " + "," + " Valor: {1}", i.Key, i.Value);
            }


            values.Remove("Mariana");
            values.Add("Mariana", "58251425");


            if (values.ContainsKey("Mariana"))
            {
                Console.WriteLine(values["Mariana"]);
            }

           



            Console.ReadKey();
        }
    }
}


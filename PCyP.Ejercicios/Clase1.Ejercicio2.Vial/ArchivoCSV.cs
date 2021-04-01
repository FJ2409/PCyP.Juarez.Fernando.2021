using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio2.Vial
{
    class ArchivoCSV
    {
        private int numeroDeHoja;
        private int identificadorTramo;
        private int longitud;
        private string tipoObjeto;
        private string tipoCamino;



        public ArchivoCSV()
        {

        }

        public ArchivoCSV(int numeroDeHoja, string tipoObjeto, int identificadorTramo, string tipoCamino, int longitud)
        {
            this.numeroDeHoja = numeroDeHoja;
            this.identificadorTramo = identificadorTramo;
            this.longitud = longitud;
            this.tipoObjeto = tipoObjeto;
            this.tipoCamino = tipoCamino;
        }

        public void setNumeroDeHoja(int numeroDeHoja)
        {
            this.numeroDeHoja = numeroDeHoja;
        }

        public int getNumeroDeHoja()
        {
            return numeroDeHoja;
        }

        public void setIdentificadorTramo(int identificadorTramo)
        {
            this.identificadorTramo = identificadorTramo;
        }

        public int getIdentificadorTramo()
        {
            return identificadorTramo;
        }

        public void setLongitud(int longitud)
        {
            this.longitud = longitud;
        }

        public int getLongitud()
        {
            return longitud;
        }

        public void setTipoObjeto (String tipoObjeto)
        {
            this.tipoObjeto = tipoObjeto;
        }

        public String getTipoObjeto()
        {
            return tipoObjeto;
        }

        public void setTipoCamino (String tipoCamino)
        {
            this.tipoCamino = tipoCamino;
        }

        public String getTipoCamino()
        {
            return tipoCamino;
        }


        public void imprimir()
        {
            Console.WriteLine("\nNumero de Hoja: {0}\nTipo de Objeto: {1} \nTipo de Camino: {2}\nIdentificador de Tramo: {3}\nLongitud: {4}", numeroDeHoja, tipoObjeto, identificadorTramo, tipoCamino, longitud);
        }
    }
}

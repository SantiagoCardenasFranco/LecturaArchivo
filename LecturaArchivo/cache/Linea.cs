using System;
using System.Xml.Linq;

namespace Compilador.src.cache
{
    public class Linea
    {
        private int numeroLinea;
        private String contenido;

        private Linea(int numeroLinea, string contenido)
        {
            this.contenido = contenido;
            this.numeroLinea = numeroLinea;
        }

        public static Linea crear(int numeroLinea, string contenido)
        {
            return new Linea(numeroLinea, contenido);
        }

        public int NumeroLineas
        {
            get { return numeroLinea;}
        }

        public String Contenido
        {
            get { return contenido;}
        }

        public int obtenerNumeroLinea()
        {
            return numeroLinea;
        }

        public String obtenerContenido()
        {
            return contenido;
        }

        public void aumentarLinea()
        {
            numeroLinea = numeroLinea + 1;
        }

        public int obtenerLongitudContenido()
        {
            return obtenerContenido().Length;
        }


    }
}
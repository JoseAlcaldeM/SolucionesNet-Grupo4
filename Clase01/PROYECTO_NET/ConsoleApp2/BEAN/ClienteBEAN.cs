using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.BEAN
{
    public class ClienteBEAN
    {
        //uso propfull
        //uso prop
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        private char genero;

        public char Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Carrera { get; set; }
        /*Métodos*/
        public string ConcatenarDatos()
        {
            string concatenado = Nombre + " " + Apellido;
            return concatenado;
        }

        public string ConcatenarDatosConParametros(string pNombre, string pApellido)
        {
            string concatenado = "";
            concatenado = pNombre + " , " + pApellido;
            return concatenado;
        }


    }
}

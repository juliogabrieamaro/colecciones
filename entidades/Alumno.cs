using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Alumno
    {
        private string nombre;
        private string apellido;
        private int legajo;


        public  Alumno(string n, string a, int l)
        {


            this.nombre = n;
            this.legajo = l;
            this.apellido = a;

        }
        public static bool operator ==(Alumno x, Alumno j)
        {



           // return (x.legajo == j.legajo && x.nombre == j.nombre);

          //bool retorno = false;
            if (x.legajo == j.legajo && x.nombre == j.nombre)
            {
               //retorno = true;
                return true;
            
            }
           //return retorno;
            return false;
        
        }
        public static bool operator !=(Alumno x, Alumno j)
        {
            return !(x == j);



        }




    }
}

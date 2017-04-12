using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using EntidadesConColecciones2.Nogeneric;
using entidades;

namespace consolaArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Aula primerAula = new Aula();
            EntidadesConColecciones2.generic.Aula segundoAula = new EntidadesConColecciones2.generic.Aula();
            //int indice = primerAula.obtenerLugarLibre();
            for (int i = 0; i <12; i++)
            {
                primerAula.agregarAlumnos(new entidades.Alumno("juan", "perez",i));
            }


            primerAula.borrarAlumno(new entidades.Alumno("juan", "perez", 6));
            primerAula.borrarAlumno(new entidades.Alumno("lalala", "lalala", 6));
            primerAula.borrarAlumno(new entidades.Alumno("juan", "perez", 666));
            Console.ReadLine();

            
        }
    }
}

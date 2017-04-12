using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Aula
    {
        private int numero;
        private Alumno[] misAlumnos;
        
        public Aula()
        {

            this.misAlumnos = new Alumno[10];
        
        }


        public void agregarAlumnos(Alumno x)
        {
            int indice = this.obtenerLugarLibre();

            if (indice != -1)
            {

                this.misAlumnos[indice] = x;
            }

            else
            {
                Console.WriteLine("NO HAY LUGAR");
            }
           
        }
        public void borrarAlumno(Alumno x)
        {
            int indiceBorrado = this.retornarIndiceDeObj(x);

            if (indiceBorrado != -1)
            {
                this.misAlumnos[indiceBorrado] = null;

            }
            else
            {
                Console.WriteLine("No existe");
            }
            
        
        }
  
        /// <summary>
        /// obtiene el indice del primer lugar en null,
        /// retorna -1 si no hay lugar
        /// </summary>
        /// <returns></returns>
    public int obtenerLugarLibre()
        {
            int retorno = -1;
            int i=0;
            foreach (Alumno itemAlum in this.misAlumnos)
            {
              
                if ((object)itemAlum == null)
                {
                    return i;
                
                }
                i++;
            }


            return retorno;
        }

        /// <summary>
        /// retorna el indice paraso por parametro,
        /// retorna -1 si no lo encuentra
        /// </summary>
        /// <param name="alumnoParametro"></param>
        /// <returns></returns>
    private int retornarIndiceDeObj(Alumno alumnoParametro)
    {
        int retorno = 0;
        int i;
       
        for (i=0; i<10;i++)
         {
             if (this.misAlumnos.GetValue(i)!=null && alumnoParametro == this.misAlumnos[i])
             {

                 return i;
             
             
             }
         
         }
  

        return -1;
        
    }


    }
}

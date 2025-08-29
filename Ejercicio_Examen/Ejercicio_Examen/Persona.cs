using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Examen
{
    internal class Persona
    {
        // ATRIBUTOS
        // prop + tab
        public string Nombre { get; set; }
        public string Tipo_trabajo { get; set; }
        public int Ci { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
        
        //FUNCIONES 
        public virtual void MostrarPersona()
        {
            Console.WriteLine("La persona es: " + Nombre + " , su trabajo es" + Tipo_trabajo + " , su CI es: "+ Ci+ " ,con fecha de nacimiento: " + Fecha_nacimiento);
        }
    }
}

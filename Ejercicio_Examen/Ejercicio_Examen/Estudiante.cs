using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Examen
{
    internal class Estudiante : Persona
    {
        public double Matricula { get; set; }

        public override void MostrarPersona()
        {
            Console.WriteLine("La persona es: " + Nombre + " , su trabajo es" + Tipo_trabajo + " , su CI es: " + Ci + " ,con fecha de nacimiento: " + Fecha_nacimiento + ", matricula: " + Matricula );
        }
    }
}

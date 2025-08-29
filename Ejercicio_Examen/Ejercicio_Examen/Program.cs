using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista de Personas
            List<Persona> listaPersonas = new List<Persona>();

            //crear 5 Personas en la lista 

            listaPersonas.Add(new Persona() { 
                Nombre = "Harol",
                Tipo_trabajo = "Cajero",
                Ci = 4535345,
                //Usando Parse
                Fecha_nacimiento = DateTime.Parse("02/12/1998"),
            });

            listaPersonas.Add(new Persona()
            {
                Nombre = "Carla",
                Tipo_trabajo = "Doctora",
                Ci = 4478998,
                //Usando Convert
                Fecha_nacimiento = Convert.ToDateTime("02/08/1997"),
            });


            listaPersonas.Add(new Persona()
            {
                Nombre = "Jose",
                Tipo_trabajo = "Policia",
                Ci = 7895954,
                //Usando Convert
                Fecha_nacimiento = Convert.ToDateTime("12/07/2000"),
            });


            listaPersonas.Add(new Persona()
            {
                Nombre = "Maria",
                Tipo_trabajo = "Doctora",
                Ci = 5446756,
                //Usando Convert
                Fecha_nacimiento = Convert.ToDateTime("06/12/1999"),
            });



            listaPersonas.Add(new Persona()
            {
                Nombre = "Kevin",
                Tipo_trabajo = "Ingeniero",
                Ci = 87443443,
                //Usando Convert
                Fecha_nacimiento = Convert.ToDateTime("05/05/1999"),
            });

            foreach (var persona in listaPersonas)
            {
                Console.WriteLine("La persona es: " + persona.Nombre + " , su trabajo es " + persona.Tipo_trabajo + " , su CI es: " + persona.Ci + " ,con fecha de nacimiento: " + persona.Fecha_nacimiento);
            }

            //Consultas LinQ
            //Mostrar las personas que nacieron en el mes de diciembre
            MostrarMes(listaPersonas);

            //Expresionas Lambda
            //Mostrar las personas que nacieron en el año 1999 y con nombre = Kevin
            MostrarPersonaK(listaPersonas);

            //Expresionas Lambda mostrar a la persona con CI = 5446756
            MostrarCI(listaPersonas);

            Console.ReadKey();
        }

        private static void MostrarCI(List<Persona> listaPersonas)
        {
            var MostrarCi = listaPersonas.Where(x => x.Ci == 5446756);

            Console.WriteLine("\n------Las personas con CI = 5446756 -------");
            foreach (var persona in MostrarCi)
            {
                Console.WriteLine("La persona es: " + persona.Nombre + ", CI= " + persona.Ci);
            }
        }

        private static void MostrarPersonaK(List<Persona> listaPersonas)
        {
            // Expresiones lambda
            // =>
            var MostrarK = listaPersonas.Where(x => x.Fecha_nacimiento.Year == 1999 && x.Nombre == "Kevin");
            Console.WriteLine("\n------Las personas con fecha de nacimiento en 1999  y nombre = Kevin -------");
            foreach (var persona in MostrarK)
            {
                Console.WriteLine("La persona es: " + persona.Nombre + ", fecha de nacimiento es: "+ persona.Fecha_nacimiento);
            }
        }

        private static void MostrarMes(List<Persona> listaPersonas)
        {
            /* Lin Q
              FROM 
              WHERE  
               SELECT 
             */
            var mostrarMesNac = from persona in listaPersonas
                                where persona.Fecha_nacimiento.Month == 12
                                select persona;
            Console.WriteLine("\n------Las personas con fecha de nacimiento en diciembre son: -------");
            foreach (var persona in mostrarMesNac)
            {
                Console.WriteLine("La persona es: " + persona.Nombre + " , su trabajo es " + persona.Tipo_trabajo + " , su CI es: " + persona.Ci + " ,con fecha de nacimiento: " + persona.Fecha_nacimiento);
            }
        }
    }
}

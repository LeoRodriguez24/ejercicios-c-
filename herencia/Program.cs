using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //listas de personas
            List<Persona> listaPersonas = new List<Persona>();
            //Añadir personas a la lista listaPersonas
            listaPersonas.Add(new Persona()
            {
                Nombre = "Juan",
                Apellido = "Perez",
                Edad = 23,
                Genero = "Masculino",
                Sueldo = 2300
            });
            listaPersonas.Add(new Persona()
            {
                Nombre = "Ana",
                Apellido = "Cloque",
                Edad = 19,
                Genero = "Femenino",
                Sueldo = 2300
            });
            listaPersonas.Add(new Persona()
            {
                Nombre = "Felix",
                Apellido = "Hurtado",
                Edad = 53,
                Genero = "Masculino",
                Sueldo = 6000
            });
            listaPersonas.Add(new Persona()
            {
                Nombre = "Kevin",
                Apellido = "Apaza",
                Edad = 35,
                Genero = "Masculino",
                Sueldo = 28000
            });
            listaPersonas.Add(new Persona()
            {
                Nombre = "Julia",
                Apellido = "Dominguez",
                Edad = 55,
                Genero = "Femenino",
                Sueldo = 6800
            });


            //foreach sirve para iterar la lista listaPersonas
            // "var" soporta datos: int, double, string, objetos, listas
            Console.WriteLine("--------Lista de personas usando el tipo de dato var--------");
            foreach (var item in listaPersonas)
            {
                Console.WriteLine(item.Nombre + " " + item.Apellido);
            }

            //otra forma de iterar sin usar "var"
            Console.WriteLine("\n--------Lista de personas usando la clase Persona--------");
            foreach (Persona pers in listaPersonas){
                Console.WriteLine(pers.Nombre + " " + pers.Edad);
            }


            //Expresiones Lambda
            // =>

            //promedio de edades
            double promedio = promEdad(listaPersonas);
            Console.WriteLine("\nEl promedio de las edades usando Expresiones Lambda es: " + promedio);
            //promedio de salarios
            double promedioSueldo = promSalario(listaPersonas);
            Console.WriteLine("El promedio de los sueldos usando Expresiones Lambda es: " + promedioSueldo);

            //Consultas LinQ
            //Recordar siempre esto como formulario:
            //From
            //Where 
            //Select


            double promEd = promLinQEdad(listaPersonas);
            Console.WriteLine("\nEl promedio de las edades usando Consultas LinQ es: " + promEd);
            double promSuel = promLinQSueldo(listaPersonas);
            Console.WriteLine("El promedio de los sueldos usando Consultas LinQ es: " + promSuel);

            //Genero masculino
            MostrarMasculino(listaPersonas);

            //edad y sueldo
            Mostrar(listaPersonas);
            Console.ReadKey();

            Console.ReadKey();
        }

        private static void Mostrar(List<Persona> listaPersonas)
        {
            var mostrar = (from persona in listaPersonas
                           where persona.Edad < 40 && persona.Sueldo > 5000
                           select persona.Nombre);
            Console.WriteLine("\n--------Personas que son menores a 40 años y de un sueldo mayor a 5000--------");
            foreach (var i in mostrar)
            {
                Console.WriteLine(i);
            }
        }

        private static void MostrarMasculino(List<Persona> listaPersonas)
        {
            var mostrar = (from persona in listaPersonas
                           where persona.Genero == "Masculino"
                           select persona.Nombre);
            Console.WriteLine("\n--------Lista de Personas de Genero Masculino--------");
            foreach (var i in mostrar)
            {
                Console.WriteLine(i);
            }

        }

        private static double promLinQSueldo(List<Persona> listaPersonas)
        {
            double totalSueldo = (from persona in listaPersonas
                                  select persona.Sueldo).Sum();
            int totalPersonas = listaPersonas.Count;
            return (double)totalSueldo / totalPersonas;

        }

        private static double promLinQEdad(List<Persona> listaPersonas)
        {
            double totalEdad = (from persona in listaPersonas
                                select persona.Edad).Sum();
            int totalPersonas = listaPersonas.Count;
            return (double)totalEdad / totalPersonas;
        }

        private static double promSalario(List<Persona> listaPersonas)
        {
            double totalSalarios = listaPersonas.Sum(s => s.Sueldo);
            int totalPersonas = listaPersonas.Count;
            return (double)totalSalarios / totalPersonas;
        }

        private static double promEdad(List<Persona> listaPersonas)
        {
            int totalEdades = listaPersonas.Sum(edad => edad.Edad);
            int totalPersonas = listaPersonas.Count;
            return (double)totalEdades / totalPersonas;
        }
    }
}

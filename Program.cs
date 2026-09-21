using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1Taller
{
    internal class Program
    {
        static List<Salon> listaSalones = new List<Salon>();
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Bienvenido al sistema de gestion de salones");
                Console.WriteLine("1. Crea un nuevo salón");
                Console.WriteLine("2. Seleccionar un salón y gestionar");
                Console.WriteLine("3. Salir del programa");
                Console.WriteLine("Ingrese el número correspondiente:   ");

                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    CrearNuevoSalon();
                }
                else if (opcion == "2")
                {

                }
                else if (opcion == "3")
                {

                }
                else
                {
                    Console.WriteLine("Opción no válida. Introduzca un número válido");
                    Console.ReadLine();
                } 




            }
            

                
        }

        static void CrearNuevoSalon()
        {
            Console.WriteLine("Ingrese el nombre o código del salón: ");
            string nombre = Console.ReadLine();

            if (nombre != "")
            {
                listaSalones.Add(new Salon(nombre) );
                Console.WriteLine("Salon creado con éxito");
            }
            else
            {
                Console.WriteLine("El nombre del salón no puede estar vacío");
            }

        }

    }
}

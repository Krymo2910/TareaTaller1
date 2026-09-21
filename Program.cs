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
                Console.Clear();
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
                    GestionarSalon();
                }
                else if (opcion == "3")
                {
                    salir = true;
                    Console.WriteLine("Gracias por su visita :D");
                }
                else
                {
                    Console.WriteLine("Opción no válida. Introduzca un número válido");
                    Pausar();
                }
            }
        }

        static void Pausar()
        {
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }

        static void CrearNuevoSalon()
        {
            Console.WriteLine("Ingrese el nombre o código del salón: ");
            string nombre = Console.ReadLine();

            if (nombre != "")
            {
                listaSalones.Add(new Salon(nombre));
                Console.WriteLine("Salon creado con éxito");
            }
            else
            {
                Console.WriteLine("El nombre del salón no puede estar vacío");
            }
            Pausar();
        }

        static void MostrarSalones()
        {
            Console.WriteLine("Salones Registrados:");
            if (listaSalones.Count == 0)
            {
                Console.WriteLine("No hay salones creados.");
            }
            else
            {
                for (int i = 0; i < listaSalones.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". Salón " + listaSalones[i].nombreSalon + " (" + listaSalones[i].alumnos.Count + " alumnos)");
                }
            }
        }

        static void GestionarSalon()
        {
            if (listaSalones.Count == 0)
            {
                Console.WriteLine("Primero debes crear un salón");
                Pausar();
                return;
            }

            MostrarSalones();
            Console.WriteLine("Seleccione el número del salón para modificar: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < listaSalones.Count)
            {
                SubMenuOperaciones(listaSalones[indice]);
            }
            else
            {
                Console.WriteLine("Número de salón inválido");
                Pausar();
            }
        }

        static void SubMenuOperaciones(Salon salonActual)
        {
            bool volver = false;

            while (!volver)
            {
                Console.Clear();
                Console.WriteLine("Salón registrado: " + salonActual.nombreSalon);
                Console.WriteLine("1. Registrar un alumno");
                Console.WriteLine("2. Remover un alumno");
                Console.WriteLine("3. Calcular cantidad de aprobados");
                Console.WriteLine("4. Calcular cantidad de desaprobados");
                Console.WriteLine("5. Mostrar lista de alumnos aprobados");
                Console.WriteLine("6. Mostrar lista de alumnos desaprobados");
                Console.WriteLine("7. Calcular promedio general del salón");
                Console.WriteLine("8. Volver al menú principal");
                Console.WriteLine("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.Write("Nombre del alumno: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Nota 1: ");
                    float n1 = float.Parse(Console.ReadLine());
                    Console.Write("Nota 2: ");
                    float n2 = float.Parse(Console.ReadLine());
                    Console.Write("Nota 3: ");
                    float n3 = float.Parse(Console.ReadLine());

                    salonActual.RegistrarAlumno(new Alumno(nombre, n1, n2, n3));
                    Console.WriteLine("Alumno agregado exitosamente.");
                    Pausar();
                }
                else if (opcion == "2")
                {
                    Console.Write("Ingrese el nombre del alumno a remover: ");
                    string nombreRemover = Console.ReadLine();

                    if (salonActual.RemoverAlumno(nombreRemover))
                    {
                        Console.WriteLine("Alumno removido con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ningún alumno con ese nombre.");
                    }
                    Pausar();
                }
                else if (opcion == "3")
                {
                    Console.WriteLine("Cantidad de aprobados: " + salonActual.CantidadDeAprobados());
                    Pausar();
                }
                else if (opcion == "4")
                {
                    Console.WriteLine("Cantidad de desaprobados: " + salonActual.CantidadDeDesaprobados());
                    Pausar();
                }
                else if (opcion == "5")
                {
                    Console.WriteLine("Alumnos aprobados:");
                    List<Alumno> aprobados = salonActual.ObtenerAprobados();
                    for (int i = 0; i < aprobados.Count; i++)
                    {
                        Console.WriteLine("- " + aprobados[i].nombre + " | Promedio TLS: " + aprobados[i].PromedioTLS());
                    }
                    Pausar();
                }
                else if (opcion == "6")
                {
                    Console.WriteLine("Alumnos desaprobados:");
                    List<Alumno> desaprobados = salonActual.ObtenerDesaprobados();
                    for (int i = 0; i < desaprobados.Count; i++)
                    {
                        Console.WriteLine("- " + desaprobados[i].nombre + " | Promedio TLS: " + desaprobados[i].PromedioTLS());
                    }
                    Pausar();
                }
                else if (opcion == "7")
                {
                    Console.WriteLine("Promedio del salón: " + salonActual.CalcularPromedioSalon());
                    Pausar();
                }
                else if (opcion == "8")
                {
                    volver = true;
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                    Pausar();
                
                }
           
            
            
            }
       
        
        }
    
    }
}
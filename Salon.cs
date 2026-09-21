using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1Taller
{
    internal class Salon
    {

        public string nombreSalon;
        public List<Alumno> alumnos;

        public Salon(string nombre)
        {
            this.nombreSalon = nombre;
            this.alumnos = new List<Alumno>();
        }

        public void RegistrarAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);
        }

        public bool RemoverAlumno(string nombre)
        {
            Alumno alumnoAEncontrar = null;

            for (int i = 0; i < alumnos.Count; i++)
            {
                if (alumnos[i].nombre == nombre)
                {
                    alumnoAEncontrar = alumnos[i];
                    break;
                }
            }

            if (alumnoAEncontrar != null)
            {
                return alumnos.Remove(alumnoAEncontrar);
            }
            else
            {
                return false;
            }


        }

        public int CantidadDeAprobados()
        {
            int cantidad = 0;
            for (int i = 0; i < alumnos.Count; i++)
            {
                if (alumnos[i].PromedioTLS() >= 12.5f )
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        public int CantidadDeDesaprobados()
        {
            int cantidad = 0;
            for (int i = 0; i < alumnos.Count; i++)
            {
                if (alumnos[i].PromedioTLS() < 12.5f )
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        public List<Alumno> ObtenerAprobados()
        {
            List<Alumno> aprobados = new List<Alumno>();
            for (int i = 0; i < alumnos.Count; i++)
            {
                if (alumnos[i].PromedioTLS() >= 12.5f)
                {
                    aprobados.Add(alumnos[i]);
                }
            }
            return aprobados;
        }

        public List<Alumno> ObtenerDesaprobados()
        {
            List<Alumno> desaprobados = new List<Alumno>();
            for (int i = 0; i < alumnos.Count; i++)
            {
                if (alumnos[i].PromedioTLS() < 12.5f)
                {
                    desaprobados.Add(alumnos[i]);
                }
            }
            return desaprobados;
        }

        public float CalcularPromedioSalon()
        {
            if (alumnos.Count == 0) return 0.0f;
            
            float sumaPromedios = 0;

            for (int i = 0; i < alumnos.Count; i++)
            {
                sumaPromedios += alumnos[i].PromedioTLS();
            }
            return sumaPromedios/alumnos.Count;

        }





        
        



    }
}

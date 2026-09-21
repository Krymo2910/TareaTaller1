using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1Taller
{
    internal class Alumno
    {
        public string nombre;
        public float nota1;
        public float nota2;
        public float nota3;
        public Alumno(string nombre, float nota1, float nota2, float nota3)
        {
            this.nombre = nombre;
            this.nota1 = nota1;
            this.nota2 = nota2; 
            this.nota3 = nota3;
        }

        public float PromedioTLS()
        {
            return (nota1 + nota2 + (2 * nota3) )/4;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>();
            alumnos.Add(new Alumno("Roberto" , "189222"));
            alumnos.Add(new Alumno("Ana", "189223"));
            alumnos.Add(new Alumno("Karina", "189224"));
            alumnos.Add(new Alumno("Juan", "189225"));
            alumnos.Add(new Alumno("Nicolás", "189226"));

            foreach(Alumno alumno in alumnos)
            {
                Console.WriteLine("Nombre:     " + alumno.Nombre + "\nMatrícula:  " + alumno.Matricula + "\n");
            }

            Console.ReadLine();
        }
    }
}

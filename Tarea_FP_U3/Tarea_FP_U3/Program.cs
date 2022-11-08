using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_FP_U3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //edicion de consola
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            //declaracion de variables 
            string nameAlumno, matricula, nameMateria;
            int calificacion;

            //Inicio del codigo
            Console.WriteLine("Introducir Nombre completo del alumno");
            nameAlumno = Console.ReadLine();
            Console.WriteLine("Introducir la Matricula del alumno");
            matricula = Console.ReadLine();
            Console.WriteLine("Introducuir Materia a calificar");
            nameMateria = Console.ReadLine();
            Console.WriteLine("Calificacion del alumno");
            calificacion = Convert.ToInt16(Console.ReadLine());

            //Bloques de If/else
            if (calificacion >= 70)
            {
                Console.WriteLine("El alumno {0} \n con la matricula {1} ah aprobado la materia de {2} \n con una calificacion de {3}", nameAlumno, matricula, nameMateria, calificacion);
            }
            else if (calificacion < 70)
            {
                Console.WriteLine("su calificacion no es aprovatoria y necesita recursar la materia de {0}", nameMateria);
            }
            Console.Read();
        }
    }
}

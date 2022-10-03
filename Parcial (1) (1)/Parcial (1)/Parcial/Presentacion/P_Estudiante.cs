using System;
using Logica;

namespace Presentacion
{
    public class P_Estudiante
    {
        protected ServicioEstudiante servicio = new ServicioEstudiante();
        
        public static void PresentarPromedio()
        {
            Console.Clear();

            Console.Write("Escriba la materia a calcular promedio: ");
            var materia = Console.ReadLine().ToUpper();
            
            Console.WriteLine(ServicioEstudiante.Promedio(materia));
            Console.Write("Escriba ENTER para continuar... ");Console.ReadKey();
        }

        public static void PresentarDestacado()
        {
            Console.Clear();

            Console.Write("Escriba la materia a conocer estudiantes destacados: ");
            var materia = Console.ReadLine().ToUpper();
            
            Console.WriteLine(ServicioEstudiante.Destacado(materia));
            Console.Write("Escriba ENTER para continuar... ");Console.ReadKey();
        }
    }
}
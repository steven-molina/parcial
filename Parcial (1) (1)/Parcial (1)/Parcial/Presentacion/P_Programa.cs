using System;
using System.Linq.Expressions;

namespace Presentacion
{
    public class P_Programa
    {
        private P_Postgrado p_Post = new P_Postgrado();
        private P_Pregrado p_Pre = new P_Pregrado();

        public void Menu()
        {
            byte eleccion;
            
            do
            {


                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("1. ESTUDIANTES DE PREGRADO");
                Console.WriteLine("2. ESTUDIANTES DE POSTGRADO");
                Console.WriteLine("3. PROMEDIO POR PROGRAMA");
                Console.WriteLine("4. ESTUDIANTES DESTACADO");
                Console.WriteLine("5. Salir");    
                Console.Write("\nDigite una opción: ");
                eleccion = byte.Parse(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        p_Pre.Lista();
                        break;
                    case 2:
                        p_Post.Lista();
                        break;
                    case 3:
                        P_Estudiante.PresentarPromedio();
                        break;
                    case 4:
                        P_Estudiante.PresentarDestacado();
                        break;
                    case 5:
                        Console.WriteLine("\nGracias por usar el programa");
                        break;
                }
            } while (eleccion != 5);
             
            
        }
    }
}
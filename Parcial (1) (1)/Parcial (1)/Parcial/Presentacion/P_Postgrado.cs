using System;
using System.Linq;
using Entidades;

namespace Presentacion
{
    public class P_Postgrado : P_Estudiante
    {
        public void Lista()
        {
            Console.Clear();
            Console.WriteLine("LISTA DE POSTGRADOS");

            Console.WriteLine($"DOCUMENTO\tNOMBRES Y APELLIDOS\t\t\tPROGRAMA\t\t     SEMESTRE\t     PROMEDIO");
            foreach (var post in servicio.Listar().Where(estudiante => estudiante.GetType() == typeof(Postgrado))
                         .Cast<Postgrado>())
            {
               
                Console.WriteLine($"{post.NoDocumento}\t{post.Nombre} {post.Apellido}\t\t{post.Programa}\t\t{post.Semestre}\t\t{post.PromedioSemestre}");

            }
            Console.Write("Digite cualquier letra para continuar... ");Console.ReadKey();
        }
    }
}
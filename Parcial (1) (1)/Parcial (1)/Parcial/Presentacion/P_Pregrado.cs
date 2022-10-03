using System;
using System.Linq;
using Entidades;

namespace Presentacion
{
    public class P_Pregrado: P_Estudiante
    {
        public void Lista()
        {
            Console.Clear();
            Console.WriteLine("LISTA DE PREGRADO");

            Console.WriteLine($"DOCUMENTO\tNOMBRES Y APELLIDOS\t\t\tPROGRAMA\tSEMESTRE\tNOTA 1\tNOTA 2\tNOTA 3");
            foreach (var pre in servicio.Listar().Where(estudiante => estudiante.GetType() == typeof(Pregrado)).Cast<Pregrado>())
            {
                Console.WriteLine($"{pre.NoDocumento}\t{pre.Nombre} {pre.Apellido}\t\t {pre.Programa}  \t{pre.Semestre}\t\t{pre.PromedioCorte1}\t{pre.PromedioCorte2}\t{pre.PromedioCorte3}");
                
            }

            Console.Write("Digite cualquier letra para continuar... ");Console.ReadKey();
        }
    }
}
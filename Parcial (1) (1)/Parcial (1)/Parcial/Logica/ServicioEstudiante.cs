using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Datos;
using Entidades;

namespace Logica
{
    public class ServicioEstudiante
    {
        private static List<Estudiante> estudiantes;
        private Archivos archivo;

        private static List<string> materiasPre = new List<string>
        {
            "SISTEMAS", "DERECHO", "ENFERMERIA", "LICENCIATURA", "MUSICA"
        };

        private static List<string> materiasPost = new List<string>()
        {
            "DESARROLLO SOFTWARE", "DERECHO", "ADMINISTRATIVO", "AUDITORIA EN SALUD"
        };

        public ServicioEstudiante()
        {
            estudiantes = new List<Estudiante>();
            archivo = new Archivos("Registro-Academico.dat");
            CargarDatos();
        }

        public List<Estudiante> Listar()
        {
            return estudiantes;
        }

        private void CargarDatos()
        {
            estudiantes = archivo.CargarContactos();
        }

        public static string Promedio(string materia)
        {
            double promedio = 0;
            var cantEstudiantes = 0;

            foreach (var estudiante in estudiantes)
            {
                if (estudiante.Programa.Equals(materia) && materiasPre.Contains(materia))
                {
                    var es = (Pregrado)estudiante;
                    var promEstudiantes = (es.PromedioCorte1 + es.PromedioCorte2 + es.PromedioCorte3) / 3;
                    promedio += promEstudiantes;
                    cantEstudiantes += 1;
                }
                else if (estudiante.Programa.Equals(materia) && materiasPost.Contains(materia))
                {
                    var es = (Postgrado)estudiante;
                    promedio += es.PromedioSemestre;
                    cantEstudiantes += 1;
                }
            }

            var promedioFinal = promedio / cantEstudiantes;
            return $"El promedio de {materia} es {promedioFinal}";
        }

        public static string Destacado(string materia)
        {
            double promMaximo = 0;
            string destacado = "";
            foreach (var estudiante in estudiantes)
            {
                double promEstudiante;
                if (estudiante.Programa.Equals(materia) && materiasPre.Contains(materia))
                {
                    var es = (Pregrado)estudiante;
                    promEstudiante = (es.PromedioCorte1 + es.PromedioCorte2 + es.PromedioCorte3) / 3;

                    if (!(promEstudiante > promMaximo)) continue;
                    promMaximo = promEstudiante;
                    destacado = es.Nombre;
                }
                else if (estudiante.Programa.Equals(materia) && materiasPost.Contains(materia))
                {
                    var es = (Postgrado)estudiante;
                    promEstudiante = es.PromedioSemestre;

                    if (!(promEstudiante > promMaximo)) continue;
                    promMaximo = promEstudiante;
                    destacado = es.Nombre;
                }
            }
            return $"El estudiante destacado es {destacado}";
        }
    }
}
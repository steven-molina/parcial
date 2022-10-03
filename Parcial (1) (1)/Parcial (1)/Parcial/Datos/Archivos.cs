using System.Collections.Generic;
using System.IO;
using Entidades;

namespace Datos
{
    public class Archivos
    {
        private string ruta;
        private Estudiante estudiante;
        public Archivos(string ruta)
        {
            this.ruta = ruta;
        }

        public List<Estudiante> CargarContactos()
        {

            var rd = new StreamReader(ruta);
            var estudiantes = new List<Estudiante>();

            var dato = rd.ReadLine();
            while (dato != null)
            {
                var id = dato.Split(';')[0];
                if (id == "PRE")
                {
                    estudiante = new Pregrado();
                    estudiante.CargarDatos(dato.Split(';'));
                }
                else
                {
                    estudiante = new Postgrado();
                    estudiante.CargarDatos(dato.Split(';'));
                }
                estudiantes.Add(estudiante);
                dato = rd.ReadLine();
            }
            
            rd.Close();
            return estudiantes;
        }
    }
}
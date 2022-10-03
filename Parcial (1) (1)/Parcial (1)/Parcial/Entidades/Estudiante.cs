using System;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public abstract class Estudiante
    {
        public int NoDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Programa { get; set; }
        public int Semestre { get; set; }

        public Estudiante()
        {
            
        }

        public Estudiante(int noDocumento, string nombre, string apellido, string programa, int semestre)
        {
            this.NoDocumento = noDocumento;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Programa = programa;
            this.Semestre = semestre;

        }

        public virtual void CargarDatos(string[] data)
        {
            this.NoDocumento = int.Parse(data[1]);
            this.Nombre = data[2];
            this.Apellido = data[3];
            this.Programa = data[4];
            this.Semestre = int.Parse(data[5]);
        }
    }
}
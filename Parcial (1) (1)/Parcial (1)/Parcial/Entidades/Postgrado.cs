namespace Entidades
{
    public class Postgrado: Estudiante
    {

        public double PromedioSemestre { get; set; }
        
        public Postgrado()
        {
            
        }
        
        public Postgrado(int noDocumento, string nombre, string apellido, string programa, int semestre, double promedioSemestre
        ): base(noDocumento, nombre, apellido, programa, semestre)
        {
            PromedioSemestre = promedioSemestre;
        }
        
        public override string ToString()
        {
            return $"POST;{NoDocumento};{Nombre};{Apellido};{Programa};{Semestre};{PromedioSemestre}";
        }

        public override void CargarDatos(string[] data)
        {
            base.CargarDatos(data);
            PromedioSemestre = double.Parse(data[6]);
        }
    }
}
using System;

namespace Zoo.Models
{
    public class Especies
    {
        public string nombre_espanol { get; set; } = string.Empty;
        public string nombre_cientifico { get; set; } = string.Empty;
        public string descripcion { get; set; } = string.Empty;
        public Zonas zona { get; set; }
        
        public Especies(string nombre_espanol, string nombre_cientifico, string descripcion, Zonas zona)
        {
            this.nombre_espanol = nombre_espanol;
            this.nombre_cientifico = nombre_cientifico;
            this.descripcion = descripcion;
            this.zona = zona;
        }
    }
}
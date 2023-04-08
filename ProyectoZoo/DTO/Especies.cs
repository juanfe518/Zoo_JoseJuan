namespace Zoo.DTO
{
    public class Especies
    {
        public int? id_Especie { get; set; }
        public string nombre_espanol { get; set; } = string.Empty;
        public string nombre_cientifico { get; set; } = string.Empty;
        public string descripcion { get; set; } = string.Empty;
        public int id_zona { get; set; }
        public Especies()
        {
            
        }
        
        public Especies(int? id_Especie, string nombre_espanol, string nombre_cientifico, string descripcion, int id_zona)
        {
            this.id_Especie = id_Especie;
            this.nombre_espanol = nombre_espanol;
            this.nombre_cientifico = nombre_cientifico;
            this.descripcion = descripcion;
            this.id_zona = id_zona;
        }
    }
}
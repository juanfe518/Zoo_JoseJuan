namespace Zoo.DTO
{
    public class Zonas
    {
        public string? _Id_Zona { get; set; }
        public string _nombre_zona { get; set; }
        public int _extencion { get; set; }

        public Zonas()
        {
            
        }

        public Zonas(string? Id_Zona, string nombre_zona, int extencion)
        {
            this._Id_Zona = Id_Zona;
            this._nombre_zona = nombre_zona;
            this._extencion = extencion;
        }
    }
}
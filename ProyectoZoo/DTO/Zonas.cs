namespace Zoo.DTO
{
    public class Zonas
    {
        public string _nombre_zona { get; set; } = string.Empty;
        public int _extencion { get; set; }

        public Zonas(string nombre_zona, int extencion)
        {
            this._nombre_zona = nombre_zona;
            this._extencion = extencion;
        }
    }
}
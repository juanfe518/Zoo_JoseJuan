using System.ComponentModel.DataAnnotations;
namespace Zoo.DTO
{
    public class TiposVegetacion
    {
        public int? _Id_Tipo_Vegetacion { get; set;}

        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string _Nombre_Vegetacion { get; set; }
        public string _Descripcion { get; set; }

        public TiposVegetacion()
        {
            
        }

        public TiposVegetacion(int? Id_Tipo_Vegetacion, string Nombre_Vegetacion, string Descripcion)
        {
            this._Id_Tipo_Vegetacion = Id_Tipo_Vegetacion;
            this._Nombre_Vegetacion = Nombre_Vegetacion;
            this._Descripcion = Descripcion;
        }

    }
}
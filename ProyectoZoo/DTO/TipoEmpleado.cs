using System.ComponentModel.DataAnnotations;
namespace Zoo.DTO
{
    public class TipoEmpleado
    {
        public string? Id_Tipo_Empleado { get; set;}

        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string Nombre_Tipo { get; set; }

        public TipoEmpleado()
        {
            
        }

        public TipoEmpleado(string? Id_Tipo_Empleado, string Nombre_Tipo)
        {
            this.Id_Tipo_Empleado = Id_Tipo_Empleado;
            this.Nombre_Tipo = Nombre_Tipo;
        }

    }
}
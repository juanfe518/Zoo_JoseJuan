using System.ComponentModel.DataAnnotations;
namespace Zoo.DTO
{
    public class Habitats
    {
        public int? id_Habitat { get; set;}

        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string Nombre_Habitat { get; set; }
        public int clima { get; set; }
        public int Id_Tipo_Vegetacion { get; set; }

        public Habitats()
        {
            
        }

        public Habitats(int? id_Habitat, string Nombre_Habitat, int clima, int Id_Tipo_Vegetacion)
        {
            this.id_Habitat = id_Habitat;
            this.Nombre_Habitat = Nombre_Habitat;
            this.Nombre_Habitat = Nombre_Habitat;
            this.clima = clima;
            this.Id_Tipo_Vegetacion = Id_Tipo_Vegetacion;
        }

    }
}
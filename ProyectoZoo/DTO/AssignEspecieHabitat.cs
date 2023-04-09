namespace Zoo.DTO
{
    public class AssignEspecieHabitat 
    {
        public int? Id_Especie_Habitat { get; set; }

        public int Id_Especie { get; set; }
        public int Id_Habitat { get; set; }

        public AssignEspecieHabitat(int? Id_Especie_Habitat, int Id_Especie, int Id_Habitat)
        {
            this.Id_Especie_Habitat = Id_Especie_Habitat;
            this.Id_Especie = Id_Especie;
            this.Id_Habitat = Id_Habitat;
        }
    }
}
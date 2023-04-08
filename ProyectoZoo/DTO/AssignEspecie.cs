namespace Zoo.DTO
{
    public class AssignEspecies 
    {
        public int Id_Especie_Empleado { get; set; }

        public int Id_Especie { get; set; }
        public int Id_Empleado { get; set; }

        public AssignEspecies(int Id_Especie_Empleado, int Id_Especie, int Id_Empleado)
        {
            this.Id_Especie_Empleado = Id_Especie_Empleado;
            this.Id_Especie = Id_Especie;
            this.Id_Empleado = Id_Empleado;
        }
    }
}
namespace Zoo.DTO
{
    public class Empleados
    {
        public string? id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefonto { get; set; }
       // public DateTime fecha_ingreso { get; set; }
        //public TipoEmpleado Id_Tipo_Empleado { get; set; }
        public int Id_Tipo_Empleado { get; set; }

        public Empleados()
        {
            
        }
        
        public Empleados(string? id, string nombre, string direccion, string telefonto, /*DateTime fecha_ingreso,*/ int Id_Tipo_Empleado)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefonto = telefonto;
            //this.fecha_ingreso = fecha_ingreso;
            this.Id_Tipo_Empleado = Id_Tipo_Empleado;
        }
    }
}
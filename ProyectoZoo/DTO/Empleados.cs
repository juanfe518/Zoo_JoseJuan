namespace Zoo.DTO
{
    public class Empleados
    {
        public int? id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string direccion { get; set; } = string.Empty;
        public string telefonto { get; set; } = string.Empty;
        public DateTime fecha_ingreso { get; set; }
        public TipoEmpleado Id_Tipo_Empleado { get; set; }
        
        public Empleados(int id, string nombre, string direccion, string telefonto, DateTime fecha_ingreso, TipoEmpleado Id_Tipo_Empleado)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefonto = telefonto;
            this.fecha_ingreso = fecha_ingreso;
            this.Id_Tipo_Empleado = Id_Tipo_Empleado;
        }
    }
}
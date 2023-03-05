using System;

namespace Zoo.Models
{
    public class Empleados
    {
        public string nombre { get; set; } = string.Empty;
        public string direccion { get; set; } = string.Empty;
        public string telefonto { get; set; } = string.Empty;
        public DateTime fecha_ingreso { get; set; }
        
        public Empleados(string nombre, string direccion, string telefonto, DateTime fecha_ingreso)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefonto = telefonto;
            this.fecha_ingreso = fecha_ingreso;
        }
    }
}
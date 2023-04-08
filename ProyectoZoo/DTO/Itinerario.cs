using System.ComponentModel.DataAnnotations;
namespace Zoo.DTO
{
    public class Itinerario
    {
        public int? _id_Itinerario { get; set;}

        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string _codigo { get; set; }
        public string _fecha_Hora_Inicio { get; set; }
        public string _fecha__Hora_Fin { get; set; }
        public int _longitud_Itinerario { get; set; }
        public int _maximo_Nnumero_Visitantes { get; set; }
        public int _id_Empleado {get; set; }


        public Itinerario()
        {
            
        }

        public Itinerario(int? id_Itinerario, string codigo, string fecha_Hora_Inicio, string fecha__Hora_Fin, int longitud_Itinerario, int maximo_Nnumero_Visitantes, int id_Empleado)
        {
            this._id_Itinerario = id_Itinerario;
            this._codigo = codigo;
            this._fecha_Hora_Inicio = fecha_Hora_Inicio;
            this._fecha__Hora_Fin = fecha__Hora_Fin;
            this._longitud_Itinerario = longitud_Itinerario;
            this._maximo_Nnumero_Visitantes = maximo_Nnumero_Visitantes;
            this._id_Empleado = id_Empleado;
        }

    }
}
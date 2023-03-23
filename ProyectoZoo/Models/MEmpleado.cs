using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zoo.DTO;

namespace Zoo.Models
{
    public class MEmpleado
    {
        public MEmpleado(){}

        public RespuestaDTO AddEmpleado(Empleados empleado)
        {
            string queryInsert = "INSERT INTO public.Empleado(Nombre, Direccion, Telefono, Fecha_Ingreso, Id_Tipo_Empleado) VALUES ('" + empleado.nombre +"', '" + empleado.direccion +"', '" + empleado.telefonto +"', '" + empleado.fecha_ingreso +"', '" + empleado.Id_Tipo_Empleado +"') returning Id_Empleado;";
            MData data = new MData();
            RespuestaDTO respuestaBD = data.execute(queryInsert);
            JArray array = JArray.Parse(respuestaBD.data);
            JObject perso = JObject.Parse(Convert.ToString(array[0]));
            empleado.id = Convert.ToInt32(perso["Id_Empleado"]);

            return new RespuestaDTO(true, JsonConvert.SerializeObject(empleado), "");
        }
    }
}
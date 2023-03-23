using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zoo.DTO;

namespace Zoo.Models
{
    public class MTipoEmpleado
    {
        public MTipoEmpleado(){}

        public RespuestaDTO AddTipoEmpleado(TipoEmpleado tipoEmpleado)
        {
            string queryInsert = "INSERT INTO public.Tipo_Empleado(Nombre_Tipo) VALUES ('" + tipoEmpleado.Nombre_Tipo + "') returning id_Tipo_Empleado;";
            MData mData = new MData();
            RespuestaDTO respuestaBD = mData.execute(queryInsert);
            JArray array = JArray.Parse(respuestaBD.data);
            JObject perso = JObject.Parse(Convert.ToString(array[0]));
            tipoEmpleado.Id_Tipo_Empleado = Convert.ToString(perso["id_Tipo_Empleado"]);

            return new RespuestaDTO(true, JsonConvert.SerializeObject(tipoEmpleado), "");
        }
    }
}
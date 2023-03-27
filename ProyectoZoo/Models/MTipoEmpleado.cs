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
            String queryInsert = "INSERT INTO public.\"Tipo_Empleado\"(\"Nombre_Tipo\") VALUES ('" + tipoEmpleado.Nombre_Tipo + "') returning \"id_Tipo_Empleado\";";
            MData data = new MData();     
            RespuestaDTO responseBD = data.execute(queryInsert);  
            JArray array = JArray.Parse(responseBD.data);
            JObject dep = JObject.Parse(Convert.ToString(array[0]));
            tipoEmpleado.Id_Tipo_Empleado = Convert.ToString(dep["id_Tipo_Empleado"]);

            return new RespuestaDTO(true, JsonConvert.SerializeObject(tipoEmpleado), "");
        }
    }
}
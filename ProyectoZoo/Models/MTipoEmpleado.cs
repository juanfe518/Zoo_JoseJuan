using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zoo.DTO;

namespace Zoo.Models
{
    public class MTipoEmpleado
    {
        public MTipoEmpleado() { }

        public RespuestaDTO AddTipoEmpleado(TipoEmpleado tipoEmpleado)
        {
            String queryInsert = "INSERT INTO public.\"Tipo_Empleado\"(\"Nombre_Tipo\") VALUES ('" + tipoEmpleado.Nombre_Tipo + "') returning \"id_Tipo_Empleado\";";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(queryInsert);
            JArray array = JArray.Parse(responseBD.data);
            JObject tipo = JObject.Parse(Convert.ToString(array[0]));
            //tipoEmpleado.Id_Tipo_Empleado = Convert.ToString(tipo["id_Tipo_Empleado"]);

            return new RespuestaDTO(true, JsonConvert.SerializeObject(tipoEmpleado), "");
        }

        public RespuestaDTO GetTiposEmpleados()
        {
            String queryGet = "SELECT * FROM public.\"Tipo_Empleado\";";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(queryGet);
            return responseBD;
        }
        public RespuestaDTO GetTipoEmpleado(int id_Tipo_Empleado)
        {
            string query = "SELECT \"Id_Tipo_Vegetacion\", \"Nombre\", \"Descripcion\" FROM public.\"Tipo_Vegetacion\" where \"Id_Tipo_Vegetacion\" = '" + id_Tipo_Empleado + "';";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(query);
            return responseBD;
        }

        public RespuestaDTO UpdateTipoEmpleado(TipoEmpleado tipoempleado)
        {

            String queryUpdate = "UPDATE public.\"Tipo_Empleado\" SET \"Nombre\" = '" + tipoempleado.Nombre_Tipo + "',\"Id_TipoEmpleado\" = '" + tipoempleado.Id_Tipo_Empleado + "';";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(queryUpdate);
            return new RespuestaDTO(true, JsonConvert.SerializeObject(tipoempleado), "");
        }

        public RespuestaDTO DeleteTipoEmpleado(int id_Tipo_Empleado)
        {

            String queryDelete = "DELETE FROM public.\"TipoEmpleado\" WHERE \"Id_TipoEmpleado\" = '" + id_Tipo_Empleado + "';";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(queryDelete);
            return new RespuestaDTO(true, "", "");
        }
    }
}
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zoo.DTO;

namespace Zoo.Models
{
    public class MTipoVegetacion
    {
        public MTipoVegetacion() { }

        public RespuestaDTO AddTipoVegetacion(TiposVegetacion tipoVegetacion)
        {
            String queryInsert = "INSERT INTO public.\"Tipo_Vegetacion\"(\"Nombre\", \"Descripcion\") VALUES ('" + tipoVegetacion._Nombre_Vegetacion + "', '" + tipoVegetacion._Descripcion + "') returning \"Id_Tipo_Vegetacion\";";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(queryInsert);
            JArray array = JArray.Parse(responseBD.data);
            JObject tipoV = JObject.Parse(Convert.ToString(array[0]));
            //tipoVegetacion._Id_Tipo_Vegetacion = Convert.ToString(tipoV["Id_Tipo_Vegetacion"]);

            return new RespuestaDTO(true, JsonConvert.SerializeObject(tipoVegetacion), "");
        }

        public RespuestaDTO GetTiposVegetacion()
        {
            String queryGet = "SELECT * FROM public.\"Tipo_Vegetacion\";";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(queryGet);
            return responseBD;
        }
        public RespuestaDTO GetTipoVegetacion(int id_Tipo_Vegetacion)
        {
            string query = "SELECT \"Id_Tipo_Vegetacion\", \"Nombre\", \"Descripcion\" FROM public.\"Tipo_Vegetacion\" WHERE \"Id_Tipo_Vegetacion\" = '" + id_Tipo_Vegetacion + "';";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(query);
            return responseBD;
        }

        public RespuestaDTO UpdateTipoVegetacion(TiposVegetacion tipoVegetacion)
        {

            String queryUpdate = "UPDATE public.\"TipoVegetacion\" SET \"Nombre_Vegetacion\" = '" + tipoVegetacion._Nombre_Vegetacion + "',\"Descripcion\" = '" + tipoVegetacion._Descripcion + "';";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(queryUpdate);
            return new RespuestaDTO(true, JsonConvert.SerializeObject(tipoVegetacion), "");
        }

        public RespuestaDTO DeleteTipoVegetacion(int id_Tipo_Vegetacion)
        {

            String queryDelete = "DELETE FROM public.\"TipoVegtacion\" WHERE \"Id_Tipo_Vegetacion\" = '" + id_Tipo_Vegetacion + "';";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(queryDelete);
            return new RespuestaDTO(true, "", "");
        }
    }
}
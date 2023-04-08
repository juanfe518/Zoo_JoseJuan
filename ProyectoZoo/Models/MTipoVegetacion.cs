using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zoo.DTO;

namespace Zoo.Models
{
    public class MTipoVegetacion
    {
        public MTipoVegetacion(){}

        public RespuestaDTO AddTipoVegetacion(TiposVegetacion tipoVegetacion)
        {
            String queryInsert = "INSERT INTO public.\"Tipo_Vegetacion\"(\"Nombre\", \"Descripcion\") VALUES ('"+ tipoVegetacion._Nombre_Vegetacion +"', '"+ tipoVegetacion._Descripcion +"') returning \"Id_Tipo_Vegetacion\";";
            MData data = new MData();     
            RespuestaDTO responseBD = data.execute(queryInsert);  
            JArray array = JArray.Parse(responseBD.data);
            JObject tipoV = JObject.Parse(Convert.ToString(array[0]));
            //tipoVegetacion._Id_Tipo_Vegetacion = Convert.ToString(tipoV["Id_Tipo_Vegetacion"]);

            return new RespuestaDTO(true, JsonConvert.SerializeObject(tipoVegetacion), "");
        }
    }
}
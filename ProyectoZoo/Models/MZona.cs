using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zoo.DTO;

namespace Zoo.Models
{
    public class MZona
    {
        public MZona(){}

        public RespuestaDTO AddZona(Zonas zona)
        {
            String queryInsert = "INSERT INTO public.\"Zonas\"(\"Nombre_Zona\", \"Extencion\") VALUES ('"+ zona._nombre_zona +"', '"+ zona._extencion +"') returning \"Id_Zona\";";
            MData data = new MData();     
            RespuestaDTO responseBD = data.execute(queryInsert);  
            JArray array = JArray.Parse(responseBD.data);
            JObject tipo = JObject.Parse(Convert.ToString(array[0]));
            zona._Id_Zona = Convert.ToString(tipo["Id_Zona"]);

            return new RespuestaDTO(true, JsonConvert.SerializeObject(zona), "");
        }
    }
}
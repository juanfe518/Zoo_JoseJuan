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
            //zona._Id_Zona = Convert.ToString(tipo["Id_Zona"]);

            return new RespuestaDTO(true, JsonConvert.SerializeObject(zona), "");
        }

        public RespuestaDTO GetZonas() {
            String queryGet = "SELECT * FROM public.\"Zonas\";";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(queryGet);
            return responseBD;

        } 

        public RespuestaDTO GetZona(string id_Zona) {
            string query = "SELECT \"Id_Zona\", \"Nombre_Zona\",\"Extension\", "+ id_Zona +";";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(query);
            return responseBD;
        }

        public RespuestaDTO UpdateZona(Zonas Zona) {

            String queryUpdate = "UPDATE public.\"Zona\" SET \"Nombre_Zona\" = '"+Zona._nombre_zona+"', \"Extension\" = '"+Zona._extencion+"';";
            MData data = new MData();     
            RespuestaDTO responseBD = data.execute(queryUpdate);  
            return new RespuestaDTO (true, JsonConvert.SerializeObject(Zona), ""); 
        }

        public RespuestaDTO DeleteZona(int id_Zona) {

            String queryDelete = "DELETE FROM public.\"Zonas\" WHERE \"Id_Zonas\" = '"+id_Zona+"';";
            MData data = new MData();     
            RespuestaDTO responseBD = data.execute(queryDelete);  
            return new RespuestaDTO (true, "", ""); 
        }
    }
}
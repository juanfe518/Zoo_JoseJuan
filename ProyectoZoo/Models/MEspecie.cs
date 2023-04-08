using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zoo.DTO;

namespace Zoo.Models
{
    public class MEspecie
    {
        public MEspecie(){}

        public RespuestaDTO AddEspecie(Especies especie)
        {
            string queryInsert = "INSERT INTO public.\"Especies\"(\"Nombre_Espanol\", \"Nombre_Cientifico\", \"Descripcion\", \"Id_Zona\") VALUES ('" + especie.nombre_espanol +"', '" + especie.nombre_cientifico +"', '" + especie.descripcion +"', '" + especie.id_zona +"') returning \"Id_Especie\";";
            MData data = new MData();
            RespuestaDTO respuestaBD = data.execute(queryInsert);
            JArray array = JArray.Parse(respuestaBD.data);
            JObject espe = JObject.Parse(Convert.ToString(array[0]));
            //especie.id_Especie = Convert.ToString(espe["Id_Especie"]);

            return new RespuestaDTO(true, JsonConvert.SerializeObject(especie), "");
        }

        public RespuestaDTO GetEspecies() {
            String queryGet = "SELECT * FROM public.\"Especies\";";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(queryGet);
            return responseBD;

        } 

        public RespuestaDTO GetEspecie(string id_Especie) {
            string query = "SELECT \"Id_Especie\", \"Nombre_Espanol\",\"Nombre_Cientifico\", \"Descripcion\",ESP.\"Id_Zona\", ZON.\"Nombre_Zona\" FROM public.\"Especies\" ESP INNER JOIN public.\"Zonas\" ZON ON ZON.\"Id_Zona\" = ESP.\"Id_Zona\" WHERE ESP.\"Id_Especie\" = '"+ id_Especie +"';";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(query);
            return responseBD;
        }

        public RespuestaDTO UpdateEspecie(Especies especie) {

            String queryUpdate = "UPDATE public.\"Especie\" SET \"Nombre_Espanol\" = '"+especie.nombre_espanol+"', \"Nombre_Cientifico\" = '"+especie.nombre_cientifico+"', \"Descripcion\" = '"+especie.descripcion+"', \"Id_Zona\" = '"+especie.id_zona+"' WHERE \"Id_Especie\" = '"+especie.id_Especie+"';";
            MData data = new MData();     
            RespuestaDTO responseBD = data.execute(queryUpdate);  
            return new RespuestaDTO (true, JsonConvert.SerializeObject(especie), ""); 
        }

        public RespuestaDTO DeleteEspecie(int id_Especie) {

            String queryDelete = "DELETE FROM public.\"Especies\" WHERE \"Id_Especie\" = '"+id_Especie+"';";
            MData data = new MData();     
            RespuestaDTO responseBD = data.execute(queryDelete);  
            return new RespuestaDTO (true, "", ""); 
        }


    }
}
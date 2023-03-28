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
            especie.id_Especie = Convert.ToString(espe["Id_Especie"]);

            return new RespuestaDTO(true, JsonConvert.SerializeObject(especie), "");
        }
    }
}
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zoo.DTO;

namespace Zoo.Models
{
    public class MHabitats
    {
        public MHabitats(){}

        public RespuestaDTO AddHabitat(Habitats habitat)
        {
            String queryInsert = "INSERT INTO public.\"Habitats\"(\"Nombre\", \"Clima\", \"Id_Tipo_Vegetacion\") VALUES ('"+ habitat.Nombre_Habitat +"', '"+ habitat.clima +"', '"+ habitat.Id_Tipo_Vegetacion +"') returning \"id_Habitat\";";
            MData data = new MData();     
            RespuestaDTO responseBD = data.execute(queryInsert);  
            JArray array = JArray.Parse(responseBD.data);
            JObject habit = JObject.Parse(Convert.ToString(array[0]));
            //habitat.id_Habitat = Convert.ToString(habit["id_Habitat"]);

            return new RespuestaDTO(true, JsonConvert.SerializeObject(habitat), "");
        }
    }
}
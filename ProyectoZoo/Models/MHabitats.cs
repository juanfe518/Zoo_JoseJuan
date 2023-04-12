using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zoo.DTO;

namespace Zoo.Models
{
    public class MHabitats
    {
        public MHabitats() { }

        public RespuestaDTO AddHabitat(Habitats habitat)
        {
            String queryInsert = "INSERT INTO public.\"Habitats\"(\"Nombre\", \"Clima\", \"Id_Tipo_Vegetacion\") VALUES ('" + habitat.Nombre_Habitat + "', '" + habitat.clima + "', '" + habitat.Id_Tipo_Vegetacion + "') returning \"id_Habitat\";";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(queryInsert);
            JArray array = JArray.Parse(responseBD.data);
            JObject habit = JObject.Parse(Convert.ToString(array[0]));
            //habitat.id_Habitat = Convert.ToString(habit["id_Habitat"]);

            return new RespuestaDTO(true, JsonConvert.SerializeObject(habitat), "");
        }

        public RespuestaDTO GetHabitats()
        {
            String queryGet = "SELECT * FROM public.\"Habitat\";";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(queryGet);
            return responseBD;
        }

        public RespuestaDTO GetHabitat(int id_Habitat)
        {
            string query = "SELECT \"id_Habitat\", \"Nombre\", \"Clima\", \"Id_Tipo_Vegetacion\" FROM public.\"Habitats\" WHERE \"id_Habitat\" =  '" + id_Habitat + "';";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(query);
            return responseBD;
        }

        public RespuestaDTO UpdateHabitat(Habitats habitat)
        {

            String queryUpdate = "UPDATE public.\"Habitat\" SET \"Nombre\" = '" + habitat.Nombre_Habitat + "', \"Clima\" = '" + habitat.clima + "', \"Id_Tipo_Vegetacion\" = '" + habitat.Id_Tipo_Vegetacion + "' WHERE \"Id_Habitat\" = '" + habitat.id_Habitat + "';";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(queryUpdate);
            return new RespuestaDTO(true, JsonConvert.SerializeObject(habitat), "");
        }

        public RespuestaDTO DeleteHabitat(int id_Habitat)
        {

            String queryDelete = "DELETE FROM public.\"Habitat\" WHERE \"Id_Habitat\" = '" + id_Habitat + "';";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(queryDelete);
            return new RespuestaDTO(true, "", "");
        }
    }
}
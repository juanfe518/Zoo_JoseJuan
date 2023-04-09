using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zoo.DTO;

namespace Zoo.Models
{
    public class MAssignEspecieHabitat
    {
        public MAssignEspecieHabitat(){}

        public RespuestaDTO AssignEspecieHabitat(AssignEspecieHabitat asignarEspecieHabitat)
        {
            String queryInsert = "INSERT INTO public.\"Especies_Habitats\"( \"Id_Especie\", \"Id_Habitat\") VALUES ('"+asignarEspecieHabitat.Id_Especie+"', '"+asignarEspecieHabitat.Id_Habitat+"') returning \"Id_Especie_Habitat\";";
            MData data = new MData();
            RespuestaDTO respuestaBD = data.execute(queryInsert);
            JArray array = JArray.Parse(respuestaBD.data);
            JObject emple = JObject.Parse(Convert.ToString(array[0]));
            //empleado.id = Convert.ToInt32(emple["Id_Empleado"]);

            return new RespuestaDTO(true, JsonConvert.SerializeObject(asignarEspecieHabitat), "");
        }

        public RespuestaDTO GetEspeciesHabitats() {
            string query = "SELECT ESPHAB.\"Id_Especie_Habitat\", ESPHAB.\"Id_Especie\", ESP.\"Nombre_Espanol\", ESPHAB.\"Id_Habitat\", HAB.\"Nombre\" FROM public.\"Especies_Habitats\" ESPHAB LEFT OUTER JOIN public.\"Especies\" ESP ON ESP.\"Id_Especie\" = ESPHAB.\"Id_Especie\" LEFT OUTER JOIN public.\"Habitats\" HAB ON HAB.\"id_Habitat\" = ESPHAB.\"Id_Habitat\";";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(query);
            return responseBD;
        }

        public RespuestaDTO GetEspecieHabitat(int id) {
            string query = "SELECT ESPHAB.\"Id_Especie_Habitat\", ESPHAB.\"Id_Especie\", ESP.\"Nombre_Espanol\", ESPHAB.\"Id_Habitat\", HAB.\"Nombre\" FROM public.\"Especies_Habitats\" ESPHAB LEFT OUTER JOIN public.\"Especies\" ESP ON ESP.\"Id_Especie\" = ESPHAB.\"Id_Especie\" LEFT OUTER JOIN public.\"Habitats\" HAB ON HAB.\"id_Habitat\" = ESPHAB.\"Id_Habitat\" WHERE \"Id_Especie_Habitat\" = '"+ id +"';";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(query);
            return responseBD;
        }

        public RespuestaDTO EditAsignacionHabitat(AssignEspecieHabitat editarEspecieHab) {

            String queryUpdate = "UPDATE public.\"Especies_Habitats\" SET \"Id_Especie\" = '"+ editarEspecieHab.Id_Especie +"', \"Id_Habitat\" = '" + editarEspecieHab.Id_Habitat + "' WHERE \"Id_Especie_Habitat\" = '" + editarEspecieHab.Id_Especie_Habitat + "';";
            MData data = new MData();     
            RespuestaDTO responseBD = data.execute(queryUpdate);  
            return new RespuestaDTO (true, JsonConvert.SerializeObject(editarEspecieHab), ""); 
        }

        public RespuestaDTO DeleteAsignacion(int id) {

            String queryDelete = "DELETE FROM public.\"Especies_Habitats\" WHERE \"Id_Especie_Habitat\" = '"+id+"';";
            MData data = new MData();     
            RespuestaDTO responseBD = data.execute(queryDelete);  
            return new RespuestaDTO (true, "", ""); 
        }
    }
}
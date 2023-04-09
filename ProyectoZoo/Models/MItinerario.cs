using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zoo.DTO;

namespace Zoo.Models
{
    public class MItinerario
    {
        public MItinerario(){}

        public RespuestaDTO AddItinerario(Itinerario itinerario)
        {
            String queryInsert = "INSERT INTO public.\"Itinerario\"(\"Codigo\", \"Fecha_Hora_Inicio\", \"Fecha_Hora_Fin\", \"Longitud_Itinerario\", \"Maximo_Numero_Visitantes\", \"Id_Empleado\") VALUES ('"+ itinerario._codigo +"', '"+ itinerario._fecha_Hora_Inicio +"', '"+ itinerario._fecha__Hora_Fin +"', '"+ itinerario._longitud_Itinerario +"', '"+ itinerario._maximo_Nnumero_Visitantes +"', '"+ itinerario._id_Empleado +"') returning \"Id_Itinerario\";";
            MData data = new MData();     
            RespuestaDTO responseBD = data.execute(queryInsert);  
            JArray array = JArray.Parse(responseBD.data);
            JObject itiner = JObject.Parse(Convert.ToString(array[0]));
            //itinerario._id_Itinerario = Convert.ToString(itiner["Id_Itinerario"]);

            return new RespuestaDTO(true, JsonConvert.SerializeObject(itinerario), "");
        }

        public RespuestaDTO GetItinerarios() {
            String queryGet = "SELECT \"Id_Itinerario\", \"Codigo\", \"Fecha_Hora_Inicio\", \"Fecha_Hora_Fin\", \"Longitud_Itinerario\", \"Maximo_Numero_Visitantes\", ITI.\"Id_Empleado\", EMP.\"Nombre\" FROM public.\"Itinerario\" ITI LEFT OUTER JOIN public.\"Empleado\" EMP ON EMP.\"Id_Empleado\" = ITI.\"Id_Empleado\";";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(queryGet);
            return responseBD;
        } 

        public RespuestaDTO GetItinerario(int id) {
            string query = "SELECT \"Id_Itinerario\", \"Codigo\", \"Fecha_Hora_Inicio\", \"Fecha_Hora_Fin\", \"Longitud_Itinerario\", \"Maximo_Numero_Visitantes\", ITI.\"Id_Empleado\", EMP.\"Nombre\" FROM public.\"Itinerario\" ITI LEFT OUTER JOIN public.\"Empleado\" EMP ON EMP.\"Id_Empleado\" = ITI.\"Id_Empleado\" WHERE ITI.\"Id_Itinerario\" = '"+ id +"';";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(query);
            return responseBD;
        }

        public RespuestaDTO UpdateItinerario(Itinerario itinerario) {

            String queryUpdate = "UPDATE public.\"Itinerario\" SET \"Codigo\" = '"+itinerario._codigo+"', \"Fecha_Hora_Inicio\" = '"+itinerario._fecha_Hora_Inicio+"', \"Fecha_Hora_Fin\" = '"+itinerario._fecha__Hora_Fin+"', \"Longitud_Itinerario\" = '"+itinerario._longitud_Itinerario+"', \"Maximo_Numero_Visitantes\" = '"+itinerario._maximo_Nnumero_Visitantes+"', \"Id_Empleado\" = '"+itinerario._id_Empleado+"' WHERE \"Id_Itinerario\" = '"+itinerario._id_Itinerario+"';";
            MData data = new MData();     
            RespuestaDTO responseBD = data.execute(queryUpdate);  
            return new RespuestaDTO (true, JsonConvert.SerializeObject(itinerario), ""); 
        }

        public RespuestaDTO DeleteItinerario(int id) {

            String queryDelete = "DELETE FROM public.\"Itinerario\" WHERE \"Id_Itinerario\" = '"+id+"';";
            MData data = new MData();     
            RespuestaDTO responseBD = data.execute(queryDelete);  
            return new RespuestaDTO (true, "", ""); 
        }
    
    }
}
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
            itinerario._id_Itinerario = Convert.ToString(itiner["Id_Itinerario"]);

            return new RespuestaDTO(true, JsonConvert.SerializeObject(itinerario), "");
        }
    }
}
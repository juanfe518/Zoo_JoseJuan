using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zoo.DTO;

namespace Zoo.Models
{
    public class MAssignEspecies
    {
        public MAssignEspecies(){}

        public RespuestaDTO AssignEspecie(AssignEspecies asignarEspecie)
        {
            String queryInsert = "INSERT INTO public.\"Especies_Empleados\"(\"Id_Especie\", \"Id_Empleado\") VALUES ('"+asignarEspecie.Id_Especie+"', '"+asignarEspecie.Id_Empleado+"') returning \"Id_Especie_Empleado\";";
            MData data = new MData();
            RespuestaDTO respuestaBD = data.execute(queryInsert);
            JArray array = JArray.Parse(respuestaBD.data);
            JObject emple = JObject.Parse(Convert.ToString(array[0]));
            //empleado.id = Convert.ToInt32(emple["Id_Empleado"]);

            return new RespuestaDTO(true, JsonConvert.SerializeObject(asignarEspecie), "");
        }

        public RespuestaDTO GetEspeciesEmpleados() {
            string query = "SELECT ESPEMP.\"Id_Especie\", ESP.\"Nombre_Espanol\", ESPEMP.\"Id_Empleado\", EMP.\"Nombre\" FROM public.\"Especies_Empleados\" ESPEMP LEFT OUTER JOIN public.\"Especies\" ESP ON ESP.\"Id_Especie\" = ESPEMP.\"Id_Especie\" LEFT OUTER JOIN public.\"Empleado\" EMP ON EMP.\"Id_Empleado\" = ESPEMP.\"Id_Empleado\";";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(query);
            return responseBD;
        }

        public RespuestaDTO GetEspecieEmpleado(int id) {
            string query = "SELECT ESPEMP.\"Id_Especie\", ESP.\"Nombre_Espanol\", ESPEMP.\"Id_Empleado\", EMP.\"Nombre\" FROM public.\"Especies_Empleados\" ESPEMP LEFT OUTER JOIN public.\"Especies\" ESP ON ESP.\"Id_Especie\" = ESPEMP.\"Id_Especie\" LEFT OUTER JOIN public.\"Empleado\" EMP ON EMP.\"Id_Empleado\" = ESPEMP.\"Id_Empleado\" WHERE \"Id_Especie_Empleado\" = '"+ id +"';";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(query);
            return responseBD;
        }

        public RespuestaDTO EditAsignacion(AssignEspecies editarEspecie) {

            String queryUpdate = "UPDATE public.\"Especies_Empleados\" SET \"Id_Especie\" = '"+ editarEspecie.Id_Especie +"', \"Id_Empleado\" = '" + editarEspecie.Id_Especie + "' WHERE \"Id_Especie_Empleado\" = '" + editarEspecie.Id_Especie_Empleado + "';";
            MData data = new MData();     
            RespuestaDTO responseBD = data.execute(queryUpdate);  
            return new RespuestaDTO (true, JsonConvert.SerializeObject(editarEspecie), ""); 
        }

        public RespuestaDTO DeleteAsignacion(int id) {

            String queryDelete = "DELETE FROM public.\"Especies_Empleados\" WHERE \"Id_Especie_Empleado\" = '"+id+"';";
            MData data = new MData();     
            RespuestaDTO responseBD = data.execute(queryDelete);  
            return new RespuestaDTO (true, "", ""); 
        }
    }
}
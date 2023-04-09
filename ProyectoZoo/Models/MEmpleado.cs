using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zoo.DTO;

namespace Zoo.Models
{
    public class MEmpleado
    {
        public MEmpleado(){}

        public RespuestaDTO AddEmpleado(Empleados empleado)
        {
            String queryInsert = "INSERT INTO public.\"Empleado\"(\"Nombre\", \"Direccion\", \"Telefono\", \"Fecha_Ingreso\", \"Id_Tipo_Empleado\") VALUES ('"+empleado.nombre+"', '"+empleado.direccion+"', '"+empleado.telefonto+"', CURRENT_TIME, '"+empleado.Id_Tipo_Empleado+"') returning \"Id_Empleado\";";
            MData data = new MData();
            RespuestaDTO respuestaBD = data.execute(queryInsert);
            JArray array = JArray.Parse(respuestaBD.data);
            JObject emple = JObject.Parse(Convert.ToString(array[0]));
            //empleado.id = Convert.ToInt32(emple["Id_Empleado"]);

            return new RespuestaDTO(true, JsonConvert.SerializeObject(empleado), "");
        }

        public RespuestaDTO GetEmpleados() {
            String queryGet = "SELECT * FROM public.\"Empleado\";";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(queryGet);
            return responseBD;
        } 

        public RespuestaDTO GetEmpleado(string id) {
            string query = "SELECT \"Id_Empleado\", \"Nombre\", \"Direccion\", \"Telefono\", \"Fecha_Ingreso\", \"Id_Tipo_Empleado\", TEMPL.\"Nombre_Tipo\" FROM public.\"Empleado\" EMP INNER JOIN public.\"Tipo_Empleado\" TEMPL ON TEMPL.\"id_Tipo_Empleado\" = EMP.\"Id_Tipo_Empleado\" WHERE EMP.\"Id_Empleado\" = '"+ id +"';";
            MData data = new MData();
            RespuestaDTO responseBD = data.execute(query);
            return responseBD;
        }

        public RespuestaDTO UpdateEmpleado(Empleados empleado) {

            String queryUpdate = "UPDATE public.\"Empleado\" SET \"Nombre\" = '"+empleado.nombre+"', \"Direccion\" = '"+empleado.direccion+"', \"Telefono\" = '"+empleado.telefonto+"', CURRENT_TIME, \"Id_Tipo_Empleado\" = '"+empleado.Id_Tipo_Empleado+"' WHERE \"Id_Empleado\" = '"+empleado.id+"';";
            MData data = new MData();     
            RespuestaDTO responseBD = data.execute(queryUpdate);  
            return new RespuestaDTO (true, JsonConvert.SerializeObject(empleado), ""); 
        }

        public RespuestaDTO DeleteEmpleado(int id) {

            String queryDelete = "DELETE FROM public.\"Empleado\" WHERE \"Id_Empleado\" = '"+id+"';";
            MData data = new MData();     
            RespuestaDTO responseBD = data.execute(queryDelete);  
            return new RespuestaDTO (true, "", ""); 
        }
    }
}
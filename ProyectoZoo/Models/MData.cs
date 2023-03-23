using System.Data;
using Newtonsoft.Json;
using Npgsql;
using Zoo.DTO;

namespace Zoo.Models
{
    public class MData
    {
        public MData(){}

        public RespuestaDTO execute(string command)
        {
            RespuestaDTO respuesta = new RespuestaDTO(true, "", "");

            try 
            {
                //Crea la conexión
                NpgsqlConnection conex = new NpgsqlConnection("Server = localhost:5432; User Id = postgres; Password = password; Database = Zoo_Jose_Cano");
                conex.Open();

                //Definir el query
                NpgsqlCommand query = new NpgsqlCommand(command, conex);

                // Ejecutar la query
                NpgsqlDataReader dr = query.ExecuteReader();

                var dataTable = new DataTable();
                dataTable.Load(dr);

                respuesta.data = JsonConvert.SerializeObject(dataTable);

                return respuesta;
            }
            catch (System.Exception)
            {
                respuesta.respuesta = false;
                respuesta.error = "Error en la conexión";
                return respuesta;
            }
        }
    }
}
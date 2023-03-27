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
                // Creacion de la conexion
                NpgsqlConnection conn = new NpgsqlConnection("Server = localhost:5432; User Id = postgres; Password = password; Database = Zoo_Jose_Cano");
                conn.Open();

                // Definimos el query
                NpgsqlCommand query = new NpgsqlCommand(command, conn);

                // Ejecutar query
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
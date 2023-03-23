namespace Zoo.DTO
{
    public class RespuestaDTO
    {
        public bool respuesta { get; set; }
        public string data { get; set; }
        public string error { get; set; }

        public RespuestaDTO(bool respuesta, string data, string error)
        {
            this.respuesta = respuesta;
            this.data = data;
            this.error = error;
        }
        
    }
}
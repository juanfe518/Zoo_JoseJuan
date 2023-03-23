using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;
using Zoo.Models;
using Newtonsoft.Json;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("apizoo/")]
    public class EmpleadoController : Controller
    {
        public EmpleadoController(){}

        [HttpPost("addtipoempleado")]
        public async Task<IActionResult> AddTipoEmpleado(TipoEmpleado tipoEmpleado)
        {
            MTipoEmpleado mTipoEmpleado = new MTipoEmpleado();
            return Ok(mTipoEmpleado.AddTipoEmpleado(tipoEmpleado));
        }

        // [HttpGet("getempleados")]
        // public async Task<IActionResult> GetEmpleado()
        // {
        //     Empleados empleado = new Empleados("Jose", "calle 1", "123456", DateTime.Now);
        //     return Ok(empleado);
        // }

        // [HttpGet("getespecies")]
        // public async Task<IActionResult> GetEspecie()
        // {
        //     Zonas zonas = new Zonas("Zona oeste", 2);
        //     Especies especie = new Especies("Cebra", "Equus zebra", "Es un animal proveniente de la zabana Africana", zonas);
        //     return Ok(especie);
        // }

        // [HttpGet("getzonas")]
        // public async Task<IActionResult> GetZona()
        // {
        //     Zonas zona = new Zonas("Zona oeste", 2);
        //     return Ok(zona);
        // }
    }

    
}
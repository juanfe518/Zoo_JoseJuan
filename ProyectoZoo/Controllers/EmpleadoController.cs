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


        [HttpPost("addempleado")]
        public async Task<IActionResult> AddEmpleado(Empleados empleado)
        {
            MEmpleado mEmpleado = new MEmpleado();
            return Ok(mEmpleado.AddEmpleado(empleado));
        }

        [HttpGet("getempleados")]
        public async Task<IActionResult> GetEmpleados() {
            MEmpleado mEmpleado = new MEmpleado();
            return Ok(mEmpleado.GetEmpleados());
        }

        [HttpPost("addespecie")]
        public async Task<IActionResult> AddEspecie(Especies especie)
        {
            MEspecie mEspecie = new MEspecie();
            return Ok(mEspecie.AddEspecie(especie));
        }

        [HttpPost("additinerario")]
        public async Task<IActionResult> AddItinerario(Itinerario itinerario)
        {
            MItinerario mItinerario = new MItinerario();
            return Ok(mItinerario.AddItinerario(itinerario));
        }
        [HttpPost("addzona")]
        public async Task<IActionResult> AddZona(Zonas zona)
        {
            MZona mZona = new MZona();
            return Ok(mZona.AddZona(zona));
        }

        [HttpPost("addtipovegetacion")]
        public async Task<IActionResult> Addtipovegetacion(TiposVegetacion tipoVegetacion)
        {
            MTipoVegetacion mTipoVegetacion = new MTipoVegetacion();
            return Ok(mTipoVegetacion.AddTipoVegetacion(tipoVegetacion));
        }

        [HttpPost("addhabitat")]
        public async Task<IActionResult> Addhabitat(Habitats habitat)
        {
            MHabitats mHabitat = new MHabitats();
            return Ok(mHabitat.AddHabitat(habitat));
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
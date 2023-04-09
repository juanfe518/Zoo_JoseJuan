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

        // Agregar tipo empleado
        [HttpPost("addtipoempleado")]
        public async Task<IActionResult> AddTipoEmpleado(TipoEmpleado tipoEmpleado)
        {
            MTipoEmpleado mTipoEmpleado = new MTipoEmpleado();
            return Ok(mTipoEmpleado.AddTipoEmpleado(tipoEmpleado));
        }

        // Listar tipo empleados
        [HttpGet("gettipoempleados")]
        public async Task<IActionResult> GetTipoEmpleados() {
            MTipoEmpleado mTipoEmpleado = new MTipoEmpleado();
            return Ok(mTipoEmpleado.GetTiposEmpleados());
        }

/* ======================================================================== // ================================================================= */

        //Agregar empleado
        [HttpPost("addempleado")]
        public async Task<IActionResult> AddEmpleado(Empleados empleado)
        {
            MEmpleado mEmpleado = new MEmpleado();
            return Ok(mEmpleado.AddEmpleado(empleado));
        }

        // Listar empleados
        [HttpGet("getempleados")]
        public async Task<IActionResult> GetEmpleados() {
            MEmpleado mEmpleado = new MEmpleado();
            return Ok(mEmpleado.GetEmpleados());
        }

        // Listar un empleado
        [HttpGet("getempleado/{id}")]
        public async Task<IActionResult> GetEmpelado(int id) {
            MEmpleado mEmpleado = new MEmpleado();
            return Ok(mEmpleado.GetEmpleado(id));
        }

        // Actualizar un empleado
        [HttpPatch("updateempleado")]
        public async Task<IActionResult> UpdateEmpleado(Empleados empleado) {
            MEmpleado mEmpleado = new MEmpleado();
            return Ok(mEmpleado.UpdateEmpleado(empleado));
        }

        // Eliminar un empleado
        [HttpDelete("deleteempleado/{id}")]
        public async Task<IActionResult> DeleteEmpleado(int id) {
            MEmpleado mEmpleado = new MEmpleado();
            return Ok(mEmpleado.DeleteEmpleado(id));
        }

/* ======================================================================== // ================================================================= */

        // Asignarle una especie a un empleado
        [HttpPost("asignarespecie")]
        public async Task<IActionResult> AsiganrEspecie(AssignEspecies asiganrEspecie)
        {
            MAssignEspecies mAssignEspecies = new MAssignEspecies();
            return Ok(mAssignEspecies.AssignEspecie(asiganrEspecie));
        }

        // Listar especies asignadas a empleados
        [HttpGet("getespeciesempleados")]
        public async Task<IActionResult> GetEspeciesEmpleados() {
            MAssignEspecies mAssignEspecies = new MAssignEspecies();
            return Ok(mAssignEspecies.GetEspeciesEmpleados());
        }

        // Listar una especie asignado a un empleado
        [HttpGet("getespecieempleado/{id}")]
        public async Task<IActionResult> GetEspecieEmpelado(int id) {
            MAssignEspecies mAssignEspecies = new MAssignEspecies();
            return Ok(mAssignEspecies.GetEspecieEmpleado(id));
        }

        // Editar una especie asignado a un empleado
        [HttpPatch("putespecieempleado")]
        public async Task<IActionResult> PutEspecieEmpelado(AssignEspecies editarEspecie) {
            MAssignEspecies mAssignEspecies = new MAssignEspecies();
            return Ok(mAssignEspecies.EditAsignacion(editarEspecie));
        }

        // Eliminar una especie asignado a un empleado
        [HttpDelete("deleteespecieempleado/{id}")]
        public async Task<IActionResult> DeleteEspecieEmpelado(int id) {
            MAssignEspecies mAssignEspecies = new MAssignEspecies();
            return Ok(mAssignEspecies.DeleteAsignacion(id));
        }


/* ======================================================================== // ================================================================= */

        // Agregar especie
        [HttpPost("addespecie")]
        public async Task<IActionResult> AddEspecie(Especies especie)
        {
            MEspecie mEspecie = new MEspecie();
            return Ok(mEspecie.AddEspecie(especie));
        }

        // Listar especies
        [HttpGet("getespecies")]
        public async Task<IActionResult> GetEspecies() {
            MEspecie mEspecie = new MEspecie();
            return Ok(mEspecie.GetEspecies());
        }

        // Listar una especie
        [HttpGet("getespecie/{id_Especie}")]
        public async Task<IActionResult> GetEspecie(string id_Especie) {
            MEspecie mEspecie = new MEspecie();
            return Ok(mEspecie.GetEspecie(id_Especie));
        }

        // Actualizar especie
        [HttpPatch("updateespecie")]
        public async Task<IActionResult> UpdateEspecie(Especies especie) {
            MEspecie mEspecie = new MEspecie();
            return Ok(mEspecie.UpdateEspecie(especie));
        }

        // Eliminar especie
        [HttpDelete("deleteespecie/{id_Especie}")]
        public async Task<IActionResult> DeleteEspecie(int id_Especie) {
            MEspecie mEspecie = new MEspecie();
            return Ok(mEspecie.DeleteEspecie(id_Especie));
        }

/* ======================================================================== // ================================================================= */
       
       // Asignarle una especie a un habitat
        [HttpPost("asignarespeciehabtat")]
        public async Task<IActionResult> AsiganrEspeciehabitat(AssignEspecieHabitat asiganrEspeciehabitat)
        {
            MAssignEspecieHabitat mAssignEspecieHabitat = new MAssignEspecieHabitat();
            return Ok(mAssignEspecieHabitat.AssignEspecieHabitat(asiganrEspeciehabitat));
        }

        // Listar especies asignadas a un habitat
        [HttpGet("getespecieshabitats")]
        public async Task<IActionResult> GetEspeciesHabitats() {
            MAssignEspecieHabitat mAssignEspecieHabitat = new MAssignEspecieHabitat();
            return Ok(mAssignEspecieHabitat.GetEspeciesHabitats());
        }

        // Listar una especie asignado a un habitat
        [HttpGet("getespeciehabitat/{id}")]
        public async Task<IActionResult> GetEspecieHabitat(int id) {
            MAssignEspecieHabitat mAssignEspecieHabitat = new MAssignEspecieHabitat();
            return Ok(mAssignEspecieHabitat.GetEspecieHabitat(id));
        }

        // Editar una especie asignado a un habitat
        [HttpPatch("putespeciehabitat")]
        public async Task<IActionResult> PutEspecieHabitat(AssignEspecieHabitat asiganrEspeciehabitat) {
            MAssignEspecieHabitat mAssignEspecieHabitat = new MAssignEspecieHabitat();
            return Ok(mAssignEspecieHabitat.EditAsignacionHabitat(asiganrEspeciehabitat));
        }

        // Eliminar una especie asignada a un habiatat
        [HttpDelete("deleteespeciehabitat/{id}")]
        public async Task<IActionResult> DeleteEspecieHabitat(int id) {
            MAssignEspecieHabitat mAssignEspecieHabitat = new MAssignEspecieHabitat();
            return Ok(mAssignEspecieHabitat.DeleteAsignacion(id));
        }

/* ======================================================================== // ================================================================= */
       
        // Agregar itinerario
        [HttpPost("additinerario")]
        public async Task<IActionResult> AddItinerario(Itinerario itinerario)
        {
            MItinerario mItinerario = new MItinerario();
            return Ok(mItinerario.AddItinerario(itinerario));
        }

        // Listar Los itinerarios
        [HttpGet("getitinerarios")]
        public async Task<IActionResult> GetItinerarios() {
            MItinerario mItinerario = new MItinerario();
            return Ok(mItinerario.GetItinerarios());
        }

        // Listar un registro de itinerario
        [HttpGet("getitinerario/{id}")]
        public async Task<IActionResult> GetItinerario(int id) {
            MItinerario mItinerario = new MItinerario();
            return Ok(mItinerario.GetItinerario(id));
        }

        // Editar un itinerario
        [HttpPatch("putitinerario")]
        public async Task<IActionResult> PutItinerario(Itinerario itinerario) {
            MItinerario mItinerario = new MItinerario();
            return Ok(mItinerario.UpdateItinerario(itinerario));
        }

        // Eliminar una especie asignada a un habiatat
        [HttpDelete("deleteitinerario/{id}")]
        public async Task<IActionResult> DeleteItinerario(int id) {
            MItinerario mItinerario = new MItinerario();
            return Ok(mItinerario.DeleteItinerario(id));
        }

/* ======================================================================== // ================================================================= */

        // Agregar Zona
        [HttpPost("addzona")]
        public async Task<IActionResult> AddZona(Zonas zona)
        {
            MZona mZona = new MZona();
            return Ok(mZona.AddZona(zona));
        }

/* ======================================================================== // ================================================================= */
        // Agregar tipo vegetación
        [HttpPost("addtipovegetacion")]
        public async Task<IActionResult> Addtipovegetacion(TiposVegetacion tipoVegetacion)
        {
            MTipoVegetacion mTipoVegetacion = new MTipoVegetacion();
            return Ok(mTipoVegetacion.AddTipoVegetacion(tipoVegetacion));
        }

/* ======================================================================== // ================================================================= */
        // Agregar habitat
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
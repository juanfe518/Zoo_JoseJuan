namespace Zoo.test;
using Zoo.Models;
using Zoo.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class UnitTest1
{
    // Test para obtener todos los mepleados
    [Fact]
    public void GetEmpleados()
    {
        MEmpleado mEmpleado = new MEmpleado();
        RespuestaDTO respuesta = mEmpleado.GetEmpleados();
        Assert.Equal(true, respuesta.respuesta);
    }

    // Test para obtener todas las especies 
    [Fact]
    public void GetEspecies()
    {
        MEspecie mEspecie = new MEspecie();
        RespuestaDTO respuesta = mEspecie.GetEspecies();
        Assert.Equal(true, respuesta.respuesta);
    }

    // Listar todas las asignaciones de una especie a un habitat
    [Fact]
    public void GetEspeciesHabitats()
    {
        MAssignEspecieHabitat mAssignEspecieHabitat = new MAssignEspecieHabitat();
        RespuestaDTO respuesta = mAssignEspecieHabitat.GetEspeciesHabitats();
        Assert.Equal(true, respuesta.respuesta);
    }

    // Listar todas las asignaciones de una especie a cuidadores
    [Fact]
    public void GetEspeciesEmpleados()
    {
        MAssignEspecies mAssignEspecies = new MAssignEspecies();
        RespuestaDTO respuesta = mAssignEspecies.GetEspeciesEmpleados();
        Assert.Equal(true, respuesta.respuesta);
    }

    // Listar todas los itinerarios
    [Fact]
    public void GetItinerarios()
    {
        MItinerario mItinerario = new MItinerario();
        RespuestaDTO respuesta = mItinerario.GetItinerarios();
        Assert.Equal(true, respuesta.respuesta);
    }

    // Listar todos los tipos de empleados
    [Fact]
    public void GetTiposEmpleados()
    {
        MTipoEmpleado mTipoEmpleado = new MTipoEmpleado();
        RespuestaDTO respuesta = mTipoEmpleado.GetTiposEmpleados();
        Assert.Equal(true, respuesta.respuesta);
    }

    // Listar todas las zonas
    [Fact]
    public void GetZonas()
    {
        MZona nZona = new MZona();
        RespuestaDTO respuesta = nZona.GetZonas();
        Assert.Equal(true, respuesta.respuesta);
    }
}
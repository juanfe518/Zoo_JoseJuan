namespace Zoo.test;
using Zoo.Models;
using Zoo.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class UnitTest1
{

    // Test para crear un tipo de empleado pero causando un error ingresando un tipo de dato no valido
    [Fact]
    public void AddTipoEmpleado()
    {
        TipoEmpleado tipoEmpleado = new TipoEmpleado(null, "Tipo de empleado de prueba");
        MTipoEmpleado mTipoEmpleado = new MTipoEmpleado();
        RespuestaDTO respuesta = mTipoEmpleado.AddTipoEmpleado(tipoEmpleado);
        Assert.Equal(true, respuesta.respuesta);

        // Assert.Equal("texto", respuesta.data);
        //JObject emp = JObject.Parse(Convert.ToString(respuesta.data));
        //string Id_Tipo_Empleado = Convert.ToString(emp["Id_Tipo_Empleado"]);

        //Assert.Equal("texto", Id_Tipo_Empleado);
    }

    // Test para obtener todos los mepleados
    [Fact]
    public void GetEmpleados()
    {
        MEmpleado mEmpleado = new MEmpleado();
        RespuestaDTO respuesta = mEmpleado.GetEmpleados();
        Assert.Equal(true, respuesta.respuesta);
    }

    // Test para obtener un unico registro de empleado
    [Fact]
    public void GetEmpleado()
    {
        MEmpleado mEmpleado = new MEmpleado();
        RespuestaDTO respuesta = mEmpleado.GetEmpleado(7);
        Assert.Equal(true, respuesta.respuesta);
    }

    // Test para crear un empleado
    [Fact]
    public void AddEmpleadoSucess()
    { //preguntar por que inserta pero sale error
        Empleados empleados = new Empleados(null, "Prueba test1", "muy lejos", "123456789", 1);
        MEmpleado mEmpleado = new MEmpleado();
        RespuestaDTO respuesta = mEmpleado.AddEmpleado(empleados);
        Assert.Equal(true, respuesta.respuesta);

        // Assert.Equal("texto", respuesta.data);
        //JObject emp = JObject.Parse(Convert.ToString(respuesta.data));
        //string Id_Tipo_Empleado = Convert.ToString(emp["Id_Tipo_Empleado"]);

        //Assert.Equal("texto", Id_Tipo_Empleado);
    }


    // Test para crear un empleado pero asignarle un tipo empleo que no existe y ocasionar error
    [Fact]
    public void AddEmpleadoFail()
    {
        Empleados empleados = new Empleados(null, "Prueba test1", "muy lejos", "123456789", 1);
        MEmpleado mEmpleado = new MEmpleado();
        RespuestaDTO respuesta = mEmpleado.AddEmpleado(empleados);
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


    // Test para hacer una asignación de una especie a un empleado, causar fallo al asinar una especie que no existe
    [Fact]
    public void AddEspeciesEmpleadosFail()
    {
        AssignEspecies assignEspecies = new AssignEspecies(null, 1, 4);
        MAssignEspecies mAssignEspecies = new MAssignEspecies();
        RespuestaDTO respuesta = mAssignEspecies.AssignEspecie(assignEspecies);
        Assert.Equal(true, respuesta.respuesta);

        // Assert.Equal("texto", respuesta.data);
        //JObject emp = JObject.Parse(Convert.ToString(respuesta.data));
        //string Id_Tipo_Empleado = Convert.ToString(emp["Id_Tipo_Empleado"]);

        //Assert.Equal("texto", Id_Tipo_Empleado);
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

    // Test para crear una zona pero enviando un tipo de dato equivocado
    [Fact]
    public void AddZonaFail()
    {
        Zonas zonas = new Zonas(null, "Zona de prueba", 100);
        MZona mZona = new MZona();
        RespuestaDTO respuesta = mZona.AddZona(zonas);
        Assert.Equal(true, respuesta.respuesta);

        // Assert.Equal("texto", respuesta.data);
        //JObject emp = JObject.Parse(Convert.ToString(respuesta.data));
        //string Id_Tipo_Empleado = Convert.ToString(emp["Id_Tipo_Empleado"]);

        //Assert.Equal("texto", Id_Tipo_Empleado);
    }


    // Test para crear un tipo de vegetación pero enviando un tipo de dato equivocado
    [Fact]
    public void AddVegetacionFail()
    {
        TiposVegetacion tiposVegetacion = new TiposVegetacion(null, "Tipo vegetación de prueba", "Tipo vegetación de prueba");
        MTipoVegetacion mTipoVegetacion = new MTipoVegetacion();
        RespuestaDTO respuesta = mTipoVegetacion.AddTipoVegetacion(tiposVegetacion);
        Assert.Equal(true, respuesta.respuesta);

        // Assert.Equal("texto", respuesta.data);
        //JObject emp = JObject.Parse(Convert.ToString(respuesta.data));
        //string Id_Tipo_Empleado = Convert.ToString(emp["Id_Tipo_Empleado"]);

        //Assert.Equal("texto", Id_Tipo_Empleado);
    }

    // Test para crear un Habitat pero enviandole un tipo de vegetación uqe no existe
    [Fact]
    public void AddHabitatFail()
    {
        Habitats habitats = new Habitats(null, "Habitat de prueba", 25, 1);
        MHabitats mHabitats = new MHabitats();
        RespuestaDTO respuesta = mHabitats.AddHabitat(habitats);
        Assert.Equal(true, respuesta.respuesta);

        // Assert.Equal("texto", respuesta.data);
        //JObject emp = JObject.Parse(Convert.ToString(respuesta.data));
        //string Id_Tipo_Empleado = Convert.ToString(emp["Id_Tipo_Empleado"]);

        //Assert.Equal("texto", Id_Tipo_Empleado);
    }
    // Test para crear una zona 
    [Fact]
    public void AddZona()
    {
        Zonas zona = new Zonas();
        MZona mZona = new MZona();
        RespuestaDTO respuesta = mZona.AddZona(zona);
        Assert.Equal(true, respuesta.respuesta);

    }
    // Test para crear un tipo de empleado pero enviandole un tipo de empleado que no existe
    [Fact]
    public void AddTipoEmpleadoFail()
    {
        TipoEmpleado tipoEmpleado = new TipoEmpleado(null, "Tipo de empleado de prueba");
        MTipoEmpleado mTipoEmpleado = new MTipoEmpleado();
        RespuestaDTO respuesta = mTipoEmpleado.AddTipoEmpleado(tipoEmpleado);
        Assert.Equal(true, respuesta.respuesta);

    }

    // Test para obtener un unico registro de empleado
    [Fact]
    public void GetEmpleadoFail()
    {
        MEmpleado mEmpleado = new MEmpleado();
        RespuestaDTO respuesta = mEmpleado.GetEmpleado(50);
        Assert.Equal(true, respuesta.respuesta);
    }



















}
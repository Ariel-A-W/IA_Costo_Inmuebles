using costoinmuebles_backend.Application.DTOs.Localidades;
using costoinmuebles_backend.Application.UsesCases.Localidades;
using costoinmuebles_backend.Domain.Localidades;
using Microsoft.AspNetCore.Mvc;

namespace costoinmuebles_backend.Application.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LocalidadesController : ControllerBase
{
    private readonly LocalidadesUseCase _localidades;

    public LocalidadesController(LocalidadesUseCase localidades)
    {
        _localidades = localidades;
    }

    [HttpGet]
    [Route("getall")]
    public ActionResult<IEnumerable<Localidad>> GetAll()
    { 
        var lstLocalidades = _localidades.GetAll();

        if (lstLocalidades == null)
            return NotFound("No Existen Valores.");

        return Ok(lstLocalidades);
    }

    [HttpGet]
    [Route("getbyid")]
    public ActionResult<Localidad> GetById(
        [FromQuery] LocalidadesByIdRequestDTO value    
    )
    {
        var localidad = _localidades.GetById(value.LocalidadId);

        if (localidad == null)
            return NotFound("No Existen Valores.");

        return Ok(localidad);
    }
}

using costoinmuebles_backend.Application.DTOs.TiposCasas;
using costoinmuebles_backend.Application.UsesCases.TiposCasas;
using costoinmuebles_backend.Domain.TiposCasas;
using Microsoft.AspNetCore.Mvc;

namespace costoinmuebles_backend.Application.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TiposCasasController : ControllerBase
{
    private readonly TiposCasasUseCase _tipos;

    public TiposCasasController(TiposCasasUseCase tipos)
    {
        _tipos = tipos;
    }

    [HttpGet]
    [Route("getall")]
    public ActionResult<IEnumerable<TipoCasa>> GetAll()
    {
        var tiposCasas = _tipos.GetAll();

        if (tiposCasas == null)
            return NotFound("No Existen Valores.");

        return Ok(tiposCasas);
    }

    [HttpGet]
    [Route("getbyid")]
    public ActionResult<TipoCasa> GetById(
        [FromQuery] TiposCasasByIdRequestDTO value    
    )
    { 
        var tipoCasa = _tipos.GetById(value.TipoCasaId);

        if (tipoCasa == null)
            return NotFound("Valor No Existente.");

        return Ok(tipoCasa);
    }
}

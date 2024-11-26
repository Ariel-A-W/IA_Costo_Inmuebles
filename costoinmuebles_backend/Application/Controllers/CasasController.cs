using costoinmuebles_backend.Application.DTOs.Casas;
using costoinmuebles_backend.Application.UsesCases.Casas;
using costoinmuebles_backend.Domain.Casas;
using Microsoft.AspNetCore.Mvc;

namespace costoinmuebles_backend.Application.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CasasController : ControllerBase
{
    private readonly CasasUseCase _casas;

    public CasasController(CasasUseCase casas)
    {
        _casas = casas;
    }

    [HttpGet]
    [Route("getall")]
    public ActionResult<IEnumerable<CasaResponseDTO>> GetAll()
    { 
        var casas = _casas.GetAll();

        if (casas == null)
            return NotFound("No Existen Valores.");

        return Ok(casas);
    }

    [HttpGet]
    [Route("getcasaprediction")]
    public ActionResult<CasaResponseDTO> GetCasaPrediction(
        [FromQuery] CasasPredictionRequestDTO value    
    )
    {
        var casaprediction = _casas.GetCasaPrediction(value);

        if (casaprediction == null)
            return NotFound("No se ha podido procesar la predicción.");

        return Ok(casaprediction);
    }
}

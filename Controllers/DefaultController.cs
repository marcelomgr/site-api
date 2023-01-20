using DefaultAPI.Conversion;
using DefaultAPI.Model;
using DefaultAPI.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace DefaultAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DefaultController : ControllerBase
{
    public ILogger<DefaultController> _logger;
    UnidadesMedidaDistanciaBusiness _distancia;

    public DefaultController(ILogger<DefaultController> logger, UnidadesMedidaDistanciaBusiness distancia)
    {
        _logger = logger;
        _distancia = distancia;
    }

    [HttpGet]
    public ActionResult<ConversionResult> Get(double value, string fromUnit, string toUnit)
    {
        try
        {
            var result = ConversionDimension.Convert(value, fromUnit, toUnit);
            return Ok(new ConversionResult { Value = result });
        }
        catch (ArgumentException)
        {
            return BadRequest("Conversion not found");
        }
    }

    [HttpGet]
    [Route("GetAllUnidadesMedidaDistancia")]
    public ActionResult<UnidadesMedidaDistancia> Get()
    {
        try
        {
            var result = _distancia.GetAllUnidadesMedidaDistancia();

            return Ok(result);
        }
        catch (ArgumentException)
        {
            return BadRequest("Items not found");
        }
    }
}

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNETUdemy.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    #region Properties

    private readonly ILogger<WeatherForecastController> _logger;

    #endregion

    #region Constructor

    

    public CalculatorController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }
    
    #endregion

    #region Methods
    
    [HttpGet(Name = "sum/{firstNumber}/{secondNumber}")]
    public IActionResult Get(string firstNumber, string secondNumber)
    {
        if (!IsNumeric(firstNumber) || !IsNumeric(secondNumber)) 
            return BadRequest("Invalid request!");
        
        var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(firstNumber);
        return Ok(sum.ToString());
    }

    #endregion

    #region Helpers

    private decimal ConvertToDecimal(string firstNumber)
    {
        throw new NotImplementedException();
    }

    private bool IsNumeric(string secondNumber)
    {
        throw new NotImplementedException();
    }

    #endregion
}
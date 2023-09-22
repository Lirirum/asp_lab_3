using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    [Controller]
    public class CalculatorController : Controller
    {
        private readonly CalcService _calcService;



        public CalculatorController(CalcService calcService)
        {
            _calcService = calcService;
        }



        public string Index()
        {
            var result = "Введіть у пошуковому рядку вашу дію";
            return result;
        }

        [HttpGet("add")]
        public IActionResult Add(int a, int b)
        {
            var result = $"Результат додавання: {a}+{b} = " + _calcService.Add(a, b);
            return Ok(result);
        }

        [HttpGet("subtract")]
        public IActionResult Subtract(int a, int b)
        {
            var result = $"Результат різниці: {a}-{b} = " + _calcService.Subtract(a, b);
            return Ok(result);
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(int a, int b)
        {
            var result = $"Результат множення: {a}*{b} = " + _calcService.Multiply(a, b);
            return Ok(result);
        }

        [HttpGet("divide")]
        public IActionResult Divide(int a, int b)
        {
            try
            {
                var result = $"Результат ділення: {a}/{b} = " + _calcService.Divide(a, b);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

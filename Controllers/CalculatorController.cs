using Microsoft.AspNetCore.Mvc;

namespace URL_Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        } 

        [HttpGet("InitialContent")] 
        public IActionResult URL_MAP()  
        {
            string Message = "-- Calculator -- \r\n \r\n" +
                "Valid URLs: \r\n" +

                "To sum two numbers: https://localhost:7298/Calculator/sum/{FirstNumber}/{SecondNumber} \r\n" +
                "Exemple: https://localhost:7298/Calculator/sum/1/2 result = 3 \r\n\r\n" +

                "To subtract two numbers: https://localhost:7298/Calculator/subtraction/{FirstNumber}/{SecondNumber} \r\n" +
                "Exemple: https://localhost:7298/Calculator/subtraction/1/2 result = -1 \r\n\r\n" +

                "To multiply two numbers: https://localhost:7298/Calculator/division/{FirstNumber}/{SecondNumber} \r\n" +
                "Exemple: https://localhost:7298/Calculator/division/4/2 result = 2 \r\n\r\n" +

                "To divide two numbers: https://localhost:7298/Calculator/multiplication/{FirstNumber}/{SecondNumber} \r\n" +
                "Exemple: https://localhost:7298/Calculator/multiplication/3/2 result = 6 \r\n\r\n";
            
                return Ok(Message);
        }


        [HttpGet("{operation}/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string operation, string firstNumber, string secondNumber) 
        {
            operation= operation.ToLower();


            if (operation == "sum") 
            {
                var sum = Convert.ToInt16(firstNumber) + Convert.ToInt16(secondNumber);
                return Ok(sum);
            }

            if (operation == "subtraction")
            {
                var sum = Convert.ToInt16(firstNumber) - Convert.ToInt16(secondNumber);
                return Ok(sum);
            }

            if (operation == "division")
            {
                var sum = Convert.ToInt16(firstNumber) / Convert.ToInt16(secondNumber);
                return Ok(sum);
            }

            if (operation == "multiplication")
            {
                var sum = Convert.ToInt16(firstNumber) * Convert.ToInt16(secondNumber);
                return Ok(sum);
            }

            return BadRequest("Invalid Input...");
        }
        
    }
}
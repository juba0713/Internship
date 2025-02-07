using Microsoft.AspNetCore.Mvc;

namespace OpenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : Controller
    {

        [HttpPost]
        [Route("Add")]
        public float Add(Equation equation)
        {
            equation.Result =  equation.XValue + equation.YValue;
            return equation.Result;
        }


    }
}

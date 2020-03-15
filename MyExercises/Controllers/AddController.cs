using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyExercises.Models;

namespace MyExercises.Controllers
{
    [ApiController]
    [Route("add")]

    public class AddController : Controller
    {
        private List<double> defaultList = new List<double>() { 1.0, 2.0, 3.0, 4.0, 5.0 };
        private readonly ILogger<AddController> _logger;
        public AddController(ILogger<AddController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Sum([FromBody]List<double> myNumbers)
        {
            if (myNumbers.Count < 2)
            {
                myNumbers = defaultList;
            }
            double result = 0;

            
            for (int i = 0; i < myNumbers.Count; i++)
            {
                result = result + myNumbers[i];
            }

            return Ok(result);
        }
    }
}
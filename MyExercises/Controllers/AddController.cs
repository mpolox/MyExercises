using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyExercises.Helpers;
using MyExercises.Models;

namespace MyExercises.Controllers
{
    [ApiController]
    [Route("add")]

    public class AddController : Controller
    {
        private readonly List<double> defaultList = new List<double>() { 1.0, 2.0, 3.0, 4.0, 5.0 };
        private readonly List<int> defaultListIntegers = new List<int>() { 1,1,2,2,2,3,3,4 };
        private ExampleHelper helper = new ExampleHelper();

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
                result += myNumbers[i];
            }

            return Ok(result);
        }

        [HttpPost("arrayExample")]
        public IActionResult ArrayExample02([FromBody] List<int> myNumbers)
        {
            if (myNumbers.Count < 2)
            {
                myNumbers = defaultListIntegers;
            }
            var numbers = myNumbers.ToArray();
            var result = helper.ArrayExample01(ref numbers);
            return Ok(result);
        }
    }
}
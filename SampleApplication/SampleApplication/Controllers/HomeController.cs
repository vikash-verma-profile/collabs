using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleApplication.Models;

namespace SampleApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        static List<Employees> employeeList = new List<Employees>();
        [HttpGet]
        public IActionResult GetNames()
        {
            return (IActionResult)employeeList;
        }
        [HttpPost]
        public string PostName([FromBody]Employees employee)
        {
            employeeList.Add(employee);
            return CreatedAtAction(,,);
            return "record added successfully";

        }
    }
}

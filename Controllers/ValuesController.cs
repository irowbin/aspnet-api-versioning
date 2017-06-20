using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP.Controllers
{
    [ApiVersion("1.0")]
    //[Route("api/v{version:apiVersion}/[controller]/[action]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    //[Produces("application/json")]
    public class ValuesController : Controller
    {
        
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }
    }
}

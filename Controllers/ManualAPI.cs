using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel.API.Controllers
{
    [Route("api/manualapi")]
    
    //[Controller]
    public class ManualAPI : Controller
    {
        [HttpGet]
        public  IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}

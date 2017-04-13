using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        [Produces("application/json")]
        public IActionResult Get()
        {
            return Json(NetCoreLibrary.NetCoreClass.DoSomething());
        }
    }
}

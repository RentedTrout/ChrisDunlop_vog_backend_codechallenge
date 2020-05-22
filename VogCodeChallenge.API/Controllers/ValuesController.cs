using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChrisDunlop_vog_backend_codechalleneg.Classes;
using Microsoft.AspNetCore.Mvc;

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/Values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}

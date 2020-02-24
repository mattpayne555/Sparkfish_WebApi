using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sparkfish_WebApi.Controllers
{
    [Route("listify")]
    [ApiController]
    public class ListifyController : ControllerBase
    {
        // GET: api/Listify
        [HttpGet]
        public string Get(int begin, int end, int index)
        {
            var list = new Listify(begin, end);
            return Convert.ToString(list[index]);
        }
    }
}

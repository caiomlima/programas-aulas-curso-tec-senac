using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeira_API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase {

        [HttpGet]
        public IEnumerable<string> Get() {
            return new string[] {
                "Valor 1", "Valor 2", "Valor 3", "Valor 4", "Valor 5"
            };
        }

    }
}

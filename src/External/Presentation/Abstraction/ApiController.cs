using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Abstraction
{
    [ApiController]
    [Route("api/[Controller]")]
    public abstract class ApiController: ControllerBase
    {
    }
}

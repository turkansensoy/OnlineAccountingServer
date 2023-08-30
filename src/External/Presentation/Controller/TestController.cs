using Microsoft.AspNetCore.Mvc;
using Presentation.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controller
{
    public sealed class TestController:ApiController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("İşlem Başarılı");
        }
    }
}

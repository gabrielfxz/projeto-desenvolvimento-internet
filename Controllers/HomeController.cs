using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoEscola_API.Controllers
{
    [ApiController]
    [Route("/")]

    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult Inicio()
        {
            return new ContentResult
            {
                ContentType = "text/html",
                Content = "<h1>API Projeto Escola: funcionou!!</h1>"
            };
        }
    }
}
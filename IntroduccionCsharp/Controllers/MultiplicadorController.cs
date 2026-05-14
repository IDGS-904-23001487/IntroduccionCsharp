using IntroduccionCsharp.Controllers;
using IntroduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionCsharp.Controllers
{
    public class MultiplicacionController : Controller
    {
        public ActionResult Index()

        {
            return View(new MultiplicacionSuma());

        }
        [HttpPost]

        public ActionResult Index(MultiplicacionSuma modelo)

        {
            modelo.Multiplicar();
            return View(modelo);

        }

    }

}
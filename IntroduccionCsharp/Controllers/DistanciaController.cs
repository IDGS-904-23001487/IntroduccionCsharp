using IntroduccionCsharp.Models; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionCsharp.Controllers
{
    public class DistanciaController : Controller
    {
     
        public ActionResult Index()
        {
            return View(new Distancia());
        }

        public ActionResult Distancia(Distancia dist)
        {
            dist.CalcularDistancia();

            return View(dist);
        }
    }
}
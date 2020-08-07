using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Formulario_BD.Models;
using Microsoft.AspNetCore.Mvc;

namespace Formulario_BD.Controllers
{
    public class PersonaController : Controller
    {

        private readonly PersonaContext Db;


        public PersonaController(PersonaContext obj)
        {
            Db = obj;
        }

        public IActionResult Index()
        {
           
            return View();
        }

      
        //LA Primera Vez que entra para registrar
        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }

        //una ya una vez enviado los datos
        [HttpPost]
        public IActionResult Agregar(Persona p) 
        {
            Db.Add(p);
            Db.SaveChanges();

            ViewBag.valor = 1;
           // return RedirectToAction("Home/Index");
            return View();
        }
    }
}

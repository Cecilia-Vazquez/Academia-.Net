using MVC_AcademyB.Models;
using MVC_AcademyB.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_AcademyB.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Personas
        public ActionResult Index()
        {
            List<PersonaViewModel> personas;
            using (PersonasEntities dbContext = new PersonasEntities())
            {
                personas = dbContext.Personas.AsEnumerable().Select(p => new PersonaViewModel(p)).ToList();

            }
                
                return View(personas);
        }
    }
}
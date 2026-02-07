using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Bussines;

namespace WebApplicationAPP.Controllers
{
    public class PersonaController : Controller
    {
        private readonly PersonaBussiness _personaBussiness;
        
        public PersonaController(PersonaBussiness personaBussiness)
        {
            _personaBussiness = personaBussiness;
        }


        public IActionResult Index()
        {
            return View(_personaBussiness.GetAllPersonas());
        }
    }
}

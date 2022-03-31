using ASP.NET.DEMO.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.DEMO.Controllers
{
    public class ContactoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Contacto pContacto)
        {
            Contacto contacto = new Contacto();
            contacto.Add(pContacto);

            return Ok(pContacto);
        }

        [HttpDelete]
        public IActionResult Delete(int pIdContacto)
        {
            Contacto contacto = new Contacto();
            contacto.Delete(pIdContacto);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Contacto pContacto)
        {
            Contacto contacto = new Contacto();
            contacto.Update(pContacto);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetContactos()
        {
            Contacto contacto = new Contacto();
            return Ok(contacto.GetContactos());
        }
    }
}

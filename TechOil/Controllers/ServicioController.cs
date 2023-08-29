using Microsoft.AspNetCore.Mvc;
using TechOil.Models;

namespace TechOil.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioController : ControllerBase
    {
        ///>ABMLs
        ///Listar Servicios
        [HttpGet]
        [Route("listado")]
        public IActionResult Listar()
        {
            return Ok("A desarrollar");
        }
        
        
        ///Buscar Servicio por ID
        [HttpGet]
        [Route("busqueda")]
        public IActionResult BuscarPorId(int id)
        {
            if (id == 42)
            {
                return Ok("Encontraste el sentido de la vida");
            }
            else
            {
                return BadRequest("DON'T PANIC");
            }
        }
        ///Agregar Servicio
        [HttpPost]
        [Route("insertar")]
        public IActionResult Insertar(Servicio servicio)
        {
            return Ok("TBD");
        }
        ///Baja logica de servicio
        [HttpDelete]
        [Route("eliminar")]
        public IActionResult Eliminar(int id)
        {
            return Accepted("RIP");
        }
        
        ///Modificacion de Servicio
        [HttpPut]
        [Route("modificar")]
        public IActionResult Modificar(Servicio servicio)
        {
            if (servicio.Id == 13)
            {
                return Ok("Modded");
            }
            else
            {
                return BadRequest("No existe ese proyecto");
            }
            
        }
    }
    
}


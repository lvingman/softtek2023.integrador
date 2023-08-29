using Microsoft.AspNetCore.Mvc;
using TechOil.Models;

namespace TechOil.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProyectoController : ControllerBase
    {
        ///>ABMLs
        ///Listar Proyectos
        [HttpGet]
        [Route("listado")]
        public IActionResult Listar()
        {
            return Ok("A desarrollar");
        }


        ///Buscar Proyecto por ID
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

        ///Agregar Proyecto
        [HttpPost]
        [Route("insertar")]
        public IActionResult Insertar(Proyecto proyecto)
        {
            return Ok("TBD");
        }

        ///Baja logica de proyecto
        [HttpDelete]
        [Route("eliminar")]
        public IActionResult Eliminar(int id)
        {
            return Accepted("RIP");
        }

        ///Modificacion de Proyecto
        [HttpPut]
        [Route("modificar")]
        public IActionResult Modificar(Proyecto proyecto)
        {
            if (proyecto.Id == 13)
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

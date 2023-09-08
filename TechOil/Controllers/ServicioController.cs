using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechOil.Models;

namespace TechOil.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ServicioController : ControllerBase
    {
        //#############
        //### ABML ####
        //#############
        
        
        /// <summary>
        /// Lista todos los servicios
        /// </summary>
        /// <returns>Todos los servicios</returns>
        [HttpGet]
        [Route("listado")]
        public IActionResult Listar()
        {
            return Ok("A desarrollar");
        }
        
        
        /// <summary>
        /// Busca un servicio por ID
        /// </summary>
        /// <param name="id"> ID del servicio a buscar</param>
        /// <returns>Servicio buscado con la ID</returns>
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
        
        /// <summary>
        /// Inserta un servicio en la API
        /// </summary>
        /// <param name="servicio">Servicio que se ingresara en la API</param>
        /// <returns>Confirmacion de que se ingreso el servicio</returns>
        [HttpPost]
        [Route("insertar")]
        public IActionResult Insertar(Servicio servicio)
        {
            return Ok("TBD");
        }
        
        /// <summary>
        /// Eliminar un servicio
        /// </summary>
        /// <param name="id">Id del servicio a eliminar</param>
        /// <returns>Confirmacion de eliminacion</returns>
        [HttpDelete]
        [Route("eliminar")]
        public IActionResult Eliminar(int id)
        {
            return Accepted("RIP");
        }
        
        /// <summary>
        /// Modificacion de servicio
        /// </summary>
        /// <param name="servicio">Servicio a modificar</param>
        /// <returns>Confirmacion de modificacion</returns>
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
                return BadRequest("No existe ese servicio");
            }
            
        }
    }
    
}


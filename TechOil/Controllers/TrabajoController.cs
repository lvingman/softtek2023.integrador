using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechOil.Models;

namespace TechOil.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TrabajoController : ControllerBase
    {
        //#############
        //### ABML ####
        //#############
        
        /// <summary>
        /// Lista todos los trabajos
        /// </summary>
        /// <returns>Devuelve una lista de todos los trabajos</returns>
        [HttpGet]
        [Route("listado")]
        public IActionResult Listar()
        {
            return Ok("A desarrollar");
        }
        
        
        /// <summary>
        /// Devuelve un trabajo en especifico
        /// </summary>
        /// <param name="id">Id del trabajo a buscar</param>
        /// <returns>Trabajo con el ID especificado</returns>
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
        /// Inserta un trabajo en la API
        /// </summary>
        /// <param name="trabajo">Trabajo a insertar</param>
        /// <returns>Confirmacion de insercion</returns>
        [HttpPost]
        [Route("insertar")]
        public IActionResult Insertar(Trabajo trabajo)
        {
            return Ok("TBD");
        }
        
        /// <summary>
        /// Elimina un trabajo
        /// </summary>
        /// <param name="id">ID del trabajo a eliminar</param>
        /// <returns>Confirmacion de eliminacion</returns>
        [HttpDelete]
        [Route("eliminar")]
        public IActionResult Eliminar(int id)
        {
            return Accepted("RIP");
        }
        
        /// <summary>
        /// Modifica un trabajo
        /// </summary>
        /// <param name="trabajo">Trabajo a modificar</param>
        /// <returns>Confirmacion de edicion</returns>
        [HttpPut]
        [Route("modificar")]
        public IActionResult Modificar(Trabajo trabajo)
        {
            if (trabajo.Id == 13)
            {
                return Ok("Modded");
            }
            else
            {
                return BadRequest("No existe ese trabajo");
            }
            
        }
    }
    
}
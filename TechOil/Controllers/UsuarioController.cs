using Microsoft.AspNetCore.Mvc;
using TechOil.Models;

namespace TechOil.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        //#############
        //### ABML ####
        //#############
        
        /// <summary>
        /// Lista Usuarios
        /// </summary>
        /// <returns>Lista de todos los usuarios en la API</returns>
        [HttpGet]
        [Route("listado")]
        public IActionResult Listar()
        {
            return Ok("A desarrollar");
        }
        
        
        /// <summary>
        /// Devuelve un usuario
        /// </summary>
        /// <param name="id">ID del usuario a buscar</param>
        /// <returns>Usuario con el ID asignado</returns>
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
        /// Inserta un usuario en la API
        /// </summary>
        /// <param name="usuario">Usuario a insertar</param>
        /// <returns>Confirmacion de insercion</returns>
        [HttpPost]
        [Route("insertar")]
        public IActionResult Insertar(Usuario usuario)
        {
            return Ok("TBD");
        }
        
        /// <summary>
        /// Elimina un usuario de la API
        /// </summary>
        /// <param name="id">Id del usuario a eliminar</param>
        /// <returns>Confirmacion de eliminacion</returns>
        [HttpDelete]
        [Route("eliminar")]
        public IActionResult Eliminar(int id)
        {
            return Accepted("RIP");
        }
        
        /// <summary>
        /// Modificacion de usuario
        /// </summary>
        /// <param name="usuario">Usuario a modificar</param>
        /// <returns>Confirmacion de </returns>
        [HttpPut]
        [Route("modificar")]
        public IActionResult Modificar(Usuario usuario)
        {
            if (usuario.Id == 13)
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
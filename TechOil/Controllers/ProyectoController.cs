using Microsoft.AspNetCore.Mvc;
using TechOil.Models;

namespace TechOil.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProyectoController : ControllerBase
    {
        
        //#############
        //### ABML ####
        //#############
        
        
        /// <summary>
        /// Lista todos los proyectos
        /// </summary>
        /// <returns>Todos los proyectos</returns>
        [HttpGet]
        [Route("listado")]
        public IActionResult Listar()
        {
            return Ok("A desarrollar");
        }


        /// <summary>
        /// Busca un proyecto por su id
        /// </summary>
        /// <returns>Proyecto con la ID ingresada</returns>
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
        /// Ingresa un proyecto a la base de datos
        /// </summary>
        /// <param name="proyecto">Proyecto a modificar</param>
        /// <returns>Confirmacion de que se ingreso el proyecto con exito</returns>
        [HttpPost]
        [Route("insertar")]
        public IActionResult Insertar(Proyecto proyecto)
        {
            return Ok("TBD");
        }

        /// <summary>
        /// Elimina un proyecto por su ID
        /// </summary>
        /// <param name="id">Id del proyecto a eliminar</param>
        /// <returns>Confirmacion de que se elimino el proyecto</returns>
        [HttpDelete]
        [Route("eliminar")]
        public IActionResult Eliminar(int id)
        {
            return Accepted("RIP");
        }

        /// <summary>
        /// Modifica un proyecto
        /// </summary>
        /// <returns>Confirmacion de que se modifico el proyecto</returns>
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

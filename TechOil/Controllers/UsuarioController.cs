using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechOil.Models;
using TechOil.Services;

namespace TechOil.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsuarioController : ControllerBase
    {
        //UNIT OF WORK
        private readonly IUnitOfWork _unitOfWork;

        public UsuarioController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        //#############
        //### ABML ####
        //#############
        
        /// <summary>
        /// Lista Usuarios
        /// </summary>
        /// <returns>Lista de todos los usuarios en la API</returns>
        [HttpGet]
        [Route("listado")]
        public async Task<ActionResult<IEnumerable<Usuario>>> Listar()
        {
            var usuarios = await _unitOfWork.UsuarioRepository.GetAll();
            return usuarios;
        }
        
        
        /// <summary>
        /// Devuelve un usuario
        /// </summary>
        /// <param name="id">ID del usuario a buscar</param>
        /// <returns>Usuario con el ID asignado</returns>
        [HttpGet]
        [Route("busqueda")]
        public async Task<ActionResult<Usuario>> BuscarPorId(int id)
        {
            var busqueda = await _unitOfWork.UsuarioRepository.FindByID(id);
            return busqueda;
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
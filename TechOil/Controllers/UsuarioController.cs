using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechOil.DTO;
using TechOil.Helper;
using TechOil.Infrastructure;
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
        
        //##########################
        //### CONSTRUCTORES DTO ####
        //##########################

    
        
        //#############
        //### ABML ####
        //#############
        
        /// <summary>
        /// Lista Usuarios
        /// </summary>
        /// <returns>Lista de todos los usuarios en la API</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> Listar()
        {
            var usuarios = await _unitOfWork.UsuarioRepository.GetAllActive();
            return usuarios;
        }
        
        
        /// <summary>
        /// Devuelve un usuario
        /// </summary>
        /// <param name="id">ID del usuario a buscar</param>
        /// <returns>Usuario con el ID asignado</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> BuscarPorId([FromRoute]int id)
        {
            var busqueda = await _unitOfWork.UsuarioRepository.FindByID(id);
            return busqueda;
        }
        
        //Todo: Agregar documentacion de swagger para esta funcion
        
        /// <summary>
        /// Inserta un usuario en la API
        /// </summary>
        /// <param name="usuario">Usuario a insertar</param>
        /// <returns>Confirmacion de insercion</returns>
        [Authorize(Policy = "Administrador")]
        [HttpPost]

        public async Task<ActionResult<Usuario>> RegistrarUsuario(UsuarioDTO dto)
        {
            //Todo: Agregar funcion para verificar que el usuario no exista
            var usuario = new Usuario(dto); 
            await _unitOfWork.UsuarioRepository.Insert(usuario);
            await _unitOfWork.Complete();
            return Ok(true);
            
            //Todo: Configurar lo siguiente: return ResponseFactory.CreateSuccessResponse(201, "Usuario registrado con exito");

        }
        
        /// <summary>
        /// Modificacion de usuario
        /// </summary>
        /// <param name="usuario">Usuario a modificar</param>
        /// <returns>Confirmacion de </returns>
        [Authorize(Policy = "Administrador")]
        [HttpPut("{id}")]
        public async Task<IActionResult> Modificar([FromRoute] int id, UsuarioDTO dto)
        {
            var result = await _unitOfWork.UsuarioRepository.Update(new Usuario(dto, id));
           
            await _unitOfWork.Complete();
            return Ok(true);

        }

        /// <summary>
        /// Elimina un usuario de la API fisicamente
        /// </summary>
        /// <param name="id">Id del usuario a eliminar</param>
        /// <returns>Confirmacion de eliminacion fisica</returns>
        [HttpDelete("hd/{id}")]
        [Authorize(Policy = "Administrador")]
        public async Task<IActionResult> HardDelete([FromRoute] int id)
        {
            var result = await _unitOfWork.UsuarioRepository.HardDelete(id);

            await _unitOfWork.Complete();
            return Ok(true);
        }

        /// <summary>
        /// Elimina un usuario de la API fisicamente
        /// </summary>
        /// <param name="id">Id del usuario a eliminar</param>
        /// <returns>Confirmacion de eliminacion fisica</returns>
        [Authorize(Policy = "Administrador")]
        [HttpDelete("sd/{id}")]

        public async Task<IActionResult> SoftDelete([FromRoute] int id)
        {
            var result = await _unitOfWork.UsuarioRepository.SoftDelete(id);

            await _unitOfWork.Complete();
            return Ok(true);
        }


    }

}
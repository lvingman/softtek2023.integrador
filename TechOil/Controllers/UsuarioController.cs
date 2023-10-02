using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
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
        public async Task<IActionResult> Listar()
        {



            var usuarios = await _unitOfWork.UsuarioRepository.GetAllActive();
            //Paginado
            int pageToShow = 1;
            
            //Decide que pagina se muestra
            if (Request.Query.ContainsKey("page"))
            {
                int.TryParse(Request.Query["page"], out pageToShow);
            }
            
            var url = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}").ToString();
            var paginateUsers = PaginateHelper.Paginate(usuarios, pageToShow, url);
            
            return ResponseFactory.CreateSuccessResponse(200, paginateUsers);
        }
        
        
        /// <summary>
        /// Devuelve un usuario
        /// </summary>
        /// <param name="id">ID del usuario a buscar</param>
        /// <returns>Usuario con el ID asignado</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarPorId([FromRoute]int id)
        {
            var busqueda = await _unitOfWork.UsuarioRepository.FindByID(id);
            if (busqueda is null)
            {
                return ResponseFactory.CreateErrorResponse(501, "Usuario inexistente");
            }
            else
            {
                return ResponseFactory.CreateSuccessResponse(200, busqueda);
            }
        }
        
      
        /// <summary>
        /// Inserta un usuario en la API
        /// </summary>
        /// <param name="usuario">Usuario a insertar</param>
        /// <returns>Confirmacion de insercion</returns>
        [Authorize(Policy = "Administrador")]
        [HttpPost]

        public async Task<IActionResult> RegistrarUsuario(UsuarioDTO dto)
        {

            if (await _unitOfWork.UsuarioRepository.ExistingUser(dto.Email)) return ResponseFactory.CreateErrorResponse(409, $"Ya existe un usuario registrado con el mail:{dto.Email}");
            var usuario = new Usuario(dto);
            await _unitOfWork.UsuarioRepository.Insert(usuario);
            await _unitOfWork.Complete();

            return ResponseFactory.CreateSuccessResponse(201, "Usuario registrado con exito!");

        }
        
        /// <summary>
        /// Modificacion de usuario
        /// </summary>
        /// <param name="usuario">Usuario a modificar</param>
        /// <returns>Confirmacion de </returns>
        [Authorize(Policy = "Administrador")]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, UsuarioDTO dto)
        {
            var result = await _unitOfWork.UsuarioRepository.Update(new Usuario(dto, id));

            if (!result)
            {
                return ResponseFactory.CreateErrorResponse(500, "No se pudo modificar el usuario");
            }
            else
            {
                await _unitOfWork.Complete();
                return ResponseFactory.CreateSuccessResponse(200, "Actualizado");
            }
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

            if (!result)
            {
                return ResponseFactory.CreateErrorResponse(501, "Usuario inexistente");
            }
            else
            {
                await _unitOfWork.Complete();
                return ResponseFactory.CreateSuccessResponse(200, "Eliminado");
            }
          
        }

        /// <summary>
        /// Realiza una baja logica de un usuario de la API
        /// </summary>
        /// <param name="id">Id del usuario a eliminar</param>
        /// <returns>Confirmacion de eliminacion fisica</returns>
        [Authorize(Policy = "Administrador")]
        [HttpDelete("sd/{id}")]

        public async Task<IActionResult> SoftDelete([FromRoute] int id)
        {
            var result = await _unitOfWork.UsuarioRepository.SoftDelete(id);

            if (!result)
            {
                return ResponseFactory.CreateErrorResponse(500, "No se pudo eliminar el usuario");
            }
            else
            {
                await _unitOfWork.Complete();
                return ResponseFactory.CreateSuccessResponse(200, "Eliminado logico concluido con exito!");
            }
            
        }


    }

}
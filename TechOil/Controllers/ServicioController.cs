using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechOil.DTO;
using TechOil.Models;
using TechOil.Services;

namespace TechOil.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ServicioController : ControllerBase
    {
        //UNIT OF WORK
        private readonly IUnitOfWork _unitOfWork;

        public ServicioController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        //#############
        //### ABML ####
        //#############
        
        
        /// <summary>
        /// Lista todos los servicios
        /// </summary>
        /// <returns>Todos los servicios</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Servicio>>> Listar()
        {
            var servicios = await _unitOfWork.ServicioRepository.GetAllActive();
            return servicios;
        }

        
        
        /// <summary>
        /// Busca un servicio por ID
        /// </summary>
        /// <param name="id"> ID del servicio a buscar</param>
        /// <returns>Servicio buscado con la ID</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Servicio>> BuscarPorId([FromRoute]int id)
        {
            var busqueda = await _unitOfWork.ServicioRepository.FindByID(id);
            return busqueda;
        }

        
        /// <summary>
        /// Eliminar un servicio
        /// </summary>
        /// <param name="id">Id del servicio a eliminar</param>
        /// <returns>Confirmacion de eliminacion</returns>
        [Authorize(Policy = "Administrador")]
        [HttpPost]

        public async Task<ActionResult<Usuario>> Registrar(ServicioDTO dto)
        {
            //Todo: Agregar funcion para verificar que el servicio no exista
            var servicio = new Servicio(dto); 
            await _unitOfWork.ServicioRepository.Insert(servicio);
            await _unitOfWork.Complete();
            return Ok(true);
            
            //Todo: Configurar lo siguiente: return ResponseFactory.CreateSuccessResponse(201, "Usuario registrado con exito");

        }
        
        /// <summary>
        /// Modificacion de servicio
        /// </summary>
        /// <param name="servicio">Servicio a modificar</param>
        /// <returns>Confirmacion de modificacion</returns>
        [Authorize(Policy = "Administrador")]
        [HttpPut("{id}")]
        public async Task<IActionResult> Modificar([FromRoute] int id, ServicioDTO dto)
        {
            var result = await _unitOfWork.ServicioRepository.Update(new Servicio(dto, id));
           
            await _unitOfWork.Complete();
            return Ok(true);

        }
        
        
        /// <summary>
        /// Elimina un servicio de la API fisicamente
        /// </summary>
        /// <param name="id">Id del servicio a eliminar</param>
        /// <returns>Confirmacion de eliminacion fisica</returns>
        [HttpDelete("hd/{id}")]
        [Authorize(Policy = "Administrador")]
        public async Task<IActionResult> HardDelete([FromRoute] int id)
        {
            var result = await _unitOfWork.ServicioRepository.HardDelete(id);

            await _unitOfWork.Complete();
            return Ok(true);
        }

        /// <summary>
        /// Cambia el estado del servicio de activo a no activo
        /// </summary>
        /// <param name="id">Id del servicio a desactivar</param>
        /// <returns>Confirmacion de eliminacion logica</returns>
        [Authorize(Policy = "Administrador")]
        [HttpDelete("sd/{id}")]

        public async Task<IActionResult> SoftDelete([FromRoute] int id)
        {
            var result = await _unitOfWork.ServicioRepository.SoftDelete(id);

            await _unitOfWork.Complete();
            return Ok(true);
        }
    }
    
}


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
        public async Task<IActionResult> Listar()
        {
            var servicios = await _unitOfWork.ServicioRepository.GetAllActive();
            int pageToShow = 1;
            
            //Decide que pagina se muestra
            if (Request.Query.ContainsKey("page"))
            {
                int.TryParse(Request.Query["page"], out pageToShow);
            }
            
            var url = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}").ToString();
            var paginateRoles = PaginateHelper.Paginate(servicios, pageToShow, url);

            return ResponseFactory.CreateSuccessResponse(200, pageToShow);
        }

        
        
        /// <summary>
        /// Busca un servicio por ID
        /// </summary>
        /// <param name="id"> ID del servicio a buscar</param>
        /// <returns>Servicio buscado con la ID</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarPorId([FromRoute]int id)
        {
            var busqueda = await _unitOfWork.ServicioRepository.FindByID(id);
            return ResponseFactory.CreateSuccessResponse(200, busqueda);
        }

        
        /// <summary>
        /// Eliminar un servicio
        /// </summary>
        /// <param name="id">Id del servicio a eliminar</param>
        /// <returns>Confirmacion de eliminacion</returns>
        [Authorize(Policy = "Administrador")]
        [HttpPost]

        public async Task<IActionResult> Registrar(ServicioDTO dto)
        {

            var servicio = new Servicio(dto); 
            await _unitOfWork.ServicioRepository.Insert(servicio);
            await _unitOfWork.Complete();
            return ResponseFactory.CreateSuccessResponse(201, "Servicio registrado con exito!");

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
            if (!result)
            {
                return ResponseFactory.CreateErrorResponse(500, "No se pudo eliminar el servicio");
            }
            else
            {
                await _unitOfWork.Complete();
                return ResponseFactory.CreateSuccessResponse(200, "Actualizado");
            }

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
            
            if (!result)
            {
                return ResponseFactory.CreateErrorResponse(500, "No se pudo eliminar el usuario");
            }
            else
            {
                await _unitOfWork.Complete();
                return ResponseFactory.CreateSuccessResponse(200, "Eliminado");
            }

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


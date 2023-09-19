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
    public class ProyectoController : ControllerBase
    {
        //UNIT OF WORK
        private readonly IUnitOfWork _unitOfWork;

        public ProyectoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //#############
        //### ABML ####
        //#############
        
        
        /// <summary>
        /// Lista todos los proyectos
        /// </summary>
        /// <returns>Todos los proyectos</returns>
        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var proyectos = await _unitOfWork.ProyectoRepository.GetAllActive();
            //Paginado
            int pageToShow = 1;
            
            //Decide que pagina se muestra
            if (Request.Query.ContainsKey("page"))
            {
                int.TryParse(Request.Query["page"], out pageToShow);
            }
            
            var url = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}").ToString();
            var paginateProyects = PaginateHelper.Paginate(proyectos, pageToShow, url);
            
            return ResponseFactory.CreateSuccessResponse(200, paginateProyects);
        }

        /// <summary>
        /// Busca un proyecto por su id
        /// </summary>
        /// <returns>Proyecto con la ID ingresada</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarPorId([FromRoute]int id)
        {
            var busqueda = await _unitOfWork.ProyectoRepository.FindByID(id);
            return ResponseFactory.CreateSuccessResponse(200, busqueda);
        }


        /// <summary>
        /// Ingresa un proyecto a la base de datos
        /// </summary>
        /// <param name="proyecto">Proyecto a modificar</param>
        /// <returns>Confirmacion de que se ingreso el proyecto con exito</returns>
        [Authorize(Policy = "Administrador")]
        [HttpPost]

        public async Task<IActionResult> Registrar(ProyectoDTO dto)
        {

            var proyecto = new Proyecto(dto); 
            await _unitOfWork.ProyectoRepository.Insert(proyecto);
            await _unitOfWork.Complete();
            return ResponseFactory.CreateSuccessResponse(201, "Proyecto registrado con exito!");

        }

        /// <summary>
        /// Elimina un proyecto de la API fisicamente
        /// </summary>
        /// <param name="id">Id del proyecto a eliminar</param>
        /// <returns>Confirmacion de eliminacion fisica</returns>
        [HttpDelete("hd/{id}")]
        [Authorize(Policy = "Administrador")]
        public async Task<IActionResult> HardDelete([FromRoute] int id)
        {
            var result = await _unitOfWork.ProyectoRepository.HardDelete(id);
            
            if (!result)
            {
                return ResponseFactory.CreateErrorResponse(500, "No se pudo eliminar el proyecto");
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
        
        

        /// <summary>
        /// Modifica un proyecto
        /// </summary>
        /// <returns>Confirmacion de que se modifico el proyecto</returns>
        [Authorize(Policy = "Administrador")]
        [HttpPut("{id}")]
        public async Task<IActionResult> Modificar([FromRoute] int id, ProyectoDTO dto)
        {
            var result = await _unitOfWork.ProyectoRepository.Update(new Proyecto(dto, id));
            if (!result)
            {
                return ResponseFactory.CreateErrorResponse(500, "No se pudo eliminar el proyecto");
            }
            else
            {
                await _unitOfWork.Complete();
                return ResponseFactory.CreateSuccessResponse(200, "Actualizado");
            }

        }

        
        
    
    }
}

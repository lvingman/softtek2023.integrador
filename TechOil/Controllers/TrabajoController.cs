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
    public class TrabajoController : ControllerBase
    {
        //Unit of work
        private readonly IUnitOfWork _unitOfWork;

        public TrabajoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        //#############
        //### ABML ####
        //#############

        /// <summary>
        /// Lista todos los trabajos
        /// </summary>
        /// <returns>Devuelve una lista de todos los trabajos</returns>
        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var trabajos = await _unitOfWork.TrabajoRepository.GetAllActive();
            //Paginado
            int pageToShow = 1;

            //Decide que pagina se muestra
            if (Request.Query.ContainsKey("page"))
            {
                int.TryParse(Request.Query["page"], out pageToShow);
            }

            var url = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}").ToString();
            var paginateUsers = PaginateHelper.Paginate(trabajos, pageToShow, url);

            return ResponseFactory.CreateSuccessResponse(200, paginateUsers);
        }


        /// <summary>
        /// Devuelve un trabajo en especifico
        /// </summary>
        /// <param name="id">Id del trabajo a buscar</param>
        /// <returns>Trabajo con el ID especificado</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarPorId([FromRoute] int id)
        {
            var busqueda = await _unitOfWork.TrabajoRepository.FindByID(id);
            if (busqueda is null)
            {
                return ResponseFactory.CreateErrorResponse(501, "Trabajo inexistente");
            }
            else
            {
                return ResponseFactory.CreateSuccessResponse(200, busqueda);
            }
            
        }

        /// <summary>
        /// Inserta un trabajo en la API
        /// </summary>
        /// <param name="trabajo">Trabajo a insertar</param>
        /// <returns>Confirmacion de insercion</returns>
        [Authorize(Policy = "Administrador")]
        [HttpPost]

        public async Task<IActionResult> Registrar(TrabajoDTO dto)
        {
            //Todo: Generar validacion de que se ingresaron los datos de manera correcta
            var trabajo = new Trabajo(dto);
            await _unitOfWork.TrabajoRepository.Insert(trabajo);
            await _unitOfWork.Complete();
            return ResponseFactory.CreateSuccessResponse(201, "Trabajo registrado con exito!");

        }

        /// <summary>
        /// Modifica un trabajo
        /// </summary>
        /// <param name="trabajo">Trabajo a modificar</param>
        /// <returns>Confirmacion de edicion</returns>
        [Authorize(Policy = "Administrador")]
        [HttpPut("{id}")]
        public async Task<IActionResult> Modificar([FromRoute] int id, TrabajoDTO dto)
        {
            var result = await _unitOfWork.TrabajoRepository.Update(new Trabajo(dto, id));
            if (!result)
            {
                return ResponseFactory.CreateErrorResponse(500, "No se pudo modificar el trabajo");
            }
            else
            {
                await _unitOfWork.Complete();
                return ResponseFactory.CreateSuccessResponse(200, "Actualizado");
            }

        }

        /// <summary>
        /// Elimina un trabajo de la API fisicamente
        /// </summary>
        /// <param name="id">Id del servicio a eliminar</param>
        /// <returns>Confirmacion de eliminacion fisica</returns>
        [HttpDelete("hd/{id}")]
        [Authorize(Policy = "Administrador")]
        public async Task<IActionResult> HardDelete([FromRoute] int id)
        {
            var result = await _unitOfWork.TrabajoRepository.HardDelete(id);

            if (!result)
            {
                return ResponseFactory.CreateErrorResponse(500, "No se pudo eliminar el trabajo");
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
            var result = await _unitOfWork.TrabajoRepository.SoftDelete(id);

            if (!result)
            {
                return ResponseFactory.CreateErrorResponse(500, "No se pudo eliminar el trabajo");
            }
            else
            {
                await _unitOfWork.Complete();
                return ResponseFactory.CreateSuccessResponse(200, "Eliminado logico concluido con exito!");
            }

        }






    }
    
}
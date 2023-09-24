using Microsoft.AspNetCore.Mvc;
using TechOil.Models;
using TechOil.Services;
using TechOil.DataAccess.Repositories;
using TechOil.DTO;
using Microsoft.AspNetCore.Authorization;
using TechOil.Helper;
using TechOil.Infrastructure;

namespace TechOil.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class RolController : ControllerBase
    {
        //Aplicar inyecciones y unitOfWork
        private readonly IUnitOfWork _unitOfWork;
        public RolController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Obtiene listado de todos los roles
        /// </summary>
        /// <returns>Listado de roles</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllActive()
        {
            var roles = await _unitOfWork.RolRepository.GetAllActive();

            int pageToShow = 1;
            
            //Decide que pagina se muestra
            if (Request.Query.ContainsKey("page"))
            {
                int.TryParse(Request.Query["page"], out pageToShow);
            }
            
            var url = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}").ToString();
            var paginateRoles = PaginateHelper.Paginate(roles, pageToShow, url);


            return ResponseFactory.CreateSuccessResponse(200, paginateRoles);
        }


        /// <summary>
        /// Registra un rol en la base de datos
        /// </summary>
        /// <param name="dto">Datos del rol a registrar</param>
        /// <returns>Confirmacion de registro</returns>
        
        [Authorize(Policy = "Administrador")]
        [HttpPost]
        public async Task<IActionResult> Insert(RolDTO dto)
        {

            var Rol = new Rol(dto);
            await _unitOfWork.RolRepository.Insert(Rol);
            await _unitOfWork.Complete();
            return Ok(true);
        }

        /// <summary>
        /// Modifica un rol en la base de datos
        /// </summary>
        /// <param name="id">Id del rol a modificar</param>
        /// <param name="dto">Datos del rol a cambiar</param>
        /// <returns>Confirmacion de modificacion</returns>
        
        [Authorize(Policy = "Administrador")]
        [HttpPut("{id}")]

        public async Task<IActionResult> Update([FromRoute] int id, RolDTO dto)
        {
            var result = await _unitOfWork.RolRepository.Update(new Rol(dto, id));

            await _unitOfWork.Complete();
            return Ok(true);
        }

        /// <summary>
        /// Eliminacion fisica de un rol de la base de datos
        /// </summary>
        /// <param name="id">Id de rol a eliminar</param>
        /// <returns>Confirmacion de eliminacion</returns>
        
        [Authorize(Policy = "Administrador")]
        [HttpDelete("hd/{id}")]

        public async Task<IActionResult> HardDelete([FromRoute] int id)
        {
            var result = await _unitOfWork.RolRepository.HardDelete(id);

            await _unitOfWork.Complete();
            return Ok(true);
        }
        
        /// <summary>
        /// Eliminacion logica de rol de la base de datos
        /// </summary>
        /// <param name="id">Id del rol a eliminar</param>
        /// <returns>Confirmacion de eliminacion</returns>
        [HttpDelete("sd/{id}")]
        public async Task<IActionResult> SoftDelete([FromRoute] int id)
        {
            var result = await _unitOfWork.RolRepository.SoftDelete(id);

            await _unitOfWork.Complete();
            return Ok(true);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using TechOil.Models;
using TechOil.Services;
using TechOil.DataAccess.Repositories;
using TechOil.DTO;
using Microsoft.AspNetCore.Authorization;

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

        //List
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rol>>> GetAllActive()
        {
            var Roles = await _unitOfWork.RolRepository.GetAllActive();

            return Roles;
        }


        //Insert
        [Authorize(Policy = "Administrador")]
        [HttpPost]
        public async Task<IActionResult> Insert(RolDTO dto)
        {

            var Rol = new Rol(dto);
            await _unitOfWork.RolRepository.Insert(Rol);
            await _unitOfWork.Complete();
            return Ok(true);
        }

        //Update
        [Authorize(Policy = "Administrador")]
        [HttpPut("{id}")]

        public async Task<IActionResult> Update([FromRoute] int id, RolDTO dto)
        {
            var result = await _unitOfWork.RolRepository.Update(new Rol(dto, id));

            await _unitOfWork.Complete();
            return Ok(true);
        }

        //Hard delete
        [Authorize(Policy = "Administrador")]
        [HttpDelete("hd/{id}")]

        public async Task<IActionResult> HardDelete([FromRoute] int id)
        {
            var result = await _unitOfWork.RolRepository.HardDelete(id);

            await _unitOfWork.Complete();
            return Ok(true);
        }
        
        //Soft Delete
        [HttpDelete("sd/{id}")]
        public async Task<IActionResult> SoftDelete([FromRoute] int id)
        {
            var result = await _unitOfWork.RolRepository.SoftDelete(id);

            await _unitOfWork.Complete();
            return Ok(true);
        }
    }
}

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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rol>>> GetAllActive()
        {
            var Roles = await _unitOfWork.RolRepository.GetAllActive();

            return Roles;
        }



        [HttpPost]
        public async Task<IActionResult> Insert(RolDTO dto)
        {

            var Rol = new Rol(dto);
            await _unitOfWork.RolRepository.Insert(Rol);
            await _unitOfWork.Complete();
            return Ok(true);
        }

        [Authorize(Policy = "Admin")]
        [HttpPut("{id}")]

        public async Task<IActionResult> Update([FromRoute] int id, RolDTO dto)
        {
            var result = await _unitOfWork.RolRepository.Update(new Rol(dto, id));

            await _unitOfWork.Complete();
            return Ok(true);
        }

        [HttpDelete("hd/{id}")]

        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var result = await _unitOfWork.RolRepository.HardDelete(id);

            await _unitOfWork.Complete();
            return Ok(true);
        }
    }
}

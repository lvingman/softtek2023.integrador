using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechOil.DTO;
using TechOil.Helper;
using TechOil.Services;

namespace TechOil.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]

public class LoginController : ControllerBase
{
    //Token para realizar las operaciones de la API
    private TokenJwtHelper _tokenJwtHelper;
    private readonly IUnitOfWork _unitOfWork;
    public LoginController(IUnitOfWork unitOfWork, IConfiguration configuration)
    {
        _unitOfWork = unitOfWork;
        _tokenJwtHelper = new TokenJwtHelper(configuration);
    }
    
/// <summary>
/// Permite a un usuario acceder a las funciones de la API
/// </summary>
/// <param name="dto">Datos de inicio de sesion</param>
/// <returns>Devuelve token para utilizar la API</returns>
    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Login(AutenticacionDTO dto)
    {
        var userCredentials = await _unitOfWork.UsuarioRepository.AuthenticateCredentials(dto);
        if (userCredentials is null) return Unauthorized();

        var token = _tokenJwtHelper.GenerateToken(userCredentials);

        var user = new LoginDTO()
        {
            Email = userCredentials.Email,
            Nombre = userCredentials.Nombre,
            Dni = userCredentials.Dni,
            Token = token
        };

        return Ok(user);

    }
    
    


}
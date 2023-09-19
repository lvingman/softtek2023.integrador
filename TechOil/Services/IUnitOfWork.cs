using TechOil.DataAccess.Repositories;
using TechOil.Models;

namespace TechOil.Services
{
    // Unit of Work sirve para contener el acceso a la db de todos los atributos en una clase
    public interface IUnitOfWork : IDisposable
    {
       public UsuarioRepository UsuarioRepository { get; }
       public RolRepository RolRepository { get; }
       public ServicioRepository ServicioRepository { get; }
       public ProyectoRepository ProyectoRepository { get; }
       

       Task<int> Complete();
    }
}


using TechOil.DataAccess.Repositories;

namespace TechOil.Services
{
    // Unit of Work sirve para contener el acceso a la db de todos los atributos en una clase
    public interface IUnitOfWork : IDisposable
    {
       public UsuarioRepository UsuarioRepository { get; }
        Task<int> Complete();
    }
}


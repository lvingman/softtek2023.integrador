namespace TechOil.Repositories;
using TechOil.Models;

//Armar repositorios dentro de DataAccess
public interface IUsuarioRepository
{
    Task <IEnumerable<Usuario>> ListarUsuarios();
    Task<Usuario> ObtenerUsuarioPorId(int id);
    Task AgregarUsuario(Usuario usuario);
    Task ActualizarUsuario(Usuario usuario);
    Task BorrarUsuario(Usuario usuario);
}
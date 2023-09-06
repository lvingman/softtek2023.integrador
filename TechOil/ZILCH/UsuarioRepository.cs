using TechOil.Models;

//Consultar por un repositorio de ejemplo, y como armar dichas clases repositorio

namespace TechOil.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Usuario _usuarioConfig;
        
        public UsuarioRepository(Usuario usuarioConfig)
        {
            _usuarioConfig = usuarioConfig;
        }
        
        public Task<IEnumerable<Usuario>> ListarUsuarios()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> ObtenerUsuarioPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task AgregarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task ActualizarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task BorrarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
    
}


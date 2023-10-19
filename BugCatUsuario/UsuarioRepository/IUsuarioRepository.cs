using BugCatUsuario.Models;
using System;
namespace BugCatUsuario.UsuarioRepository
{
    public interface IUsuarioRepository
    {
       public Task<IEnumerable<Usuario>> BuscarUsuarios();
        public Task<Usuario> BuscarUsuariosPorId(int id);
        public Task<Usuario> CrearUsuarios(Usuario usuario);
        public Task<Usuario> ActualizarUsuario(Usuario usuario);
        public Task<bool> EliminarUsuario(int id);

    }
}

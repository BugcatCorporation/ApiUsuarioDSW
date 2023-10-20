using BugCatUsuario.DbContexts;
using BugCatUsuario.Models;
using Microsoft.EntityFrameworkCore;

namespace BugCatUsuario.UsuarioRepository
{
    public class UsuariosRepository:IUsuarioRepository
    {
        private readonly AppDbContext bgcontext;

        public UsuariosRepository( AppDbContext bgcontext)
        {
            this.bgcontext = bgcontext;
        }

       
        public async Task<Usuario> ActualizarUsuario(Usuario usuario)
        {
            bgcontext.Usuarios.Update(usuario);
            await bgcontext.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario> BuscarUsuariosPorId(int id)
        {
            var usuario = await bgcontext.Usuarios.Where(c => c.UsuarioId == id).Include(tarj => tarj.tarjeta).FirstOrDefaultAsync();
            return usuario;
        }


        public async Task<Usuario> CrearUsuarios(Usuario usuario)
        {
            bgcontext.Usuarios.Add(usuario);
            await bgcontext.SaveChangesAsync();
            return usuario;
        }

      

        public async Task<bool> EliminarUsuario(int id)
        {
            var usuario = await bgcontext.Usuarios.FirstOrDefaultAsync(c => c.UsuarioId == id);
            if (usuario == null)
            {
                return false;
            }
            bgcontext.Usuarios.Remove(usuario);
            await bgcontext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Usuario>> BuscarUsuarios()
        {
            return await bgcontext.Usuarios.Include(tarj => tarj.tarjeta).ToListAsync(); 
        }
    }
}

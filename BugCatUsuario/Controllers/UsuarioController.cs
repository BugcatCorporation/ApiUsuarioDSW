
using BugCatUsuario.Models;
using BugCatUsuario.UsuarioRepository;
using Microsoft.AspNetCore.Mvc;
namespace BugCatUsuario.Controllers

{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository usuRepository;
        public UsuarioController(IUsuarioRepository usuRepository)
        {
            this.usuRepository = usuRepository;
        }

        [HttpGet]
        [Route("/buscarUsuario")]
        public async Task<IEnumerable<Usuario>> BuscarUsuarios()
        {
            return await usuRepository.BuscarUsuarios();
        }

        [HttpGet]
        [Route("/buscarUsuarioPorId/{id}")]
        public async Task<Usuario> BuscarUsuariosPorId(int id)
        {
            return await usuRepository.BuscarUsuariosPorId(id);
        }
        [HttpPost]
        [Route("/crearUsuario")]
        public async Task<Usuario> CrearUsuarios(Usuario usuario)
        {
            return await usuRepository.CrearUsuarios(usuario);
        }

        [HttpPut]
        [Route("/ActualizarUsuario")]
        public async Task<Usuario> ActualizarUsuarios(Usuario usuario)
        {
            return await usuRepository.ActualizarUsuario(usuario);
        }

        [HttpDelete]
        [Route("/EliminarUsuario")]
        public async Task<bool> EliminarUsuarios(int id)
        {
            return await usuRepository.EliminarUsuario(id);
        }

    }
}

using BugCatUsuario.Models;
using BugCatUsuario.TarjetaRepository;
using Microsoft.AspNetCore.Mvc;

namespace BugCatUsuario.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class TarjetaController: ControllerBase
    {
        private readonly ITarjetaRepository usuRepository;
        public TarjetaController(ITarjetaRepository usuRepository)
        {
            this.usuRepository = usuRepository;
        }

        [HttpGet]
        [Route("/buscarTarjeta")]
        public async Task<IEnumerable<Tarjeta>>BuscarTarjetas()
        {
            return await usuRepository.GetTarjetas();
        }

        [HttpGet]
        [Route("/buscarTarjetaPorId/{id}")]
        public async Task<Tarjeta> BuscarTarjetasPorId(int id)
        {
            return await usuRepository.BuscarTarjetasPorId(id);
        }
        [HttpPost]
        [Route("/crearTarjeta")]
        public async Task<Tarjeta> CrearTarjeta(Tarjeta tarjeta)
        {
            return await usuRepository.CrearTarjetas(tarjeta);
        }

        [HttpPut]
        [Route("/ActualizarTarjeta")]
        public async Task<Tarjeta> ActualizarTarjetas(Tarjeta tarjeta)
        {
            return await usuRepository.ActualizarTarjetas(tarjeta);
        }
        [HttpDelete]
        [Route("/EliminarTarjeta")]
        public async Task<bool> EliminarTarjeta(int id)
        {
            return await usuRepository.EliminarTarjetas(id);
        }
    }
}

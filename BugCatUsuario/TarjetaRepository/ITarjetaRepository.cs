using BugCatUsuario.Models;
using System;
namespace BugCatUsuario.TarjetaRepository
{
    public interface ITarjetaRepository
    {
        public Task<IEnumerable<Tarjeta>> BuscarTarjetas();
        public Task<Tarjeta> BuscarTarjetasPorId(int id);
        public Task<Tarjeta> CrearTarjetas(Tarjeta tarjeta);
        public Task<Tarjeta> ActualizarTarjetas(Tarjeta tarjeta);
        public Task<bool> EliminarTarjetas(int id);
    }
}

using BugCatUsuario.DbContexts;
using BugCatUsuario.Models;
using Microsoft.EntityFrameworkCore;

namespace BugCatUsuario.TarjetaRepository
{
    public class TarjetaRepository:ITarjetaRepository
    {
        private readonly AppDbContext bgcontext;

        public TarjetaRepository(AppDbContext bgcontext)
        {
            this.bgcontext = bgcontext;
        }

        public async Task<Tarjeta> ActualizarTarjetas(Tarjeta tarjeta)
        {
            bgcontext.Tarjetas.Update(tarjeta);
            await bgcontext.SaveChangesAsync();
            return tarjeta;
        }


        public async Task<Tarjeta> BuscarTarjetasPorId(int id)
        {
            var tarjeta = await bgcontext.Tarjetas.Where(c => c.TarjetaId == id).Include(u => u.usuario).FirstOrDefaultAsync();
            return tarjeta;
        }


        public async Task<Tarjeta> CrearTarjetas(Tarjeta tarjeta)
        {
            bgcontext.Tarjetas.Add(tarjeta);
            await bgcontext.SaveChangesAsync();
            return tarjeta;
        }

        public async Task<bool> EliminarTarjetas(int id)
        {
            var tarjeta = await bgcontext.Tarjetas.FirstOrDefaultAsync(c => c.TarjetaId == id);
            if (tarjeta == null)
            {
                return false;
            }
            bgcontext.Tarjetas.Remove(tarjeta);
            await bgcontext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Tarjeta>> GetTarjetas()
        {
            return await bgcontext.Tarjetas.Include(u => u.usuario).ToListAsync();
        }

    }
}

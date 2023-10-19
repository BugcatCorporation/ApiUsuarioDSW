using System;
using BugCatUsuario.Models;
using Microsoft.EntityFrameworkCore;
namespace BugCatUsuario.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarjeta> Tarjetas { get; set;}

    }
}

namespace BugCatUsuario.Models
{
    public class Tarjeta
    {
       public int TarjetaId { get; set; }
        public long nroTarjeta { get; set; }
        public string? fechaCad { get; set; }
        public int ccv { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

    }
}

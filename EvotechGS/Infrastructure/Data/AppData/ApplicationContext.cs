using EvotechGS.Models;
using Microsoft.EntityFrameworkCore;

namespace EvotechGS.Infrastructure.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<DispositivoModel> Dispositivo { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }
    }
}

using EvotechGS.Domain.Entities;
using EvotechGS.Models;
using Microsoft.EntityFrameworkCore;

namespace EvotechGS.Infrastructure.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<DispositivoEntity> Dispositivo { get; set; }
        public DbSet<UsuarioEntity> Usuario { get; set; }
    }
}

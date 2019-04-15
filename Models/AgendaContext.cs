using Microsoft.EntityFrameworkCore;

namespace RazorPagesAgenda.Models
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContextt> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesAgenda.Models.AGENDA> AGENDA { get; set; }
    }
}
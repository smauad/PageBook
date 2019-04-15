using Microsoft.EntityFrameworkCore;

namespace RazorPagesLista.Models
{
    public class ListaContext : DbContext
    {
        public ListaContext(DbContextOptions<ListaContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesLista.Models.LISTA> LISTA { get; set; }
    }
}
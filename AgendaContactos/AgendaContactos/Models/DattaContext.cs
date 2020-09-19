
namespace AgendaContactos.Models
{
    using System.Data.Entity;
    public class DattaContext:DbContext
    {
        public DattaContext(): base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<AgendaContactos.Models.Sivila> Sivilas { get; set; }
    }
}
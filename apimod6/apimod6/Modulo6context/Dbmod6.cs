using apimod6.model;
using Microsoft.EntityFrameworkCore;

namespace apimod6.Modulo6context
{
    public class Dbmod6 : DbContext 
    {
        public Dbmod6(DbContextOptions<Dbmod6> options) : base(options)
        {




        }
        public DbSet<Cliente> Cliente { get; set; }

    }
}

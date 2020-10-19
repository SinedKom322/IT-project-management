using Microsoft.EntityFrameworkCore;
using project.Entities;

namespace project
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; }
    }
}

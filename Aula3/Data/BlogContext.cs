using Aula3.Model;
using Microsoft.EntityFrameworkCore;

namespace Aula3.Data
{
    public class BlogContext:DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comentarios> Comentarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=blog;Integrated Security=SSPI;MultipleActiveResultSets=true");
        }
    }
}

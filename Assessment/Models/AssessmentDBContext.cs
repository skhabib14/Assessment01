using Microsoft.EntityFrameworkCore;

namespace Assessment.Models
{
    public partial class AssessmentDBContext : DbContext
    {
        public AssessmentDBContext()
        {
        }

        public AssessmentDBContext(DbContextOptions<AssessmentDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<moviesTable> Movies { get; set; }
    }
}

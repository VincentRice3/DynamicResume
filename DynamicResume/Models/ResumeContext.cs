using Microsoft.EntityFrameworkCore;

namespace DynamicResume.Models
{
    public class ResumeContext : DbContext
    {
        public DbSet<ResumeData> Resumes { get; set; }
        public DbSet<EmploymentHistory> EmploymentHistory { get; set; }
        public DbSet<Education> Education { get; set; }

        public DbSet<DevelopmentProjects> DevelopmentProjects { get; set; }

        public ResumeContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}

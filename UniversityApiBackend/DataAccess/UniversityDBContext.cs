using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options)
            : base(options)
        {
        }
        // TODO : Add DbSet (Tables of our Database)
        public DbSet<User>? Users { get; set; }
    }
    
}

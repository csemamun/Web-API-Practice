using Exam.Models;
using Microsoft.EntityFrameworkCore;

namespace Exam.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Registration>Registrations { get; set; }
    }
}

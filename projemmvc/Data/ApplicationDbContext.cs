using Microsoft.EntityFrameworkCore;
using projemmvc.Models;

namespace projemmvc.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {
        }
        public DbSet<Students> Students { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using ArmWrestlingApp.Models;

namespace ArmWrestlingApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        
        public DbSet<WorkoutEntry> WorkoutEntries => Set<WorkoutEntry>();
    }
}
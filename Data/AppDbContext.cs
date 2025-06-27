using Microsoft.EntityFrameworkCore;
using NicBackend.Models;

namespace NicBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<ServiceRequest> ServiceRequests { get; set; }
    }
}


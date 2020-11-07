using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.EntityFramework
{
    public class SampleContext : DbContext
    {
        public SampleContext(DbContextOptions options) : base(options) { }

        public DbSet<Sample> Sample { get; set; }
        public DbSet<SampleDetail> SampleDetail { get; set; }
    }
}

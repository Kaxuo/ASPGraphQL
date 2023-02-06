using API.Configurations;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace API.Context
{
    public class ApplicationDBContext : DbContext
    {
        private readonly IOptions<DatabaseOptionsConfig> _dbOptionsConfig = null!;
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options, IOptions<DatabaseOptionsConfig> config) : base(options)
        {
            _dbOptionsConfig = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbOptionsConfig.Value.SqlServer!);
        }
        public DbSet<Mails> Mails { get; set; } = null!;
    }
}
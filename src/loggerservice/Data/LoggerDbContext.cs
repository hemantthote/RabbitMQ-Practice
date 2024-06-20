using loggerservice;
using Microsoft.EntityFrameworkCore;

namespace loggerservice;

public class LoggerDbContext : DbContext
{
    public LoggerDbContext(DbContextOptions options) : base(options){

    }

    public DbSet<CustomError> CustomErrors { get; set; }
}

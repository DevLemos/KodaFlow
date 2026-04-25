using Microsoft.EntityFrameworkCore;

namespace KodaFlow.Infrastructure.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }
}

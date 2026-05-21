using Microsoft.EntityFrameworkCore;

namespace KodeFlow.Controllers;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
}

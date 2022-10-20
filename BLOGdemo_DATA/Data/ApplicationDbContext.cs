using Microsoft.EntityFrameworkCore;

namespace BLOGdemo_DATA.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

}

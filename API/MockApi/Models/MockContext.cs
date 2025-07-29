using Microsoft.EntityFrameworkCore;

namespace MockApi.Models;

public class MockContext : DbContext
{
    public MockContext(DbContextOptions<MockContext> options)
        : base(options)
    {
    }

    public DbSet<MockItem> MockItems { get; set; } = null!;
}
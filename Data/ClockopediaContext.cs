using Microsoft.EntityFrameworkCore;
using Clockopedia.Models;

namespace Clockopedia.Data
{
    public class ClockopediaContext : DbContext
    {
        public ClockopediaContext(DbContextOptions<ClockopediaContext> options)
            : base(options)
        {
        }

        public DbSet<Clock> Clock { get; set; }
    }
}
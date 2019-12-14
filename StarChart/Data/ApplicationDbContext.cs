using Microsoft.EntityFrameworkCore;
using StarChart.Models;

namespace StarChart.Data
{
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public DbSet<CelestialObject> CelestialObjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}

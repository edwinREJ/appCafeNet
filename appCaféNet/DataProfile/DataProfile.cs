using Microsoft.EntityFrameworkCore;
using appCafeNet.Models;

namespace appCafeNet.Data
{
    public class DataProfile : DbContext
    {
        public DataProfile(DbContextOptions<DataProfile> options) : base(options) { }

        public DbSet<Profile> Profiles { get; set; }
    }
}



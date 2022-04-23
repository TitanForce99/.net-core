using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApplication1.Models;

namespace WebApplication1.DataOperations
{
    public class Context:DbContext
    {
        IConfiguration _configuration;
        public Context(IConfiguration configuration, DbContextOptions<Context> dbContextOptions) : base(dbContextOptions)
        {
            _configuration = configuration;
        }
       
        public DbSet<Ogrenci> Ogrencis { get; set; }
    }
}

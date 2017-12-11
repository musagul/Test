using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TakipSistemi.Data.Core;

namespace TakipSistemi.Data
{
    public class Startup
    {
        public void Configure()
        {
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<Context>();
            services.AddSingleton<DbContextOptions>(new DbContextOptionsBuilder<Context>().Options);
        }
    }
}

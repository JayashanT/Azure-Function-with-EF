using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Data
{
    public static class DbCollectionExtenstions
    {
        public static IServiceCollection RegisterDataServices(this IServiceCollection services)
        {
            services.AddOptions();
            services.AddDbContext<SampleDbContext>(options => options.UseSqlServer("Server = tcp:jayashandbserver.database.windows.net,1433; Initial Catalog = azurefunctiondb; Persist Security Info = False; User ID = jayashan; Password = Jayash123+; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30"));
            return services;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void AddInfrastructureServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DojoWebContext>(
                options => options
                    .UseLazyLoadingProxies()
                    .UseSqlServer(connectionString ?? throw new InvalidOperationException("Connection string 'DojoWebContext' not found.")));

        }
    }
}

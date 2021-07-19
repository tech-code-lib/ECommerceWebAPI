using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ECommerce.DAL.Contexts;

namespace ECommerceWebAPI.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<ECommDBContext>(opts => 
            opts.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => 
            {
                b.EnableRetryOnFailure();
            }));
    }
}

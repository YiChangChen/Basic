using Basic.Infrastructure.Entities;
using Basic.Infrastructure.Services;
using Basic.Models.Menu;
using Basic.Services.MenuService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Infrastructure.ConfigureServices
{
    public static class ServicesConfiguration
    {
        /// <summary>
        /// DI service
        /// </summary>
        /// <param name="services"></param>
        public static void DIService(this IServiceCollection services)
        {
            services.AddTransient<IMenuService, MenuService>();
        }

        /// <summary>
        /// DB
        /// </summary>
        /// <param name="services"></param>
        /// <param name="Configuration"></param>
        public static void DB(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<BasicContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

        /// <summary>
        /// 自訂Exception
        /// </summary>
        /// <param name="services"></param>
        public static IServiceCollection NimbleExceptionHandler(this IServiceCollection services, Action<string> appName)
        {
            //services.AddTransient<NimbleExceptionService, NimbleExceptionService>();
            return services;
        }       
    }
}

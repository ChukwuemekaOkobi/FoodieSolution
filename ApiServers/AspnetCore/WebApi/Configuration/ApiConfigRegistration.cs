
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApi.Configuration
{
    public static class Dependency
    {

        public static void AddApiConfiguration(this IServiceCollection services)
        {

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api", Version = "v1" });
            });
        }

        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration Configuration)
        {
           
        }
    
        public static void AddSettingsandAuthentication(this IServiceCollection services, IConfiguration Configuration)
        {
          

        }
    
        public static void AddServices(this IServiceCollection services)
        {


        }
    }
}

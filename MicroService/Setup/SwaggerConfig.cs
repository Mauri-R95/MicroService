using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MicroService.Api.Config
{
    public static class SwaggerConfig
    {
        //Descripción y documnentacion de apps, Testing
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            var basepath = System.AppDomain.CurrentDomain.BaseDirectory;
            var xmlPath = System.IO.Path.Combine(basepath, "MicroService.xml");
            services.AddSwaggerGen(c =>
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "MicroService API",
                    Version = "1.0"
                })

            );
            return services;
        }

        public static IApplicationBuilder AddRegistration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MicroService API"));
            return app;
        }
    }

}

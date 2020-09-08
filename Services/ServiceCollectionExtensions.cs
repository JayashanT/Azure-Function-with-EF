using System;
using System.Collections.Generic;
using System.Text;
//using azFunctionApp.Services;
using Microsoft.Extensions.DependencyInjection;


namespace Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IDummyServices, DummyServices>();
            return services;
        }
    }
}
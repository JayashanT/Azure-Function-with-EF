using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Data;


[assembly: FunctionsStartup(typeof(FunctionApp.Startup))]

namespace FunctionApp
{
    class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddLogging();
            builder.Services.RegisterServices();
            builder.Services.RegisterDataServices();
            
        }
    }
}

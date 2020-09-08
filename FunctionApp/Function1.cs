using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Services;

namespace FunctionApp
{
    public class Function1
    {
        private IDummyServices _dummyServices;
        public Function1(IDummyServices dummyServices)
        {
            _dummyServices = dummyServices;
        }

 

        [FunctionName("Function1")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            return new OkObjectResult(_dummyServices.GetUsers());
        }
    }
}

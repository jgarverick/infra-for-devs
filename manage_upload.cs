using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace infra_for_devs
{
    public class manage_upload
    {
        private readonly ILogger<manage_upload> _logger;

        public manage_upload(ILogger<manage_upload> logger)
        {
            _logger = logger;
        }

        [Function("manage_upload")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}

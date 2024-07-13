using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace infra_for_devs
{
    public class AcceptUpload
    {
        private readonly ILogger<AcceptUpload> _logger;

        public AcceptUpload(ILogger<AcceptUpload> logger)
        {
            _logger = logger;
        }

        [Function("AcceptUpload")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}

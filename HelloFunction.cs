using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hrd_csharp_azfunction_devops_git
{
    public class HelloFunction
    {
        private readonly ILogger<HelloFunction> _logger;

        public HelloFunction(ILogger<HelloFunction> logger)
        {
            _logger = logger;
        }

        [Function("HelloFunction")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request. 07/07/2025 17:28");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}

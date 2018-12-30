namespace ExampleRegistry.Api.Infrastructure
{
    using System.Reflection;
    using System.Threading;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Net.Http.Headers;

    [ApiVersionNeutral]
    [Route("")]
    public class EmptyController : ApiController
    {
        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Get(
            [FromServices] IHostingEnvironment hostingEnvironment,
            CancellationToken cancellationToken)
        {
            return Request.Headers[HeaderNames.Accept].ToString().Contains("text/html")
                ? (IActionResult)new RedirectResult("/docs")
                : new OkObjectResult($"Welcome to the Example Api v{Assembly.GetEntryAssembly().GetName().Version}.");
        }
    }
}

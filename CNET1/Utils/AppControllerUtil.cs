using Microsoft.AspNetCore.Mvc;

namespace CNET1.Utils
{
    public abstract class AppControllerUtil<T>(ILogger<T> logger) : ControllerBase
    {
        protected readonly ILogger<T> Logger = logger;

        protected void InfoMethod(string NameMethod, string Message) { 
            Logger.LogInformation($"{NameMethod}: {Message}");
        }

        protected void StartMethod(string NameMethod)
        {
            Logger.LogDebug($"Start > {NameMethod}");
        }

        protected void EndMethod(string NameMethod)
        {
            Logger.LogDebug($"End > {NameMethod}");
        }
    }
}

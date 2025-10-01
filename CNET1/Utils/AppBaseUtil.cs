namespace CNET1.Utils
{
    public abstract class AppBaseUtil<T>(ILogger<T> logger)
    {

        protected readonly ILogger<T> Logger = logger;

        internal void InfoMethod(string NameMethod, string Message)
        {
            Logger.LogInformation($"{NameMethod}: {Message}");
        }

        internal void StartMethod(string NameMethod)
        {
            Logger.LogDebug($"Start > {NameMethod}");
        }

        internal void EndMethod(string NameMethod)
        {
            Logger.LogDebug($"End > {NameMethod}");
        }
    }
}

using Microsoft.Extensions.Logging;
using Serilog;
using LoggerExtensions = Microsoft.Extensions.Logging.LoggerExtensions;

namespace XSX.Garden.MAUI.Services;

public class HelloWorldService : BaseService
{
    private readonly ISecureStorage _secureStorage;
    private readonly ILogger<HelloWorldService> _logger;

    public HelloWorldService(ISecureStorage secureStorage, ILogger<HelloWorldService> logger)
    {
        _secureStorage = secureStorage;
        _logger = logger;
    }
    public async Task<string> SayHello()
    {
        var value = await _secureStorage.GetAsync("Welcome");
        if (value != null)
        {
            Logger.LogInformation("没有写入缓存33");
            return value;
        }
        Logger.LogError("写入了缓存");
        value = $"Hello, World!{DateTime.Now:hh:mm:ss}";
        await _secureStorage.SetAsync("Welcome", value);
        return value;
    }

    public void WriteLog()
    {
        _logger.LogInformation("没有写入缓存1");
    }
}
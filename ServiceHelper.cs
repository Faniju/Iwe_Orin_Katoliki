namespace YorubaCatholicHymn;

public static class ServiceHelper
{
    public static T GetService<T>() where T : class =>
        Current.GetService<T>() ?? throw new InvalidOperationException($"Service {typeof(T)} not registered.");


    public static IServiceProvider Current =>
        IPlatformApplication.Current?.Services
        ?? throw new InvalidOperationException("App not initialized");
}
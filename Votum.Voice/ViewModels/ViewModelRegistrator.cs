using Microsoft.Extensions.DependencyInjection;

namespace Votum.Voice.ViewModels
{
    internal static class ViewModelRegistrator
    {
        internal static IServiceCollection ViewModelRegistrate(this IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();
            return services;
        }
    }
}

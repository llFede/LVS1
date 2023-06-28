using System.Reflection;
using System.Windows.Navigation;
using LVS1.wpf.Navigation;
using LVS1.wpf.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace LVS1.wpf.Extensions;

public static class ViewExtensions
{
    public static IServiceCollection MapViewModels(this IServiceCollection services, Assembly assembly)
    {
        var types = assembly
            .GetExportedTypes()
            .Where(type => Attribute.IsDefined(type, typeof(ViewModelAttribute)))
            .Where(type => !type.IsAbstract);

        foreach (var type in types)
        {
            services.AddTransient(type);
        }

        return services;
    }
}
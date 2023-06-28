using System.Reflection;
using System.Windows;
using LVS1.wpf.Data;
using LVS1.wpf.Extensions;
using LVS1.wpf.Managers;
using LVS1.wpf.Navigation;
using LVS1.wpf.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LVS1.wpf
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IServiceProvider serviceProvider;
        public App()
        {
            serviceProvider = new ServiceCollection()
                .AddDbContext<ApplicationDbContext>(options =>
                {
                    options.UseSqlite("Data source=app.db");
                })
                .AddTransient<UserManager>()
                /* Navigation */
                .AddSingleton<MainWindow>()
                .AddSingleton<MainViewModel>()
                .MapViewModels(Assembly.GetAssembly(typeof(App)))
                
                .AddSingleton<NavigationStore>()
                .AddSingleton<NavigationServiceFactory>()
                /*
                .AddTransient<NavigationService<RegisterViewModel>>()
                .AddTransient<Func<RegisterViewModel>>(s => s.GetRequiredService<RegisterViewModel>)*/
                .BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            serviceProvider.GetRequiredService<NavigationServiceFactory>().GetNavigationService<LoginViewModel>().Navigate();
            
            MainWindow = serviceProvider.GetRequiredService<MainWindow>();
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}

using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Application;
public static class ApplicationServiceRegistration 
{
    public static void ConfigureApplicationService(this IServiceCollection services) {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}

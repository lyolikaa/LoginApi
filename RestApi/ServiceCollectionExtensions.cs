using Microsoft.EntityFrameworkCore;
using RestApi.Services;

namespace RestApi;

public static class ServiceCollectionExtensions
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<INotificationService, NotificationService>();
    }

    public static void AddDbServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<UserContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


    }


}
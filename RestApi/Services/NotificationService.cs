namespace RestApi.Services;

public interface INotificationService
{
    void PostLogin();
}

public class NotificationService : INotificationService
{
    public NotificationService(IConfiguration configuration)
    {
        
    }

    public void PostLogin()
    {
        throw new NotImplementedException();
    }
}
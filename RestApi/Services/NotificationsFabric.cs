namespace RestApi.Services;

interface INotificationsFabric
{
    INotificationService CreateService(IConfiguration configuration);
}

public class NotificationsFabric : INotificationsFabric
{
    public INotificationService CreateService(IConfiguration configuration)
    {
        throw new NotImplementedException();
    }

}
using RestApi.Models;

namespace RestApi.Services;

public interface IUserService
{
    Task<User> Authenticate(string username, string password);
}

public class UserService : IUserService
{
    private readonly List<User> _users = new()
    {
        new() { Id = 1, Username = "user1", Password = "password1" },
        new() { Id = 2, Username = "user2", Password = "password2" }
    };

    public User Authenticate(string username, string password)
    {
        return _users.SingleOrDefault(x => x.Username == username && x.Password == password);
    }
}
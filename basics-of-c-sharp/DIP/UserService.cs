namespace basics_of_c_sharp.DIP;

public interface IUserRepository
{
    string GetUserById(int id);
}
public class UserRepository:IUserRepository
{
    public string GetUserById(int id)
    {
        // Code to fetch user from the database
        return "User";
    }
}

public class UserService
{
    private IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public string GetUser(int id)
    {
        return _userRepository.GetUserById(id);
    }
}

public class DIPTest
{
    public static void Main()
    {
        UserService userService = new UserService(new UserRepository());
        Console.WriteLine(userService.GetUser(2));
    }
}
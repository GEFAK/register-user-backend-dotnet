using register_user_backend_dotnet.application.Users.Dto;

namespace register_user_backend_dotnet.application.Users;

public class UserService : IUserService
{
    private static List<UserDto> _userList = new List<UserDto>();

    public List<UserDto> GetUserList()
    {
        if (_userList.Count == 0)
        {
            _userList = new List<UserDto>
            {
                new UserDto("Mustermann", "Max", "max@deinemail.de", "Hallo ich bin Max und code gerne in Java"),
                new UserDto("Doe", "Jane", "jane@deinemail.de", "Hallo ich bin Jane und code gerne in C#")
            };
        }
        
        return _userList;
    }

    public void CreateUser(UserDto user)
    {
        
        throw new NotImplementedException();
    }
}
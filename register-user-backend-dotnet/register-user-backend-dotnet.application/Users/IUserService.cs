using register_user_backend_dotnet.application.Users.Dto;

namespace register_user_backend_dotnet.application.Users;

public interface IUserService
{
    public List<UserDto> GetUserList();
    
    public void CreateUser(UserDto user);
}
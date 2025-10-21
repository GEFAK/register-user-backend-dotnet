using System.ComponentModel.DataAnnotations;

namespace register_user_backend_dotnet.application.Users.Dto;

public record UserDto( string name,
    string vorname,
    string email,
    string? nachricht);
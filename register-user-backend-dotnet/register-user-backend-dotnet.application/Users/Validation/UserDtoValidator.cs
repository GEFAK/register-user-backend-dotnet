using FluentValidation;
using register_user_backend_dotnet.application.Users.Dto;

namespace register_user_backend_dotnet.application.Users.Validation;

public class UserDtoValidator : AbstractValidator<UserDto>
{
    public UserDtoValidator()
    {
        RuleFor(x => x.name).NotEmpty();
        RuleFor(x => x.vorname).NotEmpty();
        RuleFor(x => x.email).NotEmpty().EmailAddress();

    }
}
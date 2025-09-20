using Polyglot.Core.Entities;
using Polyglot.Core.Interfaces;

namespace Polyglot.Core.UseCases.Users
{
    public record CreateUserInput(string Firstname, string Lastname, string Nickname, string Email);

    public record CreateUserOutput(string UserId, string Email);

    public class CreateUserUseCase
    {
        private readonly IUserRepository _userRepository;

        public CreateUserUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<CreateUserOutput> ExecuteAsync(CreateUserInput input)
        {
            if (await _userRepository.ExistsAsync(input.Email))
            {
                throw new CannotUnloadAppDomainException("User with this email already exists.");
            }

            var user = new User(
                firstname: input.Firstname,
                lastname: input.Lastname,
                nickname: input.Nickname,
                email: input.Email
            );

            await _userRepository.AddAsync(user);

            return new CreateUserOutput(user.UserId, user.Email);
        }
    }
}

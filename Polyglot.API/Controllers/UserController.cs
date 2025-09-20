using Microsoft.AspNetCore.Mvc;
using Polyglot.API.Models;
using Polyglot.Core.Exceptions;
using Polyglot.Core.UseCases.Users;

namespace Polyglot.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly CreateUserUseCase _createUserUseCase;

    public UsersController(CreateUserUseCase createUserUseCase)
    {
        _createUserUseCase = createUserUseCase;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<User>> CreateUser([FromBody] CreateUser user)
    {
        try
        {
            var input = new CreateUserInput(
                user.Firstname,
                user.Lastname,
                user.Nickname,
                user.Email
            );

            var result = await _createUserUseCase.ExecuteAsync(input);

            var userDto = new User(
                result.UserId,
                user.Firstname,
                user.Lastname,
                user.Nickname,
                user.Email
            );

            return CreatedAtAction(nameof(CreateUser), userDto);
        }
        catch (Exception ex) when (ex is ArgumentException || ex is DomainException)
        {
            return BadRequest(new { error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { error = "An internal error has occurred." });
        }
    }
}
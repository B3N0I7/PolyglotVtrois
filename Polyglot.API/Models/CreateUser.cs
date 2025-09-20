using System.ComponentModel.DataAnnotations;

namespace Polyglot.API.Models;

public record CreateUser(
    [Required][StringLength(50)] string Firstname,
    [Required][StringLength(50)] string Lastname,
    [Required][StringLength(30)] string Nickname,
    [Required][EmailAddress] string Email
);

public record User(
    string UserId,
    string Firstname,
    string Lastname,
    string Nickname,
    string Email
);
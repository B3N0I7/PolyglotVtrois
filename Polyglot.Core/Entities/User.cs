using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Polyglot.Core.Entities
{

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string UserId { get; private set; }

    [BsonElement("firstname")]
    public string Firstname { get; private set; } = string.Empty;

    [BsonElement("lastname")]
    public string Lastname { get; private set; } = string.Empty;

    [BsonElement("nickname")]
    public string Nickname { get; private set; } = string.Empty;

    [BsonElement("email")]
    public string Email { get; private set; } = string.Empty;

    private User() { }

    public User(string firstname, string lastname, string nickname, string email)
    {
        Firstname = firstname ?? throw new ArgumentNullException(nameof(firstname));
        Lastname = lastname ?? throw new ArgumentNullException(nameof(lastname));
        Nickname = nickname ?? throw new ArgumentNullException(nameof(nickname));
        Email = email ?? throw new ArgumentNullException(nameof(email));

        if (!IsValidEmail(email)) { 
                throw new ArgumentException("Invalid email format", nameof(email));
            }
        }

        private static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}

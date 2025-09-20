namespace Polyglot.Core.Entities
{
    public class User
    {
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Nickname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

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

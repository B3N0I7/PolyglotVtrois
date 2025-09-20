namespace Polyglot.Core.Entities
{
    public class Word
    {
        public string WordId { get; set; } = Guid.NewGuid().ToString();
        public string UserId { get; set; } = string.Empty;
        public string EnglishWord { get; set; } = string.Empty;
        public string FrenchWord { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Family { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;
    }
}

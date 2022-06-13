using Map.Core.Interfaces;

namespace Map.Data.Entities
{
    public class User : ISoftDeleteable
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Username { get; set; }
        public ICollection<Article> OwnArticle { get; set; }
    }
}

using Map.Core.Interfaces;

namespace Map.Data.Entities
{
    public class ArticleTag : ISoftDeleteable
    {
        public int Id { get; set; }
        public string Tag { get; set; }
    }
}

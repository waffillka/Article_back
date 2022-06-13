namespace Map.Data.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ArticleText { get; set; }
        public DateTime CreationData { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<ArticleTag>? Tags { get; set; }
    }
}

using Map.Core.Interfaces;

namespace Map.Data.Entities
{
    public class Language : ISoftDeleteable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExtraName { get; set; }
        public string Description { get; set; }

    }
}

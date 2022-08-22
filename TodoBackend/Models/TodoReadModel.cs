namespace TodoBackend.Models
{
    public class TodoReadModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int HybridCol { get; set; }
        public bool IsFinished { get; set; }
    }
}

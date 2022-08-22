namespace TodoBackend.Models
{
    public class Todo
    {
        public Todo(Guid id, string title, bool isFinished)
        {
            Id = id;
            Title = title;
            IsFinished = isFinished;    
        }

        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Importance { get; set; } = 0;
        public bool IsFinished { get; set; }
    }
}

namespace TodoList.Data.Models
{
    public class Todo
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public bool IsCompleted { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}

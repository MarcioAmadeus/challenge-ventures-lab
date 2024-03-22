namespace DevIO.Business.Models
{
    public class TaskManagement : Entity
    {
        public Guid UserId { get; set; }

        public DateTime Date { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

    }
}
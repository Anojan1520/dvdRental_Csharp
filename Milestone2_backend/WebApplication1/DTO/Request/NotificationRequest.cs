namespace WebApplication1.DTO.Request
{
    public class NotificationRequest
    {
        public Guid rentedId { get; set; }
        public int rentedQuantity { get; set; }
        public Guid movieId { get; set; }
        public Guid UserId { get; set; }
        public DateOnly RequestDate { get; set; }
        public string Status { get; set; }
    }
}

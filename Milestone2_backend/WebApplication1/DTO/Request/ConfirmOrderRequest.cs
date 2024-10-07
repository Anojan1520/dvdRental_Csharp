namespace WebApplication1.DTO.Request
{
    public class ConfirmOrderRequest
    {
        public string movie { get; set; }
        public decimal totalRent { get; set; }
        public Guid userId { get; set; }
        public DateOnly rentDate { get; set; }
        public DateOnly ReturnDate { get; set; }
        public Guid movieId { get; set; }
    }
}

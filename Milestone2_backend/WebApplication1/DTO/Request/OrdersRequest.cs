namespace WebApplication1.DTO.Request
{
    public class OrdersRequest
    {
        public Guid RentedId { get; set; }
        public Guid MovieId { get; set; }
        public Guid UserId { get; set; }
        public int RentedQuantity { get; set; }
        public DateTime RentedDate { get; set; }
    }
}

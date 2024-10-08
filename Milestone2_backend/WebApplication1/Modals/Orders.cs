namespace WebApplication1.Modals
{
    public class Orders
    {
        public Guid Id { get; set; }
        public Guid RentedId { get; set; }
        public Guid MovieId { get; set; }
        public Guid UserId { get; set; }
        public int RentedQuantity { get; set; }
        public DateTime RentedDate { get; set; }


    }
}


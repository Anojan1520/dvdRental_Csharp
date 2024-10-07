using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplication1.Modals
{
    public class Notifications
    {
        public Guid id { get; set; }
        public Guid rentedId { get; set; }
        public int rentedQuantity { get; set; }
        public Guid movieId { get; set; }
        public Guid UserId { get; set; }
        public DateOnly RequestDate { get; set; }
        public string Status { get; set; }


    }
}

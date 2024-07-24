

namespace RestaurantReservationDb.domain
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}

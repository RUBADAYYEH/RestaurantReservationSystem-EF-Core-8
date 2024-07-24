
namespace RestaurantReservationDb.domain
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Position { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        List<Order> Orders { get; set; }
    }
}

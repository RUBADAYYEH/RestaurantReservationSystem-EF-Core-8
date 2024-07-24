using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
using RestaurantReservationDb.domain;


namespace RestaurantReservationDb.Repositories
{
    public class OrderRepository
    {
        public static void AddOrder(int ReservationId, int EmployeeId, DateTime OrderDate, float TotalAmount)
        {
            var order = new Order { ReservationId = ReservationId, EmployeeId = EmployeeId, OrderDate = OrderDate, TotalAmount = TotalAmount };
            using var context = new RestaurantReservationDbContext();
            var orders = context.Orders.Add(order);
            context.SaveChanges();
        }
        static async Task<List<Order>> ListOrdersAndMenuItems(int ReservationId)
        {
            using var context = new RestaurantReservationDbContext();
            var orders = await context.Orders
                                      .Include(o => o.OrderItems)
                                      .ThenInclude(oi => oi.MenuItem)
                                      .Where(o => o.ReservationId == ReservationId)
                                      .ToListAsync();

            return orders;
        }
        static async Task<float> CalculateAverageOrderAmount(int id)
        {
            using var context = new RestaurantReservationDbContext();
            var avg = await context.Orders.Select(em => em).Where(em => em.EmployeeId == id).Select(m => m.TotalAmount).AverageAsync();
            return avg;
        }
    }
}

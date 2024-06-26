using RestaurantReservation.Db;
using RestaurantReservationDb.domain;


namespace RestaurantReservationDb.Repositories
{
    public class OrderItemRepository
    {
        public static void AddOrderItem(int OrderId, int MenuItemId, int Quantity)
        {
            var orderItem = new OrderItem { OrderId = OrderId, MenuItemId = MenuItemId, Quantity = Quantity };
            using var context = new RestaurantReservationDbContext();
            var customers = context.OrderItems.Add(orderItem);
            context.SaveChanges();
        }
    }
}

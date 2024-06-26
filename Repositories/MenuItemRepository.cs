using RestaurantReservation.Db;
using RestaurantReservationDb.domain;


namespace RestaurantReservationDb.Repositories
{
    public class MenuItemRepository
    {
        public static void AddMenuItem(int RestaurantId, string Name, string Description, float Price)
        {
            var menuitem = new MenuItem { RestaurantId = RestaurantId, Name = Name, Description = Description, Price = Price };
            using var context = new RestaurantReservationDbContext();
            var customers = context.MenuItems.Add(menuitem);
            context.SaveChanges();
        }
    }
}

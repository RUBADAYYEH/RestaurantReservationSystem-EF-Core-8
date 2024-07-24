using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
using RestaurantReservationDb.domain;
using System.Data.Common;


namespace RestaurantReservationDb.Repositories
{
    public class RestaurantRepository
    {
        public static void AddRestaurant(string name, string address, string phoneNumber, string openingHours)
        {
            var restaurant = new Restaurant { Name = name, Address = address, PhoneNumber = phoneNumber, OpeningHours = openingHours };
            using var context = new RestaurantReservationDbContext();
            var customers = context.Restaurants.Add(restaurant);
            context.SaveChanges();

        }
        public static void UpdateRestaurant(int restaurantId, string newName, string newAddress, string newPhoneNumber, string newOpeningHours)
        {
            using var context = new RestaurantReservationDbContext();
            var restaurant = context.Restaurants.FirstOrDefault(r => r.RestaurantId == restaurantId);
            if (restaurant != null)
            {
                restaurant.Name = newName;
                restaurant.Address = newAddress;
                restaurant.PhoneNumber = newPhoneNumber;
                restaurant.OpeningHours = newOpeningHours;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Restaurant not found.");
            }
        }

        public static void DeleteRestaurant(int restaurantId)
        {
            using var context = new RestaurantReservationDbContext();
            var restaurant = context.Restaurants.FirstOrDefault(r => r.RestaurantId == restaurantId);
            if (restaurant != null)
            {
                context.Restaurants.Remove(restaurant);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Restaurant not found.");
            }
        }
        // Implement the function call in your RestaurantReservation.Db project, making it accessible from your application.
        public static async Task<decimal> GetTotalRevenueForARestaurantAsync()
        {
            using var context = new RestaurantReservationDbContext();
            using (DbCommand command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT dbo.GetTotalRevenue(1) AS TotalRevenue";
                await context.Database.OpenConnectionAsync();

                decimal result = (decimal)(await command.ExecuteScalarAsync());


                await context.Database.CloseConnectionAsync();
                return result;
            }
        }
    }
}

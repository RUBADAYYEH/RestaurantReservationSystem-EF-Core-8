using RestaurantReservation.Db;
using RestaurantReservationDb.domain;


namespace RestaurantReservationDb.Repositories
{
    public class TableRepository
    {
        public static void AddTable(int RestaurantId, int capacity)
        {
            var table = new Table { RestaurantId = RestaurantId, Capacity = capacity };
            using var context = new RestaurantReservationDbContext();
            var tables = context.Tables.Add(table);
            context.SaveChanges();
        }
        public static void UpdateTable(int tableId, int newCapacity)
        {
            using var context = new RestaurantReservationDbContext();
            var table = context.Tables.FirstOrDefault(t => t.TableId == tableId);
            if (table != null)
            {
                table.Capacity = newCapacity;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Table not found.");
            }
        }
        public static void DeleteTable(int tableId)
        {
            using var context = new RestaurantReservationDbContext();
            var table = context.Tables.FirstOrDefault(t => t.TableId == tableId);
            if (table != null)
            {
                context.Tables.Remove(table);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Table not found.");
            }
        }



    }
}

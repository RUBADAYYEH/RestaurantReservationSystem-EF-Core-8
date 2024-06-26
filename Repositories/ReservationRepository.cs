using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
using RestaurantReservationDb.domain;


namespace RestaurantReservationDb.Repositories
{
    public class ReservationRepository
    {
        public static void AddReservation(int CustomerId, int RestaurantId, int TableId, DateTime ReservationDate, int PartySize)
        {
            var reservation = new Reservation { CustomerId = CustomerId, RestaurantId = RestaurantId, TableId = TableId, ReservationDate = ReservationDate, PartySize = PartySize };
            using var context = new RestaurantReservationDbContext();
            var reservations = context.Reservations.Add(reservation);
            context.SaveChanges();
        }
        public static void UpdateReservation(int reservationId, int newPartySize)
        {
            using var context = new RestaurantReservationDbContext();
            var reservation = context.Reservations.FirstOrDefault(r => r.ReservationId == reservationId);
            if (reservation != null)
            {
                reservation.PartySize = newPartySize;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Reservation not found.");
            }
        }

        public static void DeleteReservation(int reservationId)
        {
            using var context = new RestaurantReservationDbContext();
            var reservation = context.Reservations.FirstOrDefault(r => r.ReservationId == reservationId);
            if (reservation != null)
            {
                context.Reservations.Remove(reservation);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Reservation not found.");
            }
            static async Task<List<Reservation>> GetReservationsByCustomer(int id)
            {
                using var context = new RestaurantReservationDbContext();
                var reservations = await context.Reservations.Select(em => em).Where(em => em.CustomerId == id).ToListAsync();
                return reservations;
            }
        }
    }
}

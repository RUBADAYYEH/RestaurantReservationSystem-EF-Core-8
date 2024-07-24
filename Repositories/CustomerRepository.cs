using RestaurantReservation.Db;
using RestaurantReservationDb.domain;


namespace RestaurantReservationDb.Repositories
{
    public class CustomerRepository
    {
        public static void AddCustomer(string firstname, string lastname, string email, string phone)
        {
            var customer = new Customer { Firstname = firstname, Lastname = lastname, Email = email, PhoneNumber = phone };
            using var context = new RestaurantReservationDbContext();
            var customers = context.Customers.Add(customer);
            context.SaveChanges();
        }
        public static void DeleteCustomer(int customerId)
        {
            using var context = new RestaurantReservationDbContext();
            var customer = context.Customers.FirstOrDefault(c => c.CustomerId == customerId);
            if (customer != null)
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }
        public static void UpdateCustomer(int customerId, string firstname, string lastname, string email, string phone)
        {
            using var context = new RestaurantReservationDbContext();
            var customer = context.Customers.FirstOrDefault(c => c.CustomerId == customerId);
            if (customer != null)
            {
                customer.Firstname = firstname;
                customer.Lastname = lastname;
                customer.Email = email;
                customer.PhoneNumber = phone;
                context.SaveChanges();
            }
        }
    }
}

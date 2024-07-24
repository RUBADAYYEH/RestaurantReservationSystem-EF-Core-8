
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RestaurantReservationDb.domain;
using System.Data.Common;


namespace RestaurantReservation.Db
{
    public class RestaurantReservationDbContext :DbContext
    {
       public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Table> Tables { get; set; }
        public RestaurantReservationDbContext() { }
        public RestaurantReservationDbContext(DbContextOptions<RestaurantReservationDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LENOVO;Database=RestaurantReservationCore;User Id=sa;Password=ruby; Trusted_Connection = true; TrustServerCertificate=True;  ").LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name },
                    LogLevel.Information).EnableSensitiveDataLogging();
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Customer>().HasData(
                   new Customer { CustomerId = 1, Firstname = "John", Lastname = "Doe", Email = "john.doe@example.com", PhoneNumber = "1234567890" },
                   new Customer { CustomerId = 2, Firstname = "Jane", Lastname = "Smith", Email = "jane.smith@example.com", PhoneNumber = "9876543210" },
                   new Customer { CustomerId = 3, Firstname = "Alice", Lastname = "Johnson", Email = "alice.johnson@example.com", PhoneNumber = "5551234567" },
                   new Customer { CustomerId = 4, Firstname = "Bob", Lastname = "Brown", Email = "bob.brown@example.com", PhoneNumber = "9998887777" },
                   new Customer { CustomerId = 5, Firstname = "Emily", Lastname = "Wilson", Email = "emily.wilson@example.com", PhoneNumber = "1112223333" }

               );
            modelBuilder.Entity<Employee>().HasData(
              new Employee { EmployeeId = 1, Firstname = "Michael", Lastname = "Smith", Position = "Chef", RestaurantId = 1 },
              new Employee { EmployeeId = 2, Firstname = "Sarah", Lastname = "Johnson", Position = "Waiter", RestaurantId = 2 },
              new Employee { EmployeeId = 3, Firstname = "David", Lastname = "Williams", Position = "Manager", RestaurantId = 3 },
              new Employee { EmployeeId = 4, Firstname = "Emma", Lastname = "Brown", Position = "Chef", RestaurantId = 4 },
              new Employee { EmployeeId = 5, Firstname = "James", Lastname = "Jones", Position = "Waiter", RestaurantId = 5 }
          );
            modelBuilder.Entity<Restaurant>().HasData(
            new Restaurant { RestaurantId = 1, Name = "Fast Food Restaurant", Address = "123 Main St", PhoneNumber = "555-1234", OpeningHours = "10AM-10PM" },
            new Restaurant { RestaurantId = 2, Name = "SeaFood Restaurant", Address = "456 Elm St", PhoneNumber = "555-5678", OpeningHours = "11AM-11PM" },
            new Restaurant { RestaurantId = 3, Name = "Italian Restaurant", Address = "789 Oak St", PhoneNumber = "555-9012", OpeningHours = "12PM-12AM" },
            new Restaurant { RestaurantId = 4, Name = "Chinese Restaurant", Address = "456 Elm St", PhoneNumber = "555-5678", OpeningHours = "11AM-11PM" },
            new Restaurant { RestaurantId = 5, Name = "Indian Restaurant", Address = "789 Oak St", PhoneNumber = "555-9012", OpeningHours = "12PM-12AM" }
        );
            modelBuilder.Entity<MenuItem>().HasData(
             new MenuItem { MenuItemId = 1, RestaurantId = 1, Name = "Burger", Description = "Delicious burger", Price = 9.99f },
             new MenuItem { MenuItemId = 2, RestaurantId = 1, Name = "Pizza", Description = "Authentic Italian pizza", Price = 12.99f },
             new MenuItem { MenuItemId = 3, RestaurantId = 3, Name = "Steak", Description = "Juicy steak", Price = 19.99f },
             new MenuItem { MenuItemId = 4, RestaurantId = 3, Name = "Pasta", Description = "Classic pasta dish", Price = 14.99f },
             new MenuItem { MenuItemId = 5, RestaurantId = 4, Name = "Sushi", Description = "Fresh sushi rolls", Price = 16.99f },
              new MenuItem { MenuItemId = 6, RestaurantId = 4, Name = "Sweet and Sour Chicken", Description = "Classic Chinese dish", Price = 12.99f },
     
        new MenuItem { MenuItemId = 7, RestaurantId = 5, Name = "Tandoori Chicken", Description = "Spicy grilled chicken", Price = 15.99f },
        new MenuItem { MenuItemId = 8, RestaurantId = 5, Name = "Butter Chicken", Description = "Creamy tomato-based curry", Price = 13.99f }



         );
            modelBuilder.Entity<Table>().HasData(
           new Table { TableId = 1, RestaurantId = 1, Capacity = 4 },
           new Table { TableId = 2, RestaurantId = 1, Capacity = 6 },
           new Table { TableId = 3, RestaurantId = 2, Capacity = 8 },
           new Table { TableId = 4, RestaurantId = 2, Capacity = 10 },
           new Table { TableId = 5, RestaurantId = 3, Capacity = 4 },
           new Table { TableId = 6, RestaurantId = 4, Capacity = 8 },
           new Table { TableId = 7, RestaurantId = 4, Capacity = 10 },
           new Table { TableId = 8, RestaurantId = 5, Capacity = 8 },
           new Table { TableId = 9, RestaurantId = 5 ,Capacity = 10 }
       );
            modelBuilder.Entity<Reservation>().HasData(
              // Example reservation data
              new Reservation { ReservationId = 1, CustomerId = 1, RestaurantId = 1, TableId = 1, ReservationDate = DateTime.Now.AddDays(1), PartySize = 4 },
              new Reservation { ReservationId = 2, CustomerId = 2, RestaurantId = 1, TableId = 3, ReservationDate = DateTime.Now.AddDays(2), PartySize = 6 },
              new Reservation { ReservationId = 3, CustomerId = 3, RestaurantId = 3, TableId = 5, ReservationDate = DateTime.Now.AddDays(3), PartySize = 2 },
              new Reservation { ReservationId = 4, CustomerId = 2, RestaurantId = 3, TableId = 7, ReservationDate = DateTime.Now.AddDays(2), PartySize = 6 },
              new Reservation { ReservationId = 5, CustomerId = 3, RestaurantId = 5, TableId = 9, ReservationDate = DateTime.Now.AddDays(3), PartySize = 2 }
          );
            modelBuilder.Entity<OrderItem>().HasData(
     new OrderItem { OrderItemId = 1, MenuItemId = 1, OrderId = 1, Quantity = 1 },
     new OrderItem { OrderItemId = 2, MenuItemId = 2, OrderId = 1, Quantity = 1 },
     new OrderItem { OrderItemId = 3, MenuItemId = 3, OrderId = 2, Quantity = 1 },
     new OrderItem { OrderItemId = 4, MenuItemId = 4, OrderId = 2, Quantity = 1 },
     new OrderItem { OrderItemId = 5, MenuItemId = 7, OrderId = 3, Quantity = 1 }
 );
            modelBuilder.Entity<Order>().HasData(
              
                new Order { OrderId = 1, ReservationId = 1, EmployeeId = 1, OrderDate = DateTime.Now.AddDays(1), TotalAmount = 23 },
                new Order { OrderId = 2, ReservationId = 2, EmployeeId = 1, OrderDate = DateTime.Now.AddDays(2), TotalAmount = 36 },
                new Order { OrderId = 3, ReservationId = 3, EmployeeId = 3, OrderDate = DateTime.Now.AddDays(3), TotalAmount = 42 },
                new Order { OrderId = 4, ReservationId = 4, EmployeeId = 3, OrderDate = DateTime.Now.AddDays(4), TotalAmount = 19 },
                new Order { OrderId = 5, ReservationId = 5, EmployeeId = 5, OrderDate = DateTime.Now.AddDays(5), TotalAmount = 27 }
            );
        }
        public List<Customer> FindCustomersByPartySize(int partySize)
        {
            var partySizeParameter = new SqlParameter("@PartySize", partySize);

            var customers = this.Customers
                .FromSqlRaw("EXEC FindCustomersByPartySize @PartySize", partySizeParameter)
                .ToList();

            return customers;
        }












    }
   
}

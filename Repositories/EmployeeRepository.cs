using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
using RestaurantReservationDb.domain;


namespace RestaurantReservationDb.Repositories
{
    public class EmployeeRepository
    {
        public static void AddEmployee(string firstname, string lastname, string position, int restid)
        {
            var employee = new Employee { Firstname = firstname, Lastname = lastname, Position = position, RestaurantId = restid };
            using var context = new RestaurantReservationDbContext();
            var customers = context.Employees.Add(employee);
            context.SaveChanges();
        }
        public static void DeleteEmployee(int employeeId)
        {
            using var context = new RestaurantReservationDbContext();
            var employee = context.Employees.FirstOrDefault(e => e.EmployeeId == employeeId);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
        }
        public static void UpdateEmployee(int employeeId, string firstname, string lastname, string position, int restid)
        {
            using var context = new RestaurantReservationDbContext();
            var employee = context.Employees.FirstOrDefault(e => e.EmployeeId == employeeId);
            if (employee != null)
            {
                employee.Firstname = firstname;
                employee.Lastname = lastname;
                employee.Position = position;
                employee.RestaurantId = restid;
                context.SaveChanges();
            }
        }
        static async Task<List<Employee>> GetManagerEmployees()
        {
            using var context = new RestaurantReservationDbContext();
            var managers = await context.Employees.Select(em => em).Where(em => em.Position == "Manager").ToListAsync();
            return managers;
        }
    }
}

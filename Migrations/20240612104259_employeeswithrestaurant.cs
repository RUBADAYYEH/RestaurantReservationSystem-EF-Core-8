using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservationDb.Migrations
{
    /// <inheritdoc />
    public partial class employeeswithrestaurant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW employeeswithrestaurants
            AS SELECT Employees.EmployeeId ,Employees.Position,
            Employees.Firstname + Employees.Lastname as EmployeeName,
            Restaurants.RestaurantId,Restaurants.Name,Restaurants.Address
            FROM Employees LEFT JOIN Restaurants ON Restaurants.RestaurantId=Employees.RestaurantId
            
            ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW IF EXISTS employeeswithrestaurants;");
        }
    }
}

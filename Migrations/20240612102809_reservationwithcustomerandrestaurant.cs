using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservationDb.Migrations
{
    /// <inheritdoc />
    public partial class reservationwithcustomerandrestaurant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW reservationwithcustomerandrestaurant
            AS SELECT Reservations.ReservationId , Reservations.ReservationDate,Customers.CustomerId,
            Customers.Firstname + Customers.Lastname as CustomerName,Customers.
			Email,Customers.PhoneNumber,
            Restaurants.RestaurantId,Restaurants.Name,Restaurants.Address
            FROM Reservations LEFT JOIN Customers ON Reservations.CustomerId=Customers.CustomerId
            LEFT JOIN Restaurants ON Reservations.RestaurantId=Restaurants.RestaurantId
 
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW IF EXISTS reservationwithcustomerandrestaurant;");
        }
    }
}

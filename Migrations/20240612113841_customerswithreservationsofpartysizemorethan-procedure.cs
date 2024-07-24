using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservationDb.Migrations
{
    /// <inheritdoc />
    public partial class customerswithreservationsofpartysizemorethanprocedure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE PROCEDURE FindCustomersByPartySize  @PartySize INT
                AS BEGIN 
                 SELECT Customers.CustomerId,Customers.Firstname+Customers.Lastname as Name,Customers.Email,Customers.PhoneNumber
                 FROM Customers INNER JOIN Reservations ON Reservations.CustomerId=Customers.CustomerId WHERE Reservations.PartySize >  @PartySize
                END
               ");
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS FindCustomersByPartySize");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservationDb.Migrations
{
    /// <inheritdoc />
    public partial class totalrevenuefunction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
               CREATE FUNCTION GetTotalRevenue(@RestaurantId INT)
               RETURNS DECIMAL
               AS
               BEGIN 
                  DECLARE @TotalRevenue DECIMAL;
                  SELECT @TotalRevenue = SUM(Orders.TotalAmount)
                  FROM ORDERS INNER JOIN Reservations ON Orders.ReservationId = Reservations.ReservationId
                  WHERE Reservations.RestaurantId=@RestaurantId ;
                  RETURN @TotalRevenue;
              END

            
               ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS GetTotalRevenue;");
        }
    }
}

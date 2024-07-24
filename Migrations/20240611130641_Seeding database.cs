using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantReservationDb.Migrations
{
    /// <inheritdoc />
    public partial class Seedingdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "OrderItems");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "Firstname", "Lastname", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "John", "Doe", "1234567890" },
                    { 2, "jane.smith@example.com", "Jane", "Smith", "9876543210" },
                    { 3, "alice.johnson@example.com", "Alice", "Johnson", "5551234567" },
                    { 4, "bob.brown@example.com", "Bob", "Brown", "9998887777" },
                    { 5, "emily.wilson@example.com", "Emily", "Wilson", "1112223333" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Address", "Name", "OpeningHours", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "123 Main St", "Fast Food Restaurant", "10AM-10PM", "555-1234" },
                    { 2, "456 Elm St", "SeaFood Restaurant", "11AM-11PM", "555-5678" },
                    { 3, "789 Oak St", "Italian Restaurant", "12PM-12AM", "555-9012" },
                    { 4, "456 Elm St", "Chinese Restaurant", "11AM-11PM", "555-5678" },
                    { 5, "789 Oak St", "Indian Restaurant", "12PM-12AM", "555-9012" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Firstname", "Lastname", "Position", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "Michael", "Smith", "Chef", 1 },
                    { 2, "Sarah", "Johnson", "Waiter", 2 },
                    { 3, "David", "Williams", "Manager", 3 },
                    { 4, "Emma", "Brown", "Chef", 4 },
                    { 5, "James", "Jones", "Waiter", 5 }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemId", "Description", "Name", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "Delicious burger", "Burger", 9.99f, 1 },
                    { 2, "Authentic Italian pizza", "Pizza", 12.99f, 1 },
                    { 3, "Juicy steak", "Steak", 19.99f, 3 },
                    { 4, "Classic pasta dish", "Pasta", 14.99f, 3 },
                    { 5, "Fresh sushi rolls", "Sushi", 16.99f, 4 },
                    { 6, "Classic Chinese dish", "Sweet and Sour Chicken", 12.99f, 4 },
                    { 7, "Spicy grilled chicken", "Tandoori Chicken", 15.99f, 5 },
                    { 8, "Creamy tomato-based curry", "Butter Chicken", 13.99f, 5 }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableId", "Capacity", "RestaurantId" },
                values: new object[,]
                {
                    { 1, 4, 1 },
                    { 2, 6, 1 },
                    { 3, 8, 2 },
                    { 4, 10, 2 },
                    { 5, 4, 3 },
                    { 6, 8, 4 },
                    { 7, 10, 4 },
                    { 8, 8, 5 },
                    { 9, 10, 5 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[,]
                {
                    { 1, 1, 4, new DateTime(2024, 6, 12, 16, 6, 41, 144, DateTimeKind.Local).AddTicks(3118), 1, 1 },
                    { 2, 2, 6, new DateTime(2024, 6, 13, 16, 6, 41, 144, DateTimeKind.Local).AddTicks(3168), 1, 3 },
                    { 3, 3, 2, new DateTime(2024, 6, 14, 16, 6, 41, 144, DateTimeKind.Local).AddTicks(3171), 3, 5 },
                    { 4, 2, 6, new DateTime(2024, 6, 13, 16, 6, 41, 144, DateTimeKind.Local).AddTicks(3173), 3, 7 },
                    { 5, 3, 2, new DateTime(2024, 6, 14, 16, 6, 41, 144, DateTimeKind.Local).AddTicks(3176), 5, 9 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "EmployeeId", "OrderDate", "ReservationId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 12, 16, 6, 41, 144, DateTimeKind.Local).AddTicks(3218), 1, 23f },
                    { 2, 1, new DateTime(2024, 6, 13, 16, 6, 41, 144, DateTimeKind.Local).AddTicks(3222), 2, 36f },
                    { 3, 3, new DateTime(2024, 6, 14, 16, 6, 41, 144, DateTimeKind.Local).AddTicks(3224), 3, 42f },
                    { 4, 3, new DateTime(2024, 6, 15, 16, 6, 41, 144, DateTimeKind.Local).AddTicks(3226), 4, 19f },
                    { 5, 5, new DateTime(2024, 6, 16, 16, 6, 41, 144, DateTimeKind.Local).AddTicks(3229), 5, 27f }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemId", "MenuItemId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 1, 1 },
                    { 3, 3, 2, 1 },
                    { 4, 4, 2, 1 },
                    { 5, 7, 3, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

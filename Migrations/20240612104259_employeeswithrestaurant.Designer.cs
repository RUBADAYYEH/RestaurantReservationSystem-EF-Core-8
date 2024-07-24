﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantReservation.Db;

#nullable disable

namespace RestaurantReservationDb.Migrations
{
    [DbContext(typeof(RestaurantReservationDbContext))]
    [Migration("20240612104259_employeeswithrestaurant")]
    partial class employeeswithrestaurant
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestaurantReservationDb.domain.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Email = "john.doe@example.com",
                            Firstname = "John",
                            Lastname = "Doe",
                            PhoneNumber = "1234567890"
                        },
                        new
                        {
                            CustomerId = 2,
                            Email = "jane.smith@example.com",
                            Firstname = "Jane",
                            Lastname = "Smith",
                            PhoneNumber = "9876543210"
                        },
                        new
                        {
                            CustomerId = 3,
                            Email = "alice.johnson@example.com",
                            Firstname = "Alice",
                            Lastname = "Johnson",
                            PhoneNumber = "5551234567"
                        },
                        new
                        {
                            CustomerId = 4,
                            Email = "bob.brown@example.com",
                            Firstname = "Bob",
                            Lastname = "Brown",
                            PhoneNumber = "9998887777"
                        },
                        new
                        {
                            CustomerId = 5,
                            Email = "emily.wilson@example.com",
                            Firstname = "Emily",
                            Lastname = "Wilson",
                            PhoneNumber = "1112223333"
                        });
                });

            modelBuilder.Entity("RestaurantReservationDb.domain.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Firstname = "Michael",
                            Lastname = "Smith",
                            Position = "Chef",
                            RestaurantId = 1
                        },
                        new
                        {
                            EmployeeId = 2,
                            Firstname = "Sarah",
                            Lastname = "Johnson",
                            Position = "Waiter",
                            RestaurantId = 2
                        },
                        new
                        {
                            EmployeeId = 3,
                            Firstname = "David",
                            Lastname = "Williams",
                            Position = "Manager",
                            RestaurantId = 3
                        },
                        new
                        {
                            EmployeeId = 4,
                            Firstname = "Emma",
                            Lastname = "Brown",
                            Position = "Chef",
                            RestaurantId = 4
                        },
                        new
                        {
                            EmployeeId = 5,
                            Firstname = "James",
                            Lastname = "Jones",
                            Position = "Waiter",
                            RestaurantId = 5
                        });
                });

            modelBuilder.Entity("RestaurantReservationDb.domain.MenuItem", b =>
                {
                    b.Property<int>("MenuItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuItemId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("MenuItemId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            MenuItemId = 1,
                            Description = "Delicious burger",
                            Name = "Burger",
                            Price = 9.99f,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 2,
                            Description = "Authentic Italian pizza",
                            Name = "Pizza",
                            Price = 12.99f,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 3,
                            Description = "Juicy steak",
                            Name = "Steak",
                            Price = 19.99f,
                            RestaurantId = 3
                        },
                        new
                        {
                            MenuItemId = 4,
                            Description = "Classic pasta dish",
                            Name = "Pasta",
                            Price = 14.99f,
                            RestaurantId = 3
                        },
                        new
                        {
                            MenuItemId = 5,
                            Description = "Fresh sushi rolls",
                            Name = "Sushi",
                            Price = 16.99f,
                            RestaurantId = 4
                        },
                        new
                        {
                            MenuItemId = 6,
                            Description = "Classic Chinese dish",
                            Name = "Sweet and Sour Chicken",
                            Price = 12.99f,
                            RestaurantId = 4
                        },
                        new
                        {
                            MenuItemId = 7,
                            Description = "Spicy grilled chicken",
                            Name = "Tandoori Chicken",
                            Price = 15.99f,
                            RestaurantId = 5
                        },
                        new
                        {
                            MenuItemId = 8,
                            Description = "Creamy tomato-based curry",
                            Name = "Butter Chicken",
                            Price = 13.99f,
                            RestaurantId = 5
                        });
                });

            modelBuilder.Entity("RestaurantReservationDb.domain.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<float>("TotalAmount")
                        .HasColumnType("real");

                    b.HasKey("OrderId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            EmployeeId = 1,
                            OrderDate = new DateTime(2024, 6, 13, 13, 42, 58, 830, DateTimeKind.Local).AddTicks(775),
                            ReservationId = 1,
                            TotalAmount = 23f
                        },
                        new
                        {
                            OrderId = 2,
                            EmployeeId = 1,
                            OrderDate = new DateTime(2024, 6, 14, 13, 42, 58, 830, DateTimeKind.Local).AddTicks(779),
                            ReservationId = 2,
                            TotalAmount = 36f
                        },
                        new
                        {
                            OrderId = 3,
                            EmployeeId = 3,
                            OrderDate = new DateTime(2024, 6, 15, 13, 42, 58, 830, DateTimeKind.Local).AddTicks(782),
                            ReservationId = 3,
                            TotalAmount = 42f
                        },
                        new
                        {
                            OrderId = 4,
                            EmployeeId = 3,
                            OrderDate = new DateTime(2024, 6, 16, 13, 42, 58, 830, DateTimeKind.Local).AddTicks(784),
                            ReservationId = 4,
                            TotalAmount = 19f
                        },
                        new
                        {
                            OrderId = 5,
                            EmployeeId = 5,
                            OrderDate = new DateTime(2024, 6, 17, 13, 42, 58, 830, DateTimeKind.Local).AddTicks(787),
                            ReservationId = 5,
                            TotalAmount = 27f
                        });
                });

            modelBuilder.Entity("RestaurantReservationDb.domain.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<int>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            OrderItemId = 1,
                            MenuItemId = 1,
                            OrderId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            OrderItemId = 2,
                            MenuItemId = 2,
                            OrderId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            OrderItemId = 3,
                            MenuItemId = 3,
                            OrderId = 2,
                            Quantity = 1
                        },
                        new
                        {
                            OrderItemId = 4,
                            MenuItemId = 4,
                            OrderId = 2,
                            Quantity = 1
                        },
                        new
                        {
                            OrderItemId = 5,
                            MenuItemId = 7,
                            OrderId = 3,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("RestaurantReservationDb.domain.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("PartySize")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("TableId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            ReservationId = 1,
                            CustomerId = 1,
                            PartySize = 4,
                            ReservationDate = new DateTime(2024, 6, 13, 13, 42, 58, 830, DateTimeKind.Local).AddTicks(630),
                            RestaurantId = 1,
                            TableId = 1
                        },
                        new
                        {
                            ReservationId = 2,
                            CustomerId = 2,
                            PartySize = 6,
                            ReservationDate = new DateTime(2024, 6, 14, 13, 42, 58, 830, DateTimeKind.Local).AddTicks(694),
                            RestaurantId = 1,
                            TableId = 3
                        },
                        new
                        {
                            ReservationId = 3,
                            CustomerId = 3,
                            PartySize = 2,
                            ReservationDate = new DateTime(2024, 6, 15, 13, 42, 58, 830, DateTimeKind.Local).AddTicks(698),
                            RestaurantId = 3,
                            TableId = 5
                        },
                        new
                        {
                            ReservationId = 4,
                            CustomerId = 2,
                            PartySize = 6,
                            ReservationDate = new DateTime(2024, 6, 14, 13, 42, 58, 830, DateTimeKind.Local).AddTicks(700),
                            RestaurantId = 3,
                            TableId = 7
                        },
                        new
                        {
                            ReservationId = 5,
                            CustomerId = 3,
                            PartySize = 2,
                            ReservationDate = new DateTime(2024, 6, 15, 13, 42, 58, 830, DateTimeKind.Local).AddTicks(703),
                            RestaurantId = 5,
                            TableId = 9
                        });
                });

            modelBuilder.Entity("RestaurantReservationDb.domain.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RestaurantId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningHours")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            RestaurantId = 1,
                            Address = "123 Main St",
                            Name = "Fast Food Restaurant",
                            OpeningHours = "10AM-10PM",
                            PhoneNumber = "555-1234"
                        },
                        new
                        {
                            RestaurantId = 2,
                            Address = "456 Elm St",
                            Name = "SeaFood Restaurant",
                            OpeningHours = "11AM-11PM",
                            PhoneNumber = "555-5678"
                        },
                        new
                        {
                            RestaurantId = 3,
                            Address = "789 Oak St",
                            Name = "Italian Restaurant",
                            OpeningHours = "12PM-12AM",
                            PhoneNumber = "555-9012"
                        },
                        new
                        {
                            RestaurantId = 4,
                            Address = "456 Elm St",
                            Name = "Chinese Restaurant",
                            OpeningHours = "11AM-11PM",
                            PhoneNumber = "555-5678"
                        },
                        new
                        {
                            RestaurantId = 5,
                            Address = "789 Oak St",
                            Name = "Indian Restaurant",
                            OpeningHours = "12PM-12AM",
                            PhoneNumber = "555-9012"
                        });
                });

            modelBuilder.Entity("RestaurantReservationDb.domain.Table", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TableId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("TableId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            TableId = 1,
                            Capacity = 4,
                            RestaurantId = 1
                        },
                        new
                        {
                            TableId = 2,
                            Capacity = 6,
                            RestaurantId = 1
                        },
                        new
                        {
                            TableId = 3,
                            Capacity = 8,
                            RestaurantId = 2
                        },
                        new
                        {
                            TableId = 4,
                            Capacity = 10,
                            RestaurantId = 2
                        },
                        new
                        {
                            TableId = 5,
                            Capacity = 4,
                            RestaurantId = 3
                        },
                        new
                        {
                            TableId = 6,
                            Capacity = 8,
                            RestaurantId = 4
                        },
                        new
                        {
                            TableId = 7,
                            Capacity = 10,
                            RestaurantId = 4
                        },
                        new
                        {
                            TableId = 8,
                            Capacity = 8,
                            RestaurantId = 5
                        },
                        new
                        {
                            TableId = 9,
                            Capacity = 10,
                            RestaurantId = 5
                        });
                });

            modelBuilder.Entity("RestaurantReservationDb.domain.Employee", b =>
                {
                    b.HasOne("RestaurantReservationDb.domain.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantReservationDb.domain.MenuItem", b =>
                {
                    b.HasOne("RestaurantReservationDb.domain.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantReservationDb.domain.Order", b =>
                {
                    b.HasOne("RestaurantReservationDb.domain.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantReservationDb.domain.Reservation", "Reservation")
                        .WithMany("Orders")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("RestaurantReservationDb.domain.OrderItem", b =>
                {
                    b.HasOne("RestaurantReservationDb.domain.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantReservationDb.domain.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItem");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("RestaurantReservationDb.domain.Reservation", b =>
                {
                    b.HasOne("RestaurantReservationDb.domain.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantReservationDb.domain.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantReservationDb.domain.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Restaurant");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("RestaurantReservationDb.domain.Table", b =>
                {
                    b.HasOne("RestaurantReservationDb.domain.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantReservationDb.domain.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("RestaurantReservationDb.domain.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("RestaurantReservationDb.domain.Reservation", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}

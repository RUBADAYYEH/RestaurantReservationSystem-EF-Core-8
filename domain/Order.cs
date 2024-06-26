﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservationDb.domain
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalAmount { get; set; }
       public List<OrderItem> OrderItems { get; set; }
    }
}
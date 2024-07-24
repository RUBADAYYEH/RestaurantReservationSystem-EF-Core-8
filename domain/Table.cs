using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservationDb.domain
{

    public class Table
    {
        public int TableId { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public int Capacity { get; set; }
        List<Reservation> Reservations { get; set; }
    }
}

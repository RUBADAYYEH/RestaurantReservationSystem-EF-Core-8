using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservationDb.domain
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public string Name {  get; set; }
        public string Description {  get; set; }
        public float Price {  get; set; }
        List<OrderItem> OrderItems { get; set; }
    }
}

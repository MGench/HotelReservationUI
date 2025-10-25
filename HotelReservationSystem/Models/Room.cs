using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Models
{
    public class Room
    {
        public int RoomId { get; set; } //PK
        public string RoomNumber { get; set; }
        public string RoomType { get; set; } // Single, Double
        public decimal PricePerNight { get; set; }
        public ICollection<Reservation> Reservations { get; set; } // One to Many Reservations
    }
}

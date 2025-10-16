using HotelReservationSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelReservationUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using var context = new HotelDbContext();
            var roomTypes = context.Rooms.Select(r => r.RoomType).Distinct().ToList();
            cmbRoomType.DataSource = roomTypes;

            LoadReservations(); // Show existing bookings
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            using var context = new HotelDbContext();

            // Create or fetch guest
            var guest = new Guest
            {
                FullName = txtGuestName.Text
                // Add other guest fields if needed
            };
            context.Guests.Add(guest);
            context.SaveChanges(); // Save to get GuestId

            // Get selected room
            var selectedRoomType = cmbRoomType.SelectedItem.ToString();
            var room = context.Rooms.FirstOrDefault(r => r.RoomType == selectedRoomType);

            if (room == null)
            {
                MessageBox.Show("Selected room type not found.");
                return;
            }

            // Create reservation
            var reservation = new Reservation
            {
                GuestId = guest.GuestId,
                RoomId = room.RoomId,
                CheckInDate = dtpCheckIn.Value,
                CheckOutDate = dtpCheckOut.Value
            };

            context.Reservations.Add(reservation);
            context.SaveChanges();

            MessageBox.Show("Reservation saved!");
            LoadReservations();
        }

        private void LoadReservations()
        {
            using var context = new HotelDbContext();

            var reservations = context.Reservations
                .Include(r => r.Guest)
                .Include(r => r.Room)
                .Select(r => new
                {
                    r.ReservationId,
                    GuestName = r.Guest.FullName,
                    RoomType = r.Room.RoomType,
                    r.CheckInDate,
                    r.CheckOutDate
                })
                .ToList();

            dataGridViewReservations.DataSource = reservations;
        }

    }
}

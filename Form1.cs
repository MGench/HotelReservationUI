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

                if (!context.Rooms.Any())
                {
                    context.Rooms.AddRange(new[]
                    {
            new Room { RoomNumber = "101", RoomType = "Single", PricePerNight = 75 },
            new Room { RoomNumber = "102", RoomType = "Double", PricePerNight = 120 },
            new Room { RoomNumber = "201", RoomType = "Suite", PricePerNight = 200 }
        });

                    context.SaveChanges();
                }


            // Load full room choices into ComboBox
            var roomChoices = context.Rooms
                .Select(r => new
                {
                    Display = $"Room {r.RoomNumber} – {r.RoomType} – £{r.PricePerNight}",
                    Value = r.RoomId
                })
                .ToList();

            cmbRoomType.DisplayMember = "Display";
            cmbRoomType.ValueMember = "Value";
            cmbRoomType.DataSource = roomChoices;
            cmbRoomType.Refresh();

            LoadReservations(); // Show existing bookings
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            using var context = new HotelDbContext();

            // Create guest
            var guest = new Guest
            {
                FullName = txtGuestName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text
            };
            context.Guests.Add(guest);
            context.SaveChanges();

            // Get selected room
            if (cmbRoomType.SelectedValue == null)
            {
                MessageBox.Show("Please select a room before booking.");
                return;
            }

            int selectedRoomId = (int)cmbRoomType.SelectedValue;
            var room = context.Rooms.FirstOrDefault(r => r.RoomId == selectedRoomId);

            if (room == null)
            {
                MessageBox.Show("Selected room not found.");
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
                    PricePerNight = r.Room.PricePerNight,
                    r.CheckInDate,
                    r.CheckOutDate,
                    TotalCost = EF.Functions.DateDiffDay(r.CheckInDate, r.CheckOutDate) * r.Room.PricePerNight
                })
                .ToList();

            dataGridViewReservations.DataSource = reservations;
        }
    }
}
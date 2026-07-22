

namespace Task7Solution
{
    public class Guest
    {
        // Attributes
        public string GuestId { get; set; }
        public string GuestName { get; set; }
        public string RoomNumber { get; set; } // Default: "Not Assigned"
        public string CheckInDate { get; set; }
        public int TotalNights { get; set; }

        // Associated Room reference
        private Room BookedRoom { get; set; }

        // Constructor
        public Guest(string guestId, string guestName, string checkInDate, int totalNights)
        {
            GuestId = guestId;
            GuestName = guestName;
            RoomNumber = "Not Assigned";
            CheckInDate = checkInDate;
            TotalNights = totalNights;
        }

        // Methods
        public void AssignRoom(Room room)
        {
            BookedRoom = room;
            RoomNumber = room.RoomNumber;
        }

        public void ClearRoom()
        {
            BookedRoom = null;
            RoomNumber = "Not Assigned";
        }

        public double CalculateTotalCost()
        {
            if (BookedRoom == null) return 0.0;
            return BookedRoom.PricePerNight * TotalNights;
        }

        public void DisplayGuest()
        {
            string roomDetails = RoomNumber == "Not Assigned" ? "Not Assigned" : RoomNumber;
            Console.WriteLine($"ID: {GuestId} | Name: {GuestName,-15} | Room: {roomDetails,-8} | Check-in: {CheckInDate} | Nights: {TotalNights}");
        }
    }
}
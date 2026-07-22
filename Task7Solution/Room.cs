

namespace Task7Solution
{
    public class Room
    {
        // Attributes
        public string RoomNumber { get; set; }
        public string RoomType { get; set; } // Single, Double, Suite
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        // Constructor
        public Room(string roomNumber, string roomType, double pricePerNight, bool isAvailable = true)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            PricePerNight = pricePerNight;
            IsAvailable = isAvailable;
        }

        // Methods
        public void DisplayRoom()
        {
            string status = IsAvailable ? "Available" : "Booked";
            Console.WriteLine($"Room: {RoomNumber} | Type: {RoomType,-8} | Price/Night: OMR {PricePerNight:F2} | Status: {status}");
        }
    }
}
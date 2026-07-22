using System;
using System.Collections.Generic;
using System.Linq;

namespace Task7Solution
{
    internal class Program
    {
        // Declare system lists
        static List<Room> rooms = new List<Room>();
        static List<Guest> guests = new List<Guest>();

        static void Main(string[] args)
        {
            // Pre-load rooms before menu loops[cite: 1]
            rooms.Add(new Room("101", "Single", 25.00));
            rooms.Add(new Room("102", "Single", 25.00));
            rooms.Add(new Room("201", "Double", 45.00));
            rooms.Add(new Room("202", "Double", 45.00));
            rooms.Add(new Room("301", "Suite", 90.00));
            rooms.Add(new Room("302", "Suite", 120.00));

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n==================================================");
                Console.WriteLine("       GRAND VISTA HOTEL MANAGEMENT SYSTEM        ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book a Room for a Guest");
                Console.WriteLine("4. View All Rooms");
                Console.WriteLine("5. View All Guests");
                Console.WriteLine("6. Search & Filter Rooms");
                Console.WriteLine("7. Guest & Booking Statistics");
                Console.WriteLine("8. Update Room Price");
                Console.WriteLine("9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine("0. Exit");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid selection. Please enter a number.");
                    continue;
                }

                Console.WriteLine();

                switch (choice)
                {
                    case 1: AddNewRoom(); break;
                    case 2: RegisterNewGuest(); break;
                    case 3: BookRoom(); break;
                    case 4: ViewAllRooms(); break;
                    case 5: ViewAllGuests(); break;
                    case 6: SearchFilterRooms(); break;
                    case 7: GuestBookingStatistics(); break;
                    case 8: UpdateRoomPrice(); break;
                    case 9: GuestLookupByName(); break;
                    case 10: RoomTypeBreakdownReport(); break;
                    case 11: CheckOutGuest(); break;
                    case 12: RemoveUnavailableRooms(); break;
                    case 13: ExtendGuestStay(); break;
                    case 14: HighestRevenueBooking(); break;
                    case 15: GuestPaginationViewer(); break;
                    case 0:
                        exit = true;
                        Console.WriteLine("Thank you for using Grand Vista Hotel Management System!");
                        break;
                    default:
                        Console.WriteLine("Option not implemented or invalid.");
                        break;
                }
            }
        }

        #region EASY CASES (01-05)

        static void AddNewRoom()
        {
            Console.WriteLine("--- Add New Room ---");
            Console.Write("Enter Room Number: ");
            string rNum = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(rNum)) return;

            if (rooms.Any(r => r.RoomNumber.Equals(rNum, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Error: Room number already exists.");
                return;
            }

            Console.Write("Enter Room Type (Single / Double / Suite): ");
            string type = Console.ReadLine()?.Trim();
            if (type != "Single" && type != "Double" && type != "Suite") return;

            Console.Write("Enter Price Per Night: ");
            if (!double.TryParse(Console.ReadLine(), out double price) || price <= 0) return;

            rooms.Add(new Room(rNum, type, price));
            Console.WriteLine($"\nSuccess! Room {rNum} added. Total rooms: {rooms.Count}");
        }

        static void RegisterNewGuest()
        {
            Console.WriteLine("--- Register New Guest ---");
            Console.Write("Enter Guest Name: ");
            string name = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(name)) return;

            Console.Write("Enter Check-in Date (DD-MM-YYYY): ");
            string checkIn = Console.ReadLine()?.Trim();

            Console.Write("Enter Number of Nights: ");
            if (!int.TryParse(Console.ReadLine(), out int nights) || nights <= 0) return;

            string gId = $"G{(guests.Count + 1):D3}";
            guests.Add(new Guest(gId, name, checkIn, nights));
            Console.WriteLine($"\nGuest registered successfully with ID: {gId}");
        }

        static void BookRoom()
        {
            Console.WriteLine("--- Book a Room ---");
            Console.Write("Enter Guest ID: ");
            string gId = Console.ReadLine()?.Trim();
            Console.Write("Enter Room Number: ");
            string rNum = Console.ReadLine()?.Trim();

            Guest guest = guests.FirstOrDefault(g => g.GuestId.Equals(gId, StringComparison.OrdinalIgnoreCase));
            Room room = rooms.FirstOrDefault(r => r.RoomNumber.Equals(rNum, StringComparison.OrdinalIgnoreCase));

            if (guest == null || room == null || !room.IsAvailable)
            {
                Console.WriteLine("Error: Room unavailable or identity records mismatch.");
                return;
            }

            guest.AssignRoom(room);
            room.IsAvailable = false;
            Console.WriteLine($"\nBooking Confirmed! Total Bill: OMR {guest.CalculateTotalCost():F2}");
        }

        static void ViewAllRooms()
        {
            Console.WriteLine("--- View All Rooms ---");
            if (!rooms.Any()) return;
            rooms.OrderBy(r => r.RoomNumber).ToList().ForEach(r => r.DisplayRoom());
        }

        static void ViewAllGuests()
        {
            Console.WriteLine("--- View All Guests ---");
            if (!guests.Any()) return;
            guests.OrderBy(g => g.GuestName).ToList().ForEach(g => g.DisplayGuest());
        }

        #endregion

        #region MEDIUM CASES (06-10)

        static void SearchFilterRooms()
        {
            Console.WriteLine("--- Search & Filter Rooms ---");
            Console.WriteLine("1. Show all available rooms\n2. Filter by room type\n3. Filter by max price\n4. Price statistics");
            Console.Write("Choice: ");
            if (!int.TryParse(Console.ReadLine(), out int options)) return;

            if (options == 1) rooms.Where(r => r.IsAvailable).OrderBy(r => r.PricePerNight).ToList().ForEach(r => r.DisplayRoom());
            else if (options == 2)
            {
                Console.Write("Type: ");
                string t = Console.ReadLine();
                rooms.Where(r => r.RoomType.Equals(t, StringComparison.OrdinalIgnoreCase)).ToList().ForEach(r => r.DisplayRoom());
            }
            else if (options == 3)
            {
                Console.Write("Max Price: ");
                if (double.TryParse(Console.ReadLine(), out double p))
                    rooms.Where(r => r.IsAvailable && r.PricePerNight <= p).ToList().ForEach(r => r.DisplayRoom());
            }
            else if (options == 4 && rooms.Any())
            {
                Console.WriteLine($"Average: OMR {rooms.Average(r => r.PricePerNight):F2} | Min: OMR {rooms.Min(r => r.PricePerNight):F2} | Max: OMR {rooms.Max(r => r.PricePerNight):F2}");
            }
        }

        static void GuestBookingStatistics()
        {
            Console.WriteLine($"Total Guests: {guests.Count} | Active Bookings: {guests.Count(g => g.RoomNumber != "Not Assigned")}");
            var active = guests.Where(g => g.RoomNumber != "Not Assigned").ToList();
            if (!active.Any()) return;

            Console.WriteLine($"Avg Nights: {active.Average(g => g.TotalNights):F1}");
            Console.WriteLine("\n--- Top Spenders ---");
            guests.OrderByDescending(g => g.CalculateTotalCost()).Take(3).ToList().ForEach(g => Console.WriteLine($"{g.GuestName}: OMR {g.CalculateTotalCost():F2}"));
        }

        static void UpdateRoomPrice()
        {
            Console.Write("Room Number: ");
            string rNum = Console.ReadLine();
            Room room = rooms.FirstOrDefault(r => r.RoomNumber == rNum);
            if (room == null) return;

            Console.Write("New Price: ");
            if (double.TryParse(Console.ReadLine(), out double np) && np > 0) room.PricePerNight = np;
        }

        static void GuestLookupByName()
        {
            Console.Write("Search Name: ");
            string q = Console.ReadLine();
            guests.Where(g => g.GuestName.Contains(q, StringComparison.OrdinalIgnoreCase)).ToList().ForEach(g => g.DisplayGuest());
        }

        static void RoomTypeBreakdownReport()
        {
            string[] types = { "Single", "Double", "Suite" };
            foreach (var t in types)
            {
                var match = rooms.Where(r => r.RoomType.Equals(t, StringComparison.OrdinalIgnoreCase)).ToList();
                Console.WriteLine($"Type: {t} | Count: {match.Count} | Avg Price: {(match.Any() ? match.Average(r => r.PricePerNight).ToString("F2") : "N/A")}");
            }
        }

        #endregion

        #region ADVANCED CASES (11-15)

        static void CheckOutGuest()
        {
            Console.Write("Guest ID: ");
            string id = Console.ReadLine();
            Guest g = guests.FirstOrDefault(x => x.GuestId.Equals(id, StringComparison.OrdinalIgnoreCase));
            if (g == null || g.RoomNumber == "Not Assigned") return;

            Room r = rooms.FirstOrDefault(x => x.RoomNumber == g.RoomNumber);
            if (r != null) r.IsAvailable = true;

            guests.Remove(g);
            Console.WriteLine("Checkout processed successfully.");
        }

        static void RemoveUnavailableRooms()
        {
            var targets = rooms.Where(r => !r.IsAvailable && !guests.Any(g => g.RoomNumber == r.RoomNumber)).ToList();
            if (!targets.Any()) return;

            rooms.RemoveAll(r => !r.IsAvailable && !guests.Any(g => g.RoomNumber == r.RoomNumber));
            Console.WriteLine("Decommission complete.");
        }

        static void ExtendGuestStay()
        {
            Console.Write("Guest ID: ");
            string id = Console.ReadLine();
            Guest g = guests.FirstOrDefault(x => x.GuestId.Equals(id, StringComparison.OrdinalIgnoreCase));
            if (g == null || g.RoomNumber == "Not Assigned") return;

            Console.Write("Additional Nights: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0) g.TotalNights += n;
        }

        static void HighestRevenueBooking()
        {
            var top = guests.Where(g => g.RoomNumber != "Not Assigned")
                            .OrderByDescending(g => g.CalculateTotalCost())
                            .FirstOrDefault();
            if (top != null) Console.WriteLine($"Highest Earner: {top.GuestName} - OMR {top.CalculateTotalCost():F2}");
        }

        static void GuestPaginationViewer()
        {
            if (!guests.Any()) return;
            int size = 3;
            Console.Write("Enter Page Number: ");
            if (int.TryParse(Console.ReadLine(), out int p) && p > 0)
            {
                guests.Skip((p - 1) * size).Take(size).ToList().ForEach(g => g.DisplayGuest());
            }
        }

        #endregion
    }
}
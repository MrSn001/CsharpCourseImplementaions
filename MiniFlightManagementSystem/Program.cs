namespace MiniFlightManagementSystem
{
    internal class Program
    {

        //Collection Declaration
        static List<string> passengerNames = new List<string>();
        static List<string> ticketNumbers = new List<string>();
        static string[] flightNumbers = new string[6];
        static List<DateTime> availableDates = new List<DateTime>();
        static Dictionary<string,DateTime> bookingRecord = new Dictionary<string, DateTime>();
        static Queue<string> checkedInQueue = new Queue<string>();
        static Stack<string> boardingStack = new Stack<string>();
        static List<string> cancelledTickets = new List<string>();
        static Dictionary<string,string> passengerSeatMap = new Dictionary<string,string>();
        static Queue<string> waitlistQueue = new Queue<string>();


        // Variables Declaration
        static int choice;
        static bool flag = true;

        static void Main(string[] args)
        {
            while (flag) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("""
                    ========================================
                    SKY WINGS FLIGHT MANAGEMENT SYSTEM
                    ========================================
                    """);

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("""
                    1. Register New Passenger
                    2. View All Passengers
                    3. Book a Flight Ticket
                    4. View Booking Details   
                    """);

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("""
                    5. Update a Booking
                    6. Cancel a Ticket
                    7. Passenger Check-In
                    8. Board Passengers (Boarding Stack)
                    """);

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("""
                    9. Generate Flight Manifest
                    10. Manage Waitlist & Seat Assignment
                    """);

                Console.ResetColor();
                Console.WriteLine("0. Exit");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("""
                    ========================================

                    Enter your choice: 
                    """);
                choice = Convert.ToInt32(Console.ReadLine());

                Console.ResetColor();
                switch (choice) 
                {
                    //Task 1 - Register New Passenger
                    case 1:
                        break;
                    //Task 2 - View All Passengers
                    case 2: 
                        break;
                    //Task 3 - Book a Flight Ticket
                    case 3:
                        break;
                    //Task 4 - View Booking Details
                    case 4:
                        break;
                    //Task 5 - Update a Booking 
                    case 5:
                        break;
                    //Task 6 - Cancel a Ticket
                    case 6:
                        break;
                    //Task 7 - Passenger Check-In 
                    case 7:
                        break;
                    //Task 8 - Board Passengers (Boarding Stack) 
                    case 8:
                        break;
                    //Task 9 - Generate Flight Manifest 
                    case 9:
                        break;
                    //Task 10 - Manage Waitlist & Seat Assignment
                    case 10: 
                        break;
                    //Exit
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Thank you for using our system");
                        Console.ResetColor();
                        flag = false;
                        break;

                    default:
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("");
                        Console.WriteLine("Invalid Option!!");
                        Console.WriteLine("");
                        Console.ResetColor();
                        break;
                }

                Console.WriteLine("Please Enter any key to continue.... ");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

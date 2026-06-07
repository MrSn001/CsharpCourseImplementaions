namespace MiniFlightManagementSystem
{
    internal class Program
    {

        //Collection Declaration
        static List<string> passengerNames = new List<string>() {"Shaheen Al-Amri", "Shakir Al-Amri", "Shihab Al-Amri", "Said Mohammed", "Rashid Ali"};
        static List<string> ticketNumbers = new List<string>() {"TKT-001", "TKT-002", "TKT-003", "TKT-004", "TKT-005"};
        static string[] flightNumbers = new string[6] { "OA101", "OA102", "OA103", "OA104", "OA105","OA106"};
        static List<DateOnly> availableDates = [new DateOnly(2026,06,10), new DateOnly(2026, 06, 15), new DateOnly(2026, 06, 16), new DateOnly(2026, 06, 20)];
        static Dictionary<string,DateTime> bookingRecord = new Dictionary<string, DateTime>();
        static Queue<string> checkedInQueue = new Queue<string>();
        static Stack<string> boardingStack = new Stack<string>();
        static List<string> cancelledTickets = new List<string>();
        static Dictionary<string,string> passengerSeatMap = new Dictionary<string,string>();
        static Queue<string> waitlistQueue = new Queue<string>();


        //Variables Declaration
        static int choice;
        static bool flag = true;
        static string passengerName;
        static int nextNum;
        static string ticketID;
        static bool validationFlag = false;
        static string status = "not signed";
        //Method Declaration
        static void MainMenu()
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
            Console.ResetColor();
            choice = Convert.ToInt32(Console.ReadLine());
        }

        //Case 1 Methods
        static void AddingPassengerName(ref bool validationFlag)
        {
            passengerName = Console.ReadLine();
            if(passengerName == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The name can't be empty!!");
                validationFlag = true;
                Console.ResetColor();
                return;
            }
            foreach (string name in passengerNames) {
                if (passengerName.ToLower() == name.ToLower())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"There is already a passenger with the name {passengerName} Registered!!");
                    validationFlag = true;
                    Console.ResetColor();
                    return;
                }
            }
            passengerNames.Add(passengerName);

        }
        static void AutoGenerateTicketID()
        {
            nextNum = ticketNumbers.Count + 1;
            ticketID = $"TKT-{nextNum:D3}";
            ticketNumbers.Add(ticketID);
        }
        //Case 2 Methods:
        static void CheckPassengerAvailability()
        {
            if(passengerNames.Count == 0)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("There is no Passenger Registered!!");
                Console.ResetColor();
            }
        }
        static void ViewAllPassengers()
        {
            Console.WriteLine($"{"No.",-4} | {"Passenger Name",-20} | {"Ticket ID",-9} | Status");
            for (int i = 0; i < passengerNames.Count; i++)
            {
                string status = "Active";
                if (cancelledTickets.Contains(ticketNumbers[i]))
                {
                    status = "CANCELLED";
                }
                Console.WriteLine($"{(i + 1), -4} | {passengerNames[i], -20} | {ticketNumbers[i],-9} | {status}");
            }

            Console.WriteLine($"There is {passengerNames.Count} passengers registered");
        }
        static void Main(string[] args)
        {
            while (flag) 
            {
                MainMenu();

                switch (choice) 
                {
                    //Task 1 - Register New Passenger
                    case 1:
                        Console.Write("Please enter the full passenger name: ");
                        AddingPassengerName(ref validationFlag);
                        if (validationFlag)
                        {
                            break;
                        }
                        AutoGenerateTicketID();
                        Console.ForegroundColor= ConsoleColor.Green;
                        Console.WriteLine($"Passenger {passengerName} Added Successfully, Ticket ID: {ticketID}!!");
                        Console.ResetColor();
                        break;
                    //Task 2 - View All Passengers
                    case 2:
                        CheckPassengerAvailability();
                        ViewAllPassengers();
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

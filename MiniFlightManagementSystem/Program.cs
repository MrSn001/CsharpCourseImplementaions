using System.Net.Sockets;

namespace MiniFlightManagementSystem
{
    internal class Program
    {

        //Collection Declaration
        static List<string> passengerNames = new List<string>() { "Shaheen Al-Amri", "Shakir Al-Amri", "Shihab Al-Amri", "Said Mohammed", "Rashid Ali" };
        static List<string> ticketNumbers = new List<string>() {"TKT-001", "TKT-002", "TKT-003", "TKT-004", "TKT-005"};
        static string[] flightNumbers = new string[6] { "OA101", "OA102", "OA103", "OA104", "OA105","OA106"};
        static List<DateOnly> availableDates = [new DateOnly(2026,06,10), new DateOnly(2026, 06, 15), new DateOnly(2026, 06, 16), new DateOnly(2026, 06, 20)];
        static Dictionary<string,string> bookingRecord = new Dictionary<string, string>();
        static Queue<string> checkedInQueue = new Queue<string>();
        static Stack<string> boardingStack = new Stack<string>();
        static List<string> cancelledTickets = new List<string>() { "TKT-005" };
        static Dictionary<string,string> passengerSeatMap = new Dictionary<string,string>();
        static Queue<string> waitlistQueue = new Queue<string>();


        //Variables Declaration
        static int choice;
        static bool flag = true;
        static string passengerName;
        static int nextNum;
        static string ticketID;
        static bool validationFlag = false;
        static string status;
        static bool check = false;
        static string flight;
        static DateOnly date;

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
                status = "Active";
                if (cancelledTickets.Contains(ticketNumbers[i]))
                {
                    status = "CANCELLED";
                }
                Console.WriteLine($"{(i + 1), -4} | {passengerNames[i], -20} | {ticketNumbers[i],-9} | {status}");
            }

            Console.WriteLine($"There is {passengerNames.Count} passengers registered");
        }
        //Case 3 Methods:
        static void CheckTicketAvailability(ref bool validationFlag)
        {
            Console.Write("Please Enter The Ticket Number: ");
            ticketID = Console.ReadLine();
            foreach (string ticket in ticketNumbers)
            {
                if (ticketID == ticket)
                {
                    check = true; 
                    break;
                }
                check = false;
            }
            if (!check) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Ticket Number!!");
                Console.ResetColor();
                validationFlag = true;

            }
        }
        static void CheckTicketFromBookingRecord(ref bool validationFlag)
        {
            if (bookingRecord.Keys.Contains(ticketID))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This ticket ID Already has a booking!!");
                Console.ResetColor();
                validationFlag = true;
                return;
            }
            validationFlag = false;
        }
        static void DisplayAndChooseFlightNumber()
        {
            for (int i = 0; i < flightNumbers.Length; i++)
            {
                Console.WriteLine($"Flight: {(i + 1)}  | Flight Number: {flightNumbers[i]}");
            }
            Console.Write("Enter a number from 1 to 6: " );
            choice = Convert.ToInt32( Console.ReadLine() );
            if( choice <= 0 || choice > flightNumbers.Length)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("You have to choose one of the above flights");
                validationFlag = true;
                Console.ResetColor();
                return;
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("You have select " + flightNumbers[choice - 1] + "!!");
                flight = flightNumbers[choice - 1];
                Console.ResetColor();
            }

        }
        static void DisplayAndChooseDate()
        {
            for (int i = 0; i < availableDates.Count; i++)
            {
                Console.WriteLine($"{(i + 1)}. {availableDates[i].ToString("dd-MMM-yyyy")}");
            }

            Console.Write($"Enter a number from 1 to {availableDates.Count}: ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice <= 0 || choice > availableDates.Count)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have to choose one of the above dates");
                validationFlag = true;
                Console.ResetColor();
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You have select " + availableDates[choice - 1].ToString("dd-MMM-yyyy") + "!!");
                date = availableDates[choice - 1];
                Console.ResetColor();
            }
        }

        //Case 4 Methods: 
        static void CheckTicketCancellation(string ticket)
        {
            foreach (string t in cancelledTickets)
            {
                if (t.Contains(ticket))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This ticket has been cancelled.");
                    Console.ResetColor();
                    validationFlag = true;
                    return;
                }

            }
        }
        static void CheckBooking(string ticket)
        {
            if (!bookingRecord.Keys.Contains(ticket))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No booking found for this ticket.");
                Console.ResetColor();
                validationFlag = true;
                return;
            }
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
                            validationFlag = false;
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
                        CheckTicketAvailability(ref validationFlag);
                        if (validationFlag)
                        {
                            validationFlag = false;
                            break;
                        }
                        CheckTicketFromBookingRecord(ref validationFlag);
                        if (validationFlag)
                        {
                            validationFlag = false;
                            break;
                        }
                        DisplayAndChooseFlightNumber();
                        if (validationFlag)
                        {
                            validationFlag = false;
                            break;
                        }
                        DisplayAndChooseDate();
                        if (validationFlag)
                        {
                            validationFlag = false;
                            break;
                        }

                        bookingRecord.Add(ticketID,flight + "|" + date.ToString("dd-MMM-yyyy"));
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Ticket ID : {ticketID} | Passenger Name {passengerNames[ticketNumbers.IndexOf(ticketID)]} | Flight Number: {flight} | Date: {date.ToString("dd-MMM-yyyy")}" );
                        Console.ResetColor();
                        break;
                    //Task 4 - View Booking Details
                    case 4:
                        CheckTicketAvailability(ref validationFlag);
                        if (validationFlag)
                        {
                            validationFlag = false;
                            break;
                        }
                        passengerName = passengerNames[ticketNumbers.IndexOf(ticketID)];
                        CheckTicketCancellation(ticketID);
                        if (validationFlag)
                        {
                            validationFlag = false;
                            break;
                        }
                        CheckBooking(ticketID);
                        if (validationFlag)
                        {
                            validationFlag = false;
                            break;
                        }
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Ticket ID : {ticketID} | Passenger Name {passengerName} | Flight Number: {bookingRecord[ticketID].Split('|')[0]} | Date: {bookingRecord[ticketID].Split('|')[1]}");
                        Console.ResetColor();

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

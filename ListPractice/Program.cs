namespace ListPractice
{
    internal class Program
    {
        //Variables Decleration
        static int index;
        static double priceSearch;
        static int quantitySum;
        static int quantitiySearch;
        static int choice;
        static bool flag = true;
        static int lastIndex;
        static double revenueSum;
        static int seatSearch;
        static double middleIndex1;
        static double middleIndex2;
        static double median;
        static int counter;
        static int severitySearch;
        static bool checkItem;
        static string itemNameSearch;
        static bool checkGuest;
        static string guestNameSearch;

        //List Decleration
        static List<double> temperatures = new List<double>();
        static List<int> scores = new List<int>();
        static List<double> prices = new List<double>();
        static List<int> finishTimes = new List<int>();
        static List<int> grades = new List<int>();
        static List<int> quantities = new List<int>();
        static List<int> copies = new List<int>();
        static List<double> revenue = new List<double>();
        static List<double> sortedCopy = new List<double>();
        static List<int> seats = new List<int>();
        static List<int> reverse = new List<int>();
        static List<int> severity = new List<int>();
        static List<int> sortedSeverity = new List<int>();
        static List<string> menuItem = new List<string>();
        static List<string> checkInQueue = new List<string>();

        static void MainMenu()
        {
            Console.WriteLine("""
                1. Temperature Log
                2. Student Score Board
                3. Product Price Finder
                4. Race Finish Times
                5. Classroom grade Report
                6. Warehouse Inventory Check
                7. Library Book Shelf Scanner
                8. Sales Performance Analyzer
                9. Flight Seat Allocation Display
                10. Hospital Patient Priority Queue
                11. Room Service Menu
                12. Guest Check-In Queue
                13. Housekeeping Floor Assignment 
                14. Hotel Booking Conflict Resolver
                15. Exit

                """);
        }

        //Task 1
        static void TemperatureLog()
        {
            temperatures.AddRange(45.6, 46.3, 48.9, 48.4, 50.1, 51.2, 47.5);
            //temperatures = [45.6, 46.3, 48.9, 48.4, 50.1, 51.2, 47.5];
            for (int i = 0; i < temperatures.Count; i++)
            {
                Console.WriteLine("Day " + (i + 1) + ": " + temperatures[i] + " C");
            }

            Console.WriteLine("There is total of " + temperatures.Count + " temperature logs have been recorded.");
        }

        //Task 2
        static void QuizScore()
        {
            scores.AddRange([40, 50, 45, 30, 43, 39]);
            foreach (int score in scores)
            {
                Console.WriteLine("Quiz score: " + score);
            }
            Console.WriteLine("The Reveresed Score Print: ");
            scores.Reverse();
            for (int i = 0; i < scores.Count; i++)
            {
                Console.WriteLine("Score number " + i + " is: " + scores[i]);
            }

        }

        //Task 3
        static void ProductPriceFinder()
        {
            prices.AddRange([5.4, 19.3, 30.2, 24.0, 4.99]);

            for (int i = 0; i < prices.Count; i++)
            {
                Console.WriteLine("Product " + (i + 1) + ": " + prices[i]);
            }
            Console.WriteLine("Please enter the value you want to find its index: ");
            priceSearch = Convert.ToDouble(Console.ReadLine());
            index = prices.IndexOf(priceSearch);
            if (index == -1)
            {
                Console.WriteLine("Product price not found in the array.");
            }
            else
            {
                Console.WriteLine("Product price found at index: " + index);
            }
        }

        //Task 4
        static void RaceFinishTimes()
        {
            finishTimes.AddRange([23, 35, 33, 32, 27, 31, 24, 20]);
            foreach (int finishtime in finishTimes)
            {
                Console.WriteLine("Finish time: " + finishtime);
            }
            finishTimes.Sort();
            Console.WriteLine("============= Sorted finish time =============");
            for (int i = 0; i < finishTimes.Count; i++)
            {
                Console.WriteLine((i + 1) + " Place: " + finishTimes[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Number of the participants: " + finishTimes.Count);
        }

        //Task 5
        static void ClassroomGradeReport()
        {
            grades.AddRange([73, 93, 65, 50, 90, 76, 99, 100, 68, 98]);
            grades.Sort();
            grades.Reverse();
            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine("Rank " + (i + 1) + ": " + grades[i]);
            }
        }

        //Task 6
        static void WarehouseInventoryCheck()
        {
            quantities = [3, 10, 12, 29, 4, 25, 14, 13];

            for (int i = 0; i < quantities.Count; i++)
            {
                Console.WriteLine("Product " + (i + 1) + " quantity: " + quantities[i]);
            }

            quantitySum = 0;
            for (int i = 0; i < quantities.Count; i++)
            {
                quantitySum += quantities[i];
            }

            Console.WriteLine();
            Console.WriteLine("The total stock for all the items are: " + quantitySum);
            Console.WriteLine("The average stock: " + quantitySum / quantities.Count);
            Console.WriteLine();

            Console.WriteLine("Please enter the Product quantity you want to find its index: ");
            quantitiySearch = Convert.ToInt32(Console.ReadLine());
            index = quantities.IndexOf( quantitiySearch);
            if (index == -1)
            {
                Console.WriteLine("Product quantity not found in the array.");
            }
            else
            {
                Console.WriteLine("Product quantity found at index: " + index);
            }
        }

        //Task 7
        static void LibraryBookShelfScanner()
        {
            copies = [0, 3, 5, 8, 0, 10, 3, 4, 1];

            foreach (int copy in copies)
            {
                Console.WriteLine("Number of copies: " + copy);
            }

            copies.Sort();
            lastIndex = copies.Count - 1;
            Console.WriteLine("");
            Console.WriteLine("The book with the most copies: " + copies[lastIndex]);

            for (int i = 0; i < copies.Count; i++)
            {
                if (copies[i] == 0)
                {
                    Console.WriteLine("Found a 0 Number of copies in Index: " + i);

                }
            }
        }

        //Task 8 
        static void SalesPerformanceAnalyzer()
        {
            revenue = [4030.400, 7203.900, 5390.500, 4600.300, 3500.400, 3248.800, 3700.700, 6390.700, 5000, 3900.300, 8000, 6800.300];
            for (int i = 0; i < revenue.Count; i++)
            {
                Console.WriteLine("Month " + (i + 1) + ": " + revenue[i]);
            }

            for (int i = 0; i < revenue.Count; i++)
            {
                sortedCopy.Add(revenue[i]);
            }

            sortedCopy.Sort();
            Console.WriteLine("=========== The sorted Copy ===========");

            for (int i = 0; i < sortedCopy.Count; i++)
            {
                Console.WriteLine("revenue " + (i + 1) + ": " + sortedCopy[i]);
            }

            lastIndex = sortedCopy.Count - 1;
            Console.WriteLine("The best Revenue: " + sortedCopy[lastIndex]);
            Console.WriteLine("The worst Revenue: " + sortedCopy[0]);
            revenueSum = 0;
            for (int i = 1; i < sortedCopy.Count; i++)
            {
                revenueSum += sortedCopy[i];
            }
            Console.WriteLine("The Average: " + revenueSum / sortedCopy.Count);

            sortedCopy.Clear();
        }

        //Task 9 
        static void FlightSeatAllocationDisplay()
        {
            seats = [7, 3, 4, 6, 9, 44, 2, 43, 5, 10, 22, 49, 30, 21, 99];
            foreach (int seat in seats)
            {
                Console.WriteLine("Seat number: " + seat);
            }
            Console.WriteLine("");
            seats.Sort();

            Console.WriteLine("Please enter the seat number you want to find its index: ");
            seatSearch = Convert.ToInt32(Console.ReadLine());
            index = seats.IndexOf(seatSearch);
            if (index == -1)
            {
                Console.WriteLine("Seat not found in the array.");
            }
            else
            {
                Console.WriteLine("Seat found at index: " + index);
            }

            Console.WriteLine("");
            
            for (int i = 0; i < seats.Count; i++)
            {
                reverse.Add(seats[i]);
            }
            reverse.Reverse();

            for (int i = 0; i < reverse.Count; i++)
            {
                Console.WriteLine("Sorted: " + seats[i] + " Reversed: " + reverse[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Total number of seats: " + reverse.Count);

            reverse.Clear();
        }

        //Task 10
        static void HospitalPatientPriorityQueue()
        {
            severity = [2, 3, 2, 4, 5, 6, 6, 9, 2, 1, 4, 5, 7, 8, 9, 8, 5, 10, 10, 2];
            

            for (int i = 0; i < severity.Count; i++)
            {
                sortedSeverity.Add(severity[i]);
            }

            sortedSeverity.Sort();
            sortedSeverity.Reverse();

            for (int i = 0; i < sortedSeverity.Count; i++)
            {
                Console.WriteLine("Rank " + (i + 1) + ": " + sortedSeverity[i]);
            }
            sortedSeverity.Reverse();
            middleIndex1 = sortedSeverity.Count / 2;
            middleIndex2 = middleIndex1 + 1;
            median = (middleIndex1 + middleIndex2) / 2;
            Console.WriteLine("");
            Console.WriteLine("The median = " + median);

            counter = 0;
            for (int i = 0; i < severity.Count; i++)
            {
                if (sortedSeverity[i] <= 3)
                {
                    counter++;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Total of critical cases: " + counter);

            Console.WriteLine("");
            Console.WriteLine("Please enter the severity you want to find its index: ");
            severitySearch = Convert.ToInt32(Console.ReadLine());
            index = sortedSeverity.IndexOf(severitySearch);
            if (index == -1)
            {
                Console.WriteLine("severity not found in the array.");
            }
            else
            {
                Console.WriteLine("severity found at index: " + index);
            }

            sortedSeverity.Clear();
        }

        //Task 11
        static void RoomServiceMenu()
        {
            menuItem = ["Rice With Chicken", "Rice With Meat", "Chicken Pizza", "Paparoni Pizza"];
            for (int i = 0; i < menuItem.Count; i++)
            {
                Console.WriteLine("Meal " + (i + 1) + ": " + menuItem[i]);
            }
            menuItem.AddRange(["BBQ Chicken", "Chicken Shawarma Plate"]);
            Console.WriteLine("");
            Console.WriteLine("----- Updated Menu -----");
            for (int i = 0; i < menuItem.Count; i++)
            {
                Console.WriteLine("Meal " + (i + 1) + ": " + menuItem[i]);
            }

            menuItem.Remove("Chicken Shawarma Plate");
            Console.WriteLine("");
            Console.WriteLine("----- Updated Menu Removed 1 Meal -----");
            for (int i = 0; i < menuItem.Count; i++)
            {
                Console.WriteLine("Meal " + (i + 1) + ": " + menuItem[i]);
            }

            Console.WriteLine("Please Enter the item name you want to search for: ");
            itemNameSearch = Console.ReadLine();
            checkItem = menuItem.Contains(itemNameSearch);
            if (checkItem) 
            { 
                Console.WriteLine("The " + itemNameSearch + " Was found on index: " + menuItem.IndexOf(itemNameSearch));
            }else
            {
                Console.WriteLine("The " + itemNameSearch + " Was Not found. ");
            }

            Console.WriteLine("");
            Console.WriteLine("The total number of the available meals: " + menuItem.Count);
        }

        //Task 12
        static void GuestCheckInQueue()
        {
            checkInQueue = ["Shaheen", "Shakir", "Shihab", "Ahmed", "Mohammed"];
            for (int i = 0; i < checkInQueue.Count; i++)
            {
                Console.WriteLine("Guest " + (i + 1) + ": " + checkInQueue[i]);
            }
            checkInQueue.RemoveAt(0);

            Console.WriteLine("");
            Console.WriteLine("---- Removed one Guest ----");
            for (int i = 0; i < checkInQueue.Count; i++)
            {
                Console.WriteLine("Guest " + (i + 1) + ": " + checkInQueue[i]);
            }

            checkInQueue.RemoveAt(0);

            Console.WriteLine("");
            Console.WriteLine("---- Removed the Next Guest ----");
            for (int i = 0; i < checkInQueue.Count; i++)
            {
                Console.WriteLine("Guest " + (i + 1) + ": " + checkInQueue[i]);
            }

            checkInQueue.AddRange(["Said", "Ali", "Sara"]);

            Console.WriteLine("");
            Console.WriteLine("---- Added New Guests ----");

            for (int i = 0; i < checkInQueue.Count; i++)
            {
                Console.WriteLine("Guest " + (i + 1) + ": " + checkInQueue[i]);
            }


            Console.WriteLine("Please Enter the guest name you want to search for: ");
            guestNameSearch = Console.ReadLine();
            checkGuest = checkInQueue.Contains(guestNameSearch);
            if (checkGuest)
            {
                Console.WriteLine("The " + guestNameSearch + " your queue number is: " + (checkInQueue.IndexOf(guestNameSearch) + 1));
            }
            else
            {
                Console.WriteLine("The " + guestNameSearch + " Was Not found. ");
            }

            Console.WriteLine("");
            Console.WriteLine("The total number of guests currently in the queue: " + checkInQueue.Count);
        }

        //Task 13
        static void HousekeepingFloorAssignment()
        {

        }

        //Task 14
        static void HotelBookingConflictResolver()
        {

        }
        static void Main(string[] args)
        {

            {
                while (flag)
                {
                    MainMenu();
                    Console.WriteLine("Please Enter your Choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        //Temperature Log
                        case 1:
                            TemperatureLog();
                            break;

                        //Student Score Board
                        case 2:
                            QuizScore();
                            break;

                        //Product Price Finder 
                        case 3:
                            ProductPriceFinder();
                            break;

                        //Race Finish Times
                        case 4:
                            RaceFinishTimes();
                            break;

                        //Classroom Grade Report
                        case 5:
                            ClassroomGradeReport();
                            break;

                        //Warehouse Inventory Check
                        case 6:
                            WarehouseInventoryCheck();
                            break;

                        //Library Book Shelf Scanner
                        case 7:
                            LibraryBookShelfScanner();
                            break;

                        //Sales Performance Analyzer
                        case 8:
                            SalesPerformanceAnalyzer();
                            break;

                        //Flight Seat Allocation Display
                        case 9:
                            FlightSeatAllocationDisplay();
                            break;

                        //Hospital Patient Priority Queue
                        case 10:
                            HospitalPatientPriorityQueue();
                            break;

                        //Room Service Menu
                        case 11:
                            RoomServiceMenu();
                            break;

                        //Guest Check-In Queue
                        case 12:
                            GuestCheckInQueue();
                            break;

                        //Housekeeping Floor Assignment 
                        case 13:
                            HousekeepingFloorAssignment();
                            break;

                        //Hotel Booking Conflict Resolver
                        case 14:
                            HotelBookingConflictResolver();
                            break;

                        //Stop the system
                        case 15:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Option Please Enter New Option");
                            break;
                    }

                    Console.WriteLine("Please Enter any key to continue....");
                    Console.ReadKey();
                    Console.Clear();

                }
            }
        }
    }
}

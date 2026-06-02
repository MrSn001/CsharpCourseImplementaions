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
                11. Exit

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
            
        }

        //Task 3
        static void ProductPriceFinder()
        {
           
        }

        //Task 4
        static void RaceFinishTimes()
        {
           
        }

        //Task 5
        static void ClassroomGradeReport()
        {
           
        }

        //Task 6
        static void WarehouseInventoryCheck()
        {
           
        }

        //Task 7
        static void LibraryBookShelfScanner()
        {
           
        }

        //Task 8 
        static void SalesPerformanceAnalyzer()
        {
           

        }

        //Task 9 
        static void FlightSeatAllocationDisplay()
        {
            
        }

        //Task 10
        static void HospitalPatientPriorityQueue()
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

                        //Stop the system
                        case 11:
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

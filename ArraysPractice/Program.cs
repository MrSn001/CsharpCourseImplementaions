using System.Diagnostics;

namespace ArraysPractice
{
    internal class Program
    {
        static int choice;
        static bool flag = true;
        static double[] temperatureLogs;
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
        static void TemperatureLog()
        {
            temperatureLogs = [45.6,46.3,48.9,48.4,50.1,51.2,47.5];
            for (int i = 0; i < temperatureLogs.Length; i++)
            { 
                Console.WriteLine("Day " + (i + 1) + ": " + temperatureLogs[i] + " C" );
            }

            Console.WriteLine("There is total of " + temperatureLogs.Length + " temperature logs have been recorded.");
        }

        static void Main(string[] args)
        {
            while (flag) {
                MainMenu();
                Console.WriteLine("Please Enter your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice){
                    //Temperature Log
                    case 1:
                        TemperatureLog();
                        break;

                    //Student Score Board
                    case 2:
                        break;

                    //Product Price Finder 
                    case 3:
                        break;

                    //Race Finish Times
                    case 4:
                        break;

                    //Classroom Grade Report
                    case 5:
                        break;
                    //Warehouse Inventory Check
                    case 6:
                        break;

                    //Library Book Shelf Scanner
                    case 7:
                        break;

                    //Sales Performance Analyzer
                    case 8:
                        break;

                    //Flight Seat Allocation Display
                    case 9:
                        break;

                    //Hospital Patient Priority Queue
                    case 10:
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

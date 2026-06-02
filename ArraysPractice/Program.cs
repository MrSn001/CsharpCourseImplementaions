using System.Diagnostics;

namespace ArraysPractice
{
    internal class Program
    {
        static int choice;
        static bool flag = true;
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

        static void Main(string[] args)
        {
            while (flag) {
                MainMenu();
                Console.WriteLine("Please Enter your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice){
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
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

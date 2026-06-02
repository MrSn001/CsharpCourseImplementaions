using System.Diagnostics;

namespace ArraysPractice
{
    internal class Program
    {
        static int index;
        static double priceSearch;
        static int choice;
        static bool flag = true;
        static double[] temperatures;
        static int[] scores;
        static double[] prices;
        static int[] finishTimes;


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
            temperatures = [45.6,46.3,48.9,48.4,50.1,51.2,47.5];
            for (int i = 0; i < temperatures.Length; i++)
            { 
                Console.WriteLine("Day " + (i + 1) + ": " + temperatures[i] + " C" );
            }

            Console.WriteLine("There is total of " + temperatures.Length + " temperature logs have been recorded.");
        }

        static void QuizScore()
        {
            scores = [40, 50, 45, 30, 43, 39];
            foreach (int score in scores)
            {
                Console.WriteLine("Quiz score: " + score);
            }
            Console.WriteLine("The Reveresed Score Print: ");
            Array.Reverse(scores);
            for (int i = 0; i < scores.Length; i++) 
            {
                Console.WriteLine("Score number " + i + " is: " + scores[i]);
            }
        }

        static void ProductPriceFinder()
        {
            prices = [5.4, 19.3, 30.2, 24.0, 4.99];

            for (int i = 0; i < prices.Length; i++) 
            { 
                Console.WriteLine("Product " + (i + 1) + ": " + prices[i]);
            }
            Console.WriteLine("Please enter the value you want to find its index: ");
            priceSearch = Convert.ToDouble(Console.ReadLine());
            index = Array.IndexOf(prices, priceSearch);
            if (index == -1)
            {
                Console.WriteLine("Product price not found in the array.");
            }
            else
            {
                Console.WriteLine("Product price found at index: " + index);
            }
        }

        static void RaceFinishTimes()
        {
            finishTimes = [23, 35, 33, 32, 27, 31, 24, 20];
            foreach(int finishtime in finishTimes)
            {
                Console.WriteLine("Finish time: " + finishtime);
            }
            Array.Sort(finishTimes);
            Console.WriteLine("============= Sorted finish time =============");
            for (int i = 0; i < finishTimes.Length; i++)
            {
                Console.WriteLine((i + 1) + " Place: " + finishTimes[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Number of the participants: " + finishTimes.Length);
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

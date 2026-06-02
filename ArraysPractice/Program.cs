using System.Diagnostics;

namespace ArraysPractice
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

        //Arrays Decleration
        static double[] temperatures;
        static int[] scores;
        static double[] prices;
        static int[] finishTimes;
        static int[] grades;
        static int[] quantities;
        static int[] copies;
        static double[] revenue;
        static double[] sortedCopy;
        static int[] seats;
        static int[] reverse;
        static int[] severity;
        static int[] sortedSeverity;

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
            temperatures = [45.6,46.3,48.9,48.4,50.1,51.2,47.5];
            for (int i = 0; i < temperatures.Length; i++)
            { 
                Console.WriteLine("Day " + (i + 1) + ": " + temperatures[i] + " C" );
            }

            Console.WriteLine("There is total of " + temperatures.Length + " temperature logs have been recorded.");
        }

        //Task 2
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

        //Task 3
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

        //Task 4
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

        //Task 5
        static void ClassroomGradeReport()
        {
            grades = [73,93,65,50,90,76,99,100,68,98];
            Array.Sort(grades);
            Array.Reverse(grades);
            for (int i = 0;i < grades.Length; i++)
            {
                Console.WriteLine("Rank " + (i + 1) + ": " + grades[i]);
            }
        }

        //Task 6
        static void WarehouseInventoryCheck()
        {
            quantities = [3,10,12,29,4,25,14,13];

            for (int i = 0; i < quantities.Length; i++)
            {
                Console.WriteLine("Product " + (i + 1) + " quantity: " + quantities[i]);
            }

            quantitySum = 0;
            for (int i = 0; i < quantities.Length; i++) 
            {
                quantitySum += quantities[i];
            }

            Console.WriteLine();
            Console.WriteLine("The total stock for all the items are: " + quantitySum);
            Console.WriteLine("The average stock: " + quantitySum / quantities.Length);
            Console.WriteLine();

            Console.WriteLine("Please enter the Product quantity you want to find its index: ");
            quantitiySearch = Convert.ToInt32(Console.ReadLine());
            index = Array.IndexOf(quantities, quantitiySearch);
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
            copies = [0,3,5,8,0,10,3,4,1];

            foreach(int copy in copies)
            {
                Console.WriteLine("Number of copies: " + copy);
            }

            Array.Sort(copies);
            lastIndex = copies.Length - 1;
            Console.WriteLine("");
            Console.WriteLine("The book with the most copies: " + copies[lastIndex]);

            for (int i = 0; i < copies.Length; i++) 
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
            revenue = [4030.400,7203.900,5390.500,4600.300,3500.400,3248.800,3700.700,6390.700,5000,3900.300,8000,6800.300];
            for (int i = 0; i < revenue.Length; i++)
            {
                Console.WriteLine("Month " + (i + 1) + ": " + revenue[i]);
            }
            
            sortedCopy = new double[revenue.Length];
            for (int i = 0;i < revenue.Length; i++)
            {
                sortedCopy[i] = revenue[i]; 
            }

            Array.Sort(sortedCopy);
            Console.WriteLine("=========== The sorted Copy ===========");

            for (int i = 0; i < sortedCopy.Length; i++)
            {
                Console.WriteLine("revenue " + (i + 1) + ": " + sortedCopy[i]);
            }

            lastIndex = sortedCopy.Length - 1;
            Console.WriteLine("The best Revenue: " + sortedCopy[lastIndex]);
            Console.WriteLine("The worst Revenue: " + sortedCopy[0]);
            revenueSum = 0;
            for (int i = 1; i < sortedCopy.Length; i++)
            {
                revenueSum += sortedCopy[i];
            }
            Console.WriteLine("The Average: " + revenueSum / sortedCopy.Length);

        }

        //Task 9 
        static void FlightSeatAllocationDisplay()
        {
            seats = [7,3,4,6,9,44,2,43,5,10,22,49,30,21,99];
            foreach (int seat in seats) {
                Console.WriteLine("Seat number: " + seat);
            }
            Console.WriteLine("");
            Array.Sort(seats);

            Console.WriteLine("Please enter the seat number you want to find its index: ");
            seatSearch = Convert.ToInt32(Console.ReadLine());
            index = Array.IndexOf(seats, seatSearch);
            if (index == -1)
            {
                Console.WriteLine("Seat not found in the array.");
            }
            else
            {
                Console.WriteLine("Seat found at index: " + index);
            }

            Console.WriteLine("");
            reverse = new int[seats.Length];
            for (int i = 0; i < reverse.Length; i++) 
            {
                reverse[i] = seats[i];
            }
            Array.Reverse(reverse);

            for (int i = 0; i < reverse.Length; i++) 
            {
                Console.WriteLine("Sorted: " + seats[i] + " Reversed: " + reverse[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Total number of seats: " + reverse.Length);
        }

        //Task 10
        static void HospitalPatientPriorityQueue()
        {
            severity = [2,3,2,4,5,6,6,9,2,1,4,5,7,8,9,8,5,10,10,2];
            sortedSeverity = new int[severity.Length];

            for (int i = 0; i < sortedSeverity.Length; i++) 
            {
                sortedSeverity[i] = severity[i];
            }

            Array.Sort(sortedSeverity);
            Array.Reverse(sortedSeverity);
            
            for(int i = 0;i < sortedSeverity.Length; i++)
            {
                Console.WriteLine("Rank " + (i + 1) + ": " + sortedSeverity[i]);
            }
            Array.Reverse(sortedSeverity);
            middleIndex1 = sortedSeverity.Length / 2;
            middleIndex2 = middleIndex1 + 1;
            median = (middleIndex1 + middleIndex2) / 2;
            Console.WriteLine("");
            Console.WriteLine("The median = " + median);

            counter = 0;
            for (int i = 0; i < sortedSeverity.Length; i++)
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
            index = Array.IndexOf(sortedSeverity, severitySearch);
            if (index == -1)
            {
                Console.WriteLine("severity not found in the array.");
            }
            else
            {
                Console.WriteLine("severity found at index: " + index);
            }
            
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

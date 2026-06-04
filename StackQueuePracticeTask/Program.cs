namespace StackQueuePracticeTask
{
    internal class Program
    {
        //Variables Decleration
        static int choice;
        static bool flag = true;
        static bool check;


        //Stack Decleration
        static Stack<string> browserHistory = new();

        //Queue Decleration



        //Method Decleration
        static void BrowserHistoryTracker()
        {
            browserHistory.Push("google.com");
            browserHistory.Push("youtube.com");
            browserHistory.Push("github.com");
            browserHistory.Push("chatgpt.com");
            browserHistory.Push("gemini.com");

            foreach (string b in browserHistory) 
            { 
                Console.WriteLine(b);
            }

            Console.WriteLine("");

            Console.WriteLine("you are at browser: " + browserHistory.Peek());

            Console.WriteLine("");
            Console.WriteLine("Press any key to go back....");
            Console.ReadKey();
            Console.WriteLine(browserHistory.Pop() + " Was removed from the stack");

            Console.WriteLine("");
            Console.WriteLine("Press any key to go back....");
            Console.ReadKey();
            Console.WriteLine(browserHistory.Pop() + " Was removed from the stack");

            Console.WriteLine("");
            Console.WriteLine("---- The remaining history ----");
            foreach (string b in browserHistory)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("");
            check = browserHistory.Contains("github.com");

            if (check)
            {
                Console.WriteLine("github.com still in the history!!");
            }
            else
            {
                Console.WriteLine("github.com not in the history!!");
            }

            Console.WriteLine("");
            Console.WriteLine("The total number of the remaining url: " + browserHistory.Count);
        }


        static void Main(string[] args)
        {
            while (flag) 
            {
                Console.WriteLine("""
                    1.Browser History Tracker
                    2.Hotel Check-In Queue
                    3.Text Editor Undo System
                    4.Hospital Emergency Room Triage
                    5.Parenthesis Validator
                    6.Print Spooler with Priority Re-Insertion
                    7.Reverse a Sentence Word by Word
                    8.Multi-Level Undo with Redo
                    9.Ticket Counter Simulation
                    10.Order Processing Pipeline with Statistics
                    11.Exit
                    """);

                Console.WriteLine("Please Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    //Browser History Tracker 
                    case 1:
                        BrowserHistoryTracker();
                        break;

                    //Hotel Check-In Queue
                    case 2:
                        break;

                    //Text Editor Undo System
                    case 3:
                        break;

                    //Hospital Emergency Room Triage
                    case 4:
                        break;

                    //Parenthesis Validator
                    case 5:
                        break;

                    //Print Spooler with Priority Re-Insertion
                    case 6:
                        break;

                    //Reverse a Sentence Word by Word
                    case 7:
                        break;

                    //Multi-Level Undo with Redo
                    case 8:
                        break;

                    //Ticket Counter Simulation
                    case 9:
                        break;

                    //Order Processing Pipeline with Statistics
                    case 10:
                        break;

                    //Exit
                    case 11:
                        Console.WriteLine("Thank you for using our system");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option!!");
                        break;
                
                }
                Console.WriteLine("Please Enter any key to continue....");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibraryManagementSystem
{
    internal class Program
    {
        //Member Variables Storage:
        static string memberName;
        static int memberID;
        static string memberEmail;
        static string membershipExpireDate;
        static string memberTier;
        static bool memberIsRegistered;


        //Library Variables Storage:
        static string bookTitle;
        static string bookAuthor;
        static string bookGenre;
        static int numberOfAvailableCopies;
        static bool bookIsRegistered;


        //Library session Variables:
        static int totalBookBorrowed;
        static double totalFines;

        //flags Variables
        static bool loopFlag = true;

        //Choice Variables
        static int option;


        static void Main(string[] args)
        {
            while (loopFlag)
            {
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    //Register Member
                    case 0:
                        break;

                    //Display Member Profile
                    case 1:
                        break;

                    //Search Book by Title
                    case 2:
                        break;

                    //Borrow a Book
                    case 3:
                        break;

                    //Return a Book
                    case 4:
                        break;

                    //Calculate Late Fine
                    case 5:
                        break;

                    //Apply Member Discount
                    case 6:
                        break;

                    //Check Borrowing Eligibility
                    case 7:
                        break;

                    //Register Book 
                    case 8:
                        break;

                    //Generate Member ID 
                    case 9:
                        break;

                    //Display Book Details 
                    case 10:
                        break;

                    //Calculate Renewal Fee
                    case 11:
                        break;

                    //Update Member Email
                    case 12:
                        break;

                    //Session Summary
                    case 13:
                        break;
                    //temporary
                    case 14:
                        loopFlag = false;
                        break;
                }


                Console.WriteLine("Enter any key to continue....");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

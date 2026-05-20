using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static Random random = new Random();// storing the Random() function in the random variable

        //Member Variables Storage:
        static string memberName = "";
        static int memberID = 0;
        static string memberEmail = "";
        static string membershipExpireDate = "";
        static string memberTier = "";
        static bool memberIsRegistered = false;


        //Library Variables Storage:
        static string bookTitle = "";
        static string bookAuthor = "";
        static string bookGenre = "";
        static int numberOfAvailableCopies = 0;
        static bool bookIsRegistered = false;


        //Library session Variables:
        static int totalBookBorrowed = 0;
        static double totalFines = 0;

        //flags Variables
        static bool loopFlag = true;

        //Choice Variables
        static int option;

        //Member Variables Holders
        static string name;
        static string email;
        static string tier;
        static DateTime dateHolder;


        

        public static void MemberDetailsPrint()
        {
            Console.WriteLine($"""
                Member ID: {memberID}
                Member Name: {memberName}
                Member Email starts with: {memberEmail.PadLeft(memberEmail.Length,'*')}
                Membership Expire Date: {membershipExpireDate}
                Member Tier: {memberTier}
                """);
        }


        public static void MemberDetailsRegister()
        {


            Console.WriteLine("Enter member name: ");
            name = Console.ReadLine();

            if (name == "") 
            { 
                Console.WriteLine("Name Can't be Empty!!");
                return;
            }
            else if (name.Length < 3) 
            {
                Console.WriteLine("Name Can't be less than 3!!");
                return;
            }

            Console.WriteLine("Enter member email: ");
            email = Console.ReadLine();

            if (email == "")
            {
                Console.WriteLine("email Can't be Empty!!");
                return;
            }
            else if (email.Length < 12)
            {
                Console.WriteLine("email Can't be less than 20!!");
                return;
            }

            Console.WriteLine("Enter member tier (resident/visitor/student/child/senior/corporate): ");
            tier = Console.ReadLine();

            if (tier == "")
            {
                Console.WriteLine("tier Can't be Empty!!");
                return;
            }
            else if (tier.ToLower() != "resident" && tier.ToLower() != "visitor" &&
                tier.ToLower() != "student" && tier.ToLower() != "child" &&
                tier.ToLower() != "senior" && tier.ToLower() != "corporate")
            {
                Console.WriteLine("you have to select one of these tiers: (resident/visitor/student/child/senior/corporate)");
                return;
            }




            memberID = random.Next(1, 101);
            memberIsRegistered = true;
            dateHolder = DateTime.Now.AddDays(365);
            membershipExpireDate = dateHolder.ToString("dd - MM - yyyy");
            memberName = name;
            memberEmail = email.Substring(email.Length - 14);
            memberTier = tier;

            Console.WriteLine("Member Registered Successfully");
        }





        static void Main(string[] args)
        {
            while (loopFlag)
            {

                Console.WriteLine("===== Welcome to the City Public Library =====");
                Console.WriteLine("""

                    0. Register Member
                    1. Display Member Profile
                    2. Search Book by Title
                    3. Borrow a Book
                    4. Return a Book
                    5. Calculate Late Fine
                    6. Apply Member Discount
                    7. Check Borrowing Eligibility
                    8. Register Book 
                    9. Generate Member ID 
                    10.Display Book Details 
                    11.Calculate Renewal Fee  
                    12.Update Member Email
                    13.Session Summary 
                    """);

                Console.WriteLine("Enter your choice: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    //Register Member
                    case 0:
                        if (memberIsRegistered)
                        {
                            Console.WriteLine("Member is already registered!!");
                            break;
                        }
                        MemberDetailsRegister();
                        MemberDetailsPrint();

                        break;

                    //Display Member Profile
                    case 1:
                        if (memberIsRegistered)
                        {
                            Console.WriteLine("Member is already registered!!");
                            break;
                        }
                        MemberDetailsPrint();
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

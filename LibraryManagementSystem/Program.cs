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
        static bool checkFlag = false;

        //Choice Variables
        static int option;
        static char choice;

        //Member Variables Holders
        static string name;
        static string email;
        static string tier;
        static DateTime dateHolder;
        static string searchBookTitle;

        //Book Variables Holders
        static string title;
        static string author;
        static string genre;

        ////////////////////////////////////////////////////////////////

        //Validation Methods
        public static bool CheckIfEmpty(string value, ref bool flag)
        {
            if (value == "")
            {
                Console.WriteLine("Filed can't be empty");
                return flag = true;
            }
            return flag = false;

        }

        public static bool CheckLengthMoreThan(string value, int num, ref bool flag)
        {
            if (value.Trim().Length < num)
            {

                Console.WriteLine("It have to be more than " + num);
                return flag = true;
            }
            return flag = false;
        }

        public static bool CheckLengthLessThan(string value, int num, ref bool flag)
        {
            if (value.Trim().Length > num)
            {

                Console.WriteLine("It have to be more than " + num);
                return flag = true;
            }
            return flag = false;
        }

        public static bool CheckIfZero( int num, ref bool flag)
        {
            if (num <= 0)
            {

                Console.WriteLine("Number can't be zero or less!!");
                return flag = true;
            }
            return flag = false;
        }

        ////////////////////////////////////////////////////////////////


        //Display Methods
        public static void MainMenu()
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

        }

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


        ////////////////////////////////////////////////////////////////

        //Tasks Methods

        public static void MemberDetailsRegister()
        {

            //Enter Name
            Console.WriteLine("Enter member name: ");
            name = Console.ReadLine();
            CheckIfEmpty(name,ref checkFlag);
            CheckLengthMoreThan(name, 3,ref checkFlag);

            //Enter Email
            Console.WriteLine("Enter member email: ");
            email = Console.ReadLine();
            CheckIfEmpty(email, ref checkFlag);
            CheckLengthMoreThan(email, 12,ref checkFlag);

            //Enter Tier
            Console.WriteLine("Enter member tier (resident/visitor/student/child/senior/corporate): ");
            tier = Console.ReadLine();
            CheckIfEmpty(tier , ref checkFlag);
            if (tier.ToLower() != "resident" && tier.ToLower() != "visitor" &&
                tier.ToLower() != "student" && tier.ToLower() != "child" &&
                tier.ToLower() != "senior" && tier.ToLower() != "corporate")
            {
                Console.WriteLine("you have to select one of these tiers: (resident/visitor/student/child/senior/corporate)");
                return;
            }

            //Signing values
            memberID = random.Next(1, 101);
            memberIsRegistered = true;
            dateHolder = DateTime.Now.AddDays(365);
            membershipExpireDate = dateHolder.ToString("dd - MM - yyyy");
            memberName = name;
            memberEmail = email.Substring(email.Length - 14);
            memberTier = tier;

            Console.WriteLine("Member Registered Successfully");
        }

        
        public static bool CheckBookAvailability(string searchBookTitle)
        {
            if (bookTitle.ToLower().Contains(searchBookTitle.ToLower().Substring(3)))
            {

                return true;
            }
            return false;
        }

    
        public static void RegisterBook(string title,string author, int numberOfCopies,string genre = "No Genre")
        {
            bookTitle = title;
            bookAuthor = author;
            numberOfAvailableCopies = numberOfCopies;
            bookGenre = genre;
        }

        public static void BorrowBook(ref int numberOfAvailableCopies)
        {
            numberOfAvailableCopies--;
        }

        public static void ReturnBook(ref int numberOfAvailableCopies)
        {
            numberOfAvailableCopies++;
        }

        static void Main(string[] args)
        {
            while (loopFlag)
            {

                MainMenu();
                
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
                        Console.WriteLine("Enter the book title you want to find: ");
                        searchBookTitle = Console.ReadLine();

                        if(searchBookTitle == "")
                        {
                            Console.WriteLine("Book title can't be empty!!");
                            break;
                        }
                        else if (CheckBookAvailability(searchBookTitle))
                        {
                            Console.WriteLine("The book you are look for: " + bookTitle);
                        }
                        else
                        {
                            Console.WriteLine("Couldn't find the book!!");
                        }
                        break;

                    //Borrow a Book
                    case 3:
                        if (!bookIsRegistered)
                        {
                            Console.WriteLine("There is no book to borrow!!");
                            break;
                        }
                        Console.WriteLine("Enter the book name to borrow: ");
                        bookTitle = Console.ReadLine();
                        if (CheckBookAvailability(bookTitle))
                        {
                            BorrowBook(ref numberOfAvailableCopies);
                            Console.WriteLine("Book Borrowed!!");
                            break;
                        }
                        Console.WriteLine("Book is not found!!");


                        break;

                    //Return a Book
                    case 4:
                        if (!bookIsRegistered)
                        {
                            Console.WriteLine("There is no book with that title!!");
                            break;
                        }
                        Console.WriteLine("Enter the book name you want to return: ");
                        bookTitle = Console.ReadLine();
                        if (CheckBookAvailability(bookTitle))
                        {
                            ReturnBook(ref numberOfAvailableCopies);
                            Console.WriteLine("Book Returned!!");
                            break;
                        }
                        Console.WriteLine("Book is not found!!");
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
                        if(!memberIsRegistered)
                        {
                            Console.WriteLine("There is no member registered!!");
                            break;
                        }
                        if (bookIsRegistered == true)
                        {
                            Console.WriteLine("There is already a book registered!!");
                        }
                        else
                        {
                            //Enter book title
                            Console.WriteLine("Enter the book title: ");
                            title = Console.ReadLine();
                            CheckIfEmpty(title , ref checkFlag);
                            CheckLengthLessThan(title, 3, ref checkFlag);
                            CheckLengthMoreThan(title, 20, ref checkFlag);
                            if (checkFlag)
                            { 
                                break;
                            }

                            //Enter book author
                            Console.WriteLine("Enter the book author name: ");
                            author = Console.ReadLine();
                            CheckIfEmpty(author, ref checkFlag);
                            CheckLengthLessThan(author, 3, ref checkFlag);
                            CheckLengthMoreThan(author, 20, ref checkFlag);
                            if (checkFlag)
                            {
                                break;
                            }

                            //Enter number of copies
                            Console.WriteLine("Enter the number of copies: ");
                            numberOfAvailableCopies = Convert.ToInt32(Console.ReadLine());
                            CheckIfZero(numberOfAvailableCopies, ref checkFlag);
                            if (checkFlag)
                            {
                                break;
                            }

                            Console.WriteLine("Do you want to enter a genre?(Y/N): ");
                            choice = Convert.ToChar(Console.ReadLine());

                            if(choice == 'y')
                            {
                                Console.WriteLine("Enter the book genre: ");
                                genre = Console.ReadLine();
                                CheckIfEmpty(genre, ref checkFlag);
                                CheckLengthLessThan(genre, 3, ref checkFlag);
                                CheckLengthMoreThan(genre, 20, ref checkFlag);
                                if (checkFlag)
                                {
                                    break;
                                }
                                RegisterBook(title, author, numberOfAvailableCopies, genre);
                                bookIsRegistered = true;
                            }
                            else
                            {
                                RegisterBook(title, author, numberOfAvailableCopies);
                                bookIsRegistered= true;
                            }
                        }

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

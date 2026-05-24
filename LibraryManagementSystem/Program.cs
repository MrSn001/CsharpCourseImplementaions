using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static Random random = new Random();// storing the Random() function in the random variable

        //Member Variables Storage:
        static string memberName = "";
        static string memberID = "";
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
        static int numberOfDays;
        static int renewalNumberOfDays;

        //Library session Variables:
        static int totalBookBorrowed = 0;
        static double totalFines = 0;

        //flags Variables
        static bool loopFlag = true;
        static bool checkFlag = true;
        static bool teirCheckFlag = false;

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
        static string idMathHolder;
        static double sqrtResult;
        static string idNameHolder;


        ////////////////////////////////////////////////////////////////

        //Validation Methods
        public static bool CheckIfEmpty(string value, ref bool checkFlag)
        {
            if (value == "")
            {
                Console.WriteLine("Filed can't be empty");
                return checkFlag = true;
            }
            return checkFlag = false;

        }

        public static bool CheckLengthMoreThan(string value, int num, ref bool checkFlag)
        {
            if (value.Trim().Length < num)
            {

                Console.WriteLine("It have to be more than " + num);
                return checkFlag = true;
            }
            return checkFlag = false;
        }

        public static bool CheckLengthLessThan(string value, int num, ref bool checkFlag)
        {
            if (value.Trim().Length > num)
            {

                Console.WriteLine("It have to be less than " + num);
                return checkFlag = true;
            }
            return checkFlag = false;
        }

        public static bool CheckIfZero( int num, ref bool checkFlag)
        {
            if (num <= 0)
            {

                Console.WriteLine("Number can't be zero or less!!");
                return checkFlag = true;
            }
            return checkFlag = false;
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
                Member Name: {memberName}
                Member Email starts with: {memberEmail.PadLeft(memberEmail.Length,'*')}
                Membership Expire Date: {membershipExpireDate}
                Member Tier: {memberTier}
                """);
        }

        public static void DisplayBookDetails(string title,string author,int numOfCopies,string genre)
        {
            title = bookTitle;
            author = bookAuthor;
            numOfCopies = numberOfAvailableCopies;
            genre = bookGenre;


            Console.WriteLine($"""
                Book Title: {title}
                Book Author: {author}
                Number Of Copies: {numOfCopies}
                Book Genre: {genre}
                """);
        }

        public static void SessionSummary()
        {
            Console.WriteLine($"""
                Member Name: {memberName}
                Total Books Borrowed: {totalBookBorrowed}
                Total Fines Paid: {Math.Round(totalFines)}
                Print Date and Time: {DateTime.Now.ToString("dd - MM - yyyy")}
                """);
        }

        ////////////////////////////////////////////////////////////////

        //Tasks Methods

        public static void MemberDetailsRegister()
        {

          
            //Signing values
            memberIsRegistered = true;
            dateHolder = DateTime.Now.AddDays(365);
            membershipExpireDate = dateHolder.ToString("dd - MM - yyyy");
            memberName = name;
            memberEmail = email.Substring(Math.Abs(email.Length - 14));
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
            totalBookBorrowed++;
        }

        public static void ReturnBook(ref int numberOfAvailableCopies)
        {
            numberOfAvailableCopies++;
            totalBookBorrowed--;
        }

        public static double CalculateLateFine(int numberOfDays)
        {
            return 3 * Math.Round(Math.Sqrt(numberOfDays));
        }

        public static double CalculateDiscount(double price)
        {
            return price * 0.1;
        }

        public static double CalculateDiscount(double price,string tier)
        {
            if (tier.ToLower() == "premium")
            {
                return price * 0.5;
            }
            return CalculateDiscount(price);
        }

        public static bool CheckBorrowingEligibility(string date)
        {

            
            if (DateTime.ParseExact(date,"dd - MM - yyyy", CultureInfo.InvariantCulture) > DateTime.Now)
            {
                return true;
               
            }
            return false;
        }

        public static string GenerateMemberID()
        {
            
            sqrtResult = Math.Sqrt(DateTime.Now.Ticks);
            idMathHolder = sqrtResult.ToString("F0");
            idNameHolder = memberName.Substring(0,3).ToUpper();
            memberID = idMathHolder + idNameHolder;
            return memberID;
        }

        public static decimal CalculateRenewalFee(int number)
        {
            totalFines = totalFines - Math.Sqrt(number) * 3.0;
            return Math.Ceiling((decimal)totalFines);
        }

        public static bool UpdateEmailValidation(out string result,int num,ref bool checkFlag)
        {
            Console.WriteLine("Enter your new Email: ");
            string email = Console.ReadLine();

            if (email.Trim().Length < num)
            {

                Console.WriteLine("It have to be more than " + num);
                result = string.Empty;
                return checkFlag = true;
            }
            result = email.Trim();
            Console.WriteLine("Email Updated!!");
            return checkFlag = false;
        }


        public static decimal CalculateRenewalFee(int number, bool flag)
        {
            if (flag)
            {
                totalFines = totalFines - Math.Sqrt(number) * 3.0/2;
                return Math.Round((decimal)totalFines);
            }
            return CalculateRenewalFee(number);
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

                        //Enter Name
                        Console.WriteLine("Enter member name: ");
                        name = Console.ReadLine();
                        CheckIfEmpty(name, ref checkFlag);
                        CheckLengthMoreThan(name, 3, ref checkFlag);
                        if (checkFlag)
                        {
                            break;
                        }
                        else
                        {
                            //Enter Email
                            Console.WriteLine("Enter member email: ");
                            email = Console.ReadLine();
                            CheckIfEmpty(email, ref checkFlag);
                            CheckLengthMoreThan(email, 12, ref checkFlag);
                            if (checkFlag)
                            {
                                break;
                            }
                            else
                            {

                                //Enter Tier
                                Console.WriteLine("Enter member tier (standard/premium): ");
                                tier = Console.ReadLine();
                                CheckIfEmpty(tier, ref checkFlag);
                                if (tier.ToLower() != "standard" && tier.ToLower() != "premium")
                                {
                                    Console.WriteLine("you have to select one of these tiers: (standard/premium)");
                                    break;
                                }
                                else if (checkFlag)
                                {
                                    break;
                                }
                                else
                                {
                                    MemberDetailsRegister();
                                    MemberDetailsPrint();
                                }
                                

                            }
                        }

                       


                        break;

                    //Display Member Profile
                    case 1:
                        if (!memberIsRegistered)
                        {
                            Console.WriteLine("There is no member registered!!");
                            break;
                        }
                        MemberDetailsPrint();
                        break;

                    //Search Book by Title
                    case 2:
                        if (!bookIsRegistered) 
                        {
                            Console.WriteLine("There is no book registered!!");
                            break;
                        }
                        Console.WriteLine("Enter the book title you want to find: ");
                        searchBookTitle = Console.ReadLine();

                        CheckIfEmpty(searchBookTitle, ref checkFlag);
                        if (checkFlag)
                        {
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
                        if (!bookIsRegistered || numberOfAvailableCopies == 0)
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
                            Console.WriteLine("There is no book registered!!");
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
                        if (!bookIsRegistered)
                        {
                            Console.WriteLine("There is no book registered!!");
                            break;
                        }
                        Console.WriteLine("Enter the number of days you want to borrow the book to calculate: ");
                        numberOfDays = Convert.ToInt32(Console.ReadLine());
                        CheckIfZero(numberOfDays, ref checkFlag);
                        if (checkFlag)
                        {
                            break;
                        }
                        else
                        {
                            totalFines = CalculateLateFine(numberOfDays);
                            Console.WriteLine("The Late Fine = " + totalFines);
                        }
                        
                        break;

                    //Apply Member Discount
                    case 6:
                        if (!bookIsRegistered)
                        {
                            Console.WriteLine("There is no book to borrow!!");
                            break;
                        }

                        Console.WriteLine($"Your have a {memberTier} discount, the discount: " + CalculateDiscount(totalFines, memberTier));
                        
                     
                        break;

                    //Check Borrowing Eligibility
                    case 7:
                        if (!memberIsRegistered)
                        {
                            Console.WriteLine("There is no member registered!!");
                            break;
                        }
                        if (CheckBorrowingEligibility(membershipExpireDate))
                        {
                            Console.WriteLine("You have the eligibility to borrow the book");
                        }
                        Console.WriteLine("You don't have the eligibility to borrow the book!!");
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
                            CheckLengthLessThan(title, 20, ref checkFlag);
                            CheckLengthMoreThan(title, 3, ref checkFlag);
                            if (checkFlag)
                            { 
                                break;
                            }
                            else
                            {

                                //Enter book author
                                Console.WriteLine("Enter the book author name: ");
                                author = Console.ReadLine();
                                CheckIfEmpty(author, ref checkFlag);
                                CheckLengthLessThan(author, 20, ref checkFlag);
                                CheckLengthMoreThan(author, 3, ref checkFlag);
                                if (checkFlag)
                                {
                                    break;
                                }
                                else
                                {
                                    //Enter number of copies
                                    Console.WriteLine("Enter the number of copies: ");
                                    numberOfAvailableCopies = Convert.ToInt32(Console.ReadLine());
                                    CheckIfZero(numberOfAvailableCopies, ref checkFlag);
                                    if (checkFlag)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Do you want to enter a genre?(Y/N): ");
                                        choice = Convert.ToChar(Console.ReadLine());

                                        if (choice == 'y')
                                        {
                                            Console.WriteLine("Enter the book genre: ");
                                            genre = Console.ReadLine();
                                            CheckIfEmpty(genre, ref checkFlag);
                                            CheckLengthLessThan(genre, 20, ref checkFlag);
                                            CheckLengthMoreThan(genre, 3, ref checkFlag);
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
                                            bookIsRegistered = true;
                                        }
                                    }
                                }
                            }
                        }

                        break;

                    //Generate Member ID 
                    case 9:
                        if (!memberIsRegistered)
                        {
                            Console.WriteLine("There is no member registered!!");
                            break;
                        }
                        Console.WriteLine("Your member ID: " + GenerateMemberID());
                        break;

                    //Display Book Details 
                    case 10:
                        if (!bookIsRegistered)
                        {
                            Console.WriteLine("There is no Book registered!!");
                            break;
                        }
                        DisplayBookDetails(genre: bookGenre, author : bookAuthor, numOfCopies: numberOfAvailableCopies, title: bookTitle);
                        break;

                    //Calculate Renewal Fee
                    case 11:
                        if (!bookIsRegistered)
                        {
                            Console.WriteLine("There is no Book registered!!");
                            break;
                        }
                        else if(totalBookBorrowed == 0)
                        {
                            Console.WriteLine("There is no borrowed book!!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter the number of days you wnat to add: ");
                            renewalNumberOfDays = Convert.ToInt32(Console.ReadLine());
                            if(memberTier == "premium")
                            {
                                teirCheckFlag = true;
                            }
                            Console.WriteLine("it will cost: " + CalculateRenewalFee(renewalNumberOfDays, teirCheckFlag));
                        }
                        break;

                    //Update Member Email
                    case 12:
                        if (!memberIsRegistered)
                        {
                            Console.WriteLine("There is no member registered!!");
                            break;
                        }
                        else
                        {
                            do
                            {
                                UpdateEmailValidation(out memberEmail, 12, ref checkFlag);
                            } while (checkFlag);
                        }
                        break;

                    //Session Summary
                    case 13:
                        if (totalBookBorrowed == 0)
                        {
                            Console.WriteLine("There is no borrowed book");
                        }
                        SessionSummary();
                        loopFlag = false;
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

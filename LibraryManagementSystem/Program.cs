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

                }


                Console.WriteLine("Enter any key to continue....");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

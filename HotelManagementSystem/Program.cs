namespace HotelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables    
            string guestName = "";
            string guestPhone = "";
            int loyaltyPoints = 0;
            int roomNumber = 0;
            string roomType = "";
            double nightlyRate = 0; 
            string roomNotes = "";
            DateTime checkInDate = DateTime.Now;   
            DateTime checkOutDate = DateTime.Now;
            int numberOfNights = 0;
            double discountPercentage = 0.0;
            bool isRegistered = false;
            bool isCheckedIn = false;

            //Switch option variables
            int option;

            //While loop flag
            bool flag = false;
            //////////////////////////////////////////////////////////////////

            //Process

            while (flag == false)
            {
                Console.WriteLine("======= Welcome to Grand Palace Hotel =======");
                Console.WriteLine("""

                0. Register New Guest 
                1. View Guest Information 
                2. Check-In Guest 
                3. Check-Out & Bill 
                4. Apply Discount
                5. Upgrade Room
                6. Add Room Service Note
                7. Search Guest by Name 
                8. Calculate Loyalty Points 
                9. Print Receipt 
                10.Edit Guest Name 
                11.Exit 

                """);

                Console.WriteLine("Enter your choice");
                option = Convert.ToInt32(Console.ReadLine());


                switch (option)
                {
                    //0. Register New Guest 
                    case 0:
                        break;
                    //1. View Guest Information 
                    case 1:
                        if(!isRegistered)
                        {
                            Console.WriteLine("There is no Registered Guest!!");
                        }
                        else
                        {
                            Console.WriteLine("Guest Name: " + guestName.ToUpper() + " Phone Number: " + guestPhone +
                                              " Room Type: " + roomType + " Nightly Rate: " + Math.Round(nightlyRate) +
                                              " Room Number: " + Convert.ToString(roomNumber));
                        }
                        Console.WriteLine("");
                        break;
                    //2. Check-In Guest 
                    case 2:
                        break;
                    //3. Check-Out & Bill
                    case 3:
                        break;
                    //4. Apply Discount
                    case 4:
                        break;
                    //5. Upgrade Room 
                    case 5:
                        break;
                    //6. Add Room Service Note 
                    case 6:
                        break;
                    //7. Search Guest by Name 
                    case 7:
                        break;
                    //8. Calculate Loyalty Points
                    case 8:
                        break;
                    //9. Print Receipt  
                    case 9:
                        break;
                    //10.Edit Guest Name 
                    case 10:
                        break;
                    //11.Exit the system
                    case 11:
                        flag = true;
                        break;
                    default: 
                        Console.WriteLine("Invalid option, please enter agein!!");
                        break;
                }


                Console.WriteLine("Enter any key to continue....");
                Console.ReadKey();
                Console.Clear();

            }

        }
    }
}

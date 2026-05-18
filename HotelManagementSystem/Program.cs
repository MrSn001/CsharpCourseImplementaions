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
            Random random = new Random();
            int roomNumber = 0;
            string roomType = "";
            double nightlyRate = 0; 
            string roomNotes = "";
            DateTime checkInDate;   
            DateTime checkOutDate;
            int numberOfNights = 0;
            double discountPercentage = 0.0;
            bool isRegistered = false;
            bool isCheckedIn = false;


            //Holder Variables 
            string addName;
            string addPhone;
            string addRoomType;
            double addNightlyRate;



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
                        if (isRegistered)
                        {
                            Console.WriteLine("You already registered!!");
                        }
                        else
                        {
                            Console.WriteLine("Enter the guest name: ");
                            addName = Console.ReadLine();
                            if (addName == "")
                            {
                                Console.WriteLine("Name Can't be empty!!");
                                break;
                            }
                            else if (addName.Length < 3 || addName.Length > 30)
                            {
                                Console.WriteLine("Name Can't be less than 3 and more than 30!!");
                                break;
                            }

                            Console.WriteLine("Enter the phone number: ");
                            addPhone = Console.ReadLine().Trim();
                            if (addPhone == "")
                            {
                                Console.WriteLine("Phone number can't be empty!!");
                                break;
                            }
                            else if (addPhone.Length != 8)
                            {
                                Console.WriteLine("Phone number must to be 8 digits!!");
                                break;
                            }

                            Console.WriteLine("Enter the room type: ");
                            addRoomType = Console.ReadLine();
                            if (addRoomType == "")
                            {
                                Console.WriteLine("Room type number can't be empty!!");
                                break;
                            }

                            Console.WriteLine("Enter the nightly rate: ");
                            addNightlyRate = Convert.ToDouble(Console.ReadLine());

                            guestName = addName;
                            guestPhone = addPhone;
                            roomType = addRoomType;
                            nightlyRate = addNightlyRate;
                            roomNumber = random.Next(1, 101);
                            isRegistered = true;
                            Console.WriteLine("Guest Registered!!");
                        }
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
                        
                        break;
                    //2. Check-In Guest 
                    case 2:
                        if (isCheckedIn)
                        {
                            Console.WriteLine("The guest already checked in!!");
                        }
                        else if(!isRegistered)
                        {
                            Console.WriteLine("There is no guest registered!!");
                        }
                        else
                        {
                            Console.WriteLine("Enter the number of nights to check-In");
                            numberOfNights = Convert.ToInt32(Console.ReadLine());
                            if(numberOfNights == 0)
                            {
                                Console.WriteLine("number of nights can't be 0!!");
                                break;
                            }
                            else
                            {
                                checkInDate = DateTime.Now;
                                checkOutDate = checkInDate.AddDays(numberOfNights);

                                isCheckedIn = true;

                                Console.WriteLine("Success!! you Checked-In at: " + checkInDate.ToString("dd-MM-yy") 
                                    + " Checked-Out at: " + checkOutDate.ToString("dd-MM-yy"));
                                
                            }
                        }
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

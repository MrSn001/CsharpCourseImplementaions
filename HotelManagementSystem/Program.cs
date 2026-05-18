namespace HotelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables    
            string guestName = "";
            string guestPhone = "";
            double loyaltyPoints = 0;
            Random random = new Random();
            int roomNumber = 0;
            string roomType = "";
            double nightlyRate = 0; 
            string roomNotes = "";
            DateTime checkInDate = DateTime.Now;   
            DateTime checkOutDate = DateTime.Now;
            int numberOfNights = 0;
            double discountPercentage = 0;
            bool isRegistered = false;
            bool isCheckedIn = false;


            //Holder Variables 
            string addName;
            string addPhone;
            string addRoomType;
            double addNightlyRate;
            double totalPrice = 0;
            double addDiscount;
            double totalPriceAfterDiscount = 0;
            string receipt;

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
                                              " Room Type: " + roomType + " Nightly Rate: " + Math.Round(nightlyRate, 3) +
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
                        if (!isCheckedIn)
                        {
                            Console.WriteLine("You have to check-in first!!");
                        }
                        else
                        {
                            Console.WriteLine("Guest Name: " + guestName.ToUpper() + " Phone Number: " + guestPhone +
                                              " Room Type: " + roomType + " Nightly Rate: " + Math.Round(nightlyRate, 3) +
                                              " Room Number: " + Convert.ToString(roomNumber));

                            totalPrice = nightlyRate * numberOfNights;
                            if(discountPercentage > 0)
                            {
                                totalPriceAfterDiscount = totalPrice - (totalPrice * discountPercentage);
                                Console.WriteLine($"Total: {Math.Round(totalPriceAfterDiscount , 3)}");
                            }
                            else
                            {
                                Console.WriteLine("Total: " +  Math.Round(totalPrice),3);
                                totalPriceAfterDiscount = totalPrice; // To display the total price in the receipt
                            }

                            guestName = ""; guestPhone = ""; roomType = ""; nightlyRate = 0; 
                            roomNumber = 0; isRegistered = false; isCheckedIn = false;

                            
                        }
                        break;
                    //4. Apply Discount
                    case 4:
                        if (!isCheckedIn)
                        {
                            Console.WriteLine("You need to check-in first!!");
                        }
                        else
                        {
                            totalPrice = nightlyRate * numberOfNights;
                         //   Console.WriteLine("Total price before discount: " + totalPrice);
                            Console.WriteLine("Enter the discount percentage(eg. 0.1): ");
                            addDiscount = Convert.ToDouble(Console.ReadLine());
                            
                            if(addDiscount == 0)
                            {
                                Console.WriteLine("Discount percentage can't be 0!!");
                                break;
                            }
                            else
                            {
                                discountPercentage = addDiscount;
                                totalPriceAfterDiscount = totalPrice - (totalPrice * addDiscount); 
                            }

                            Console.WriteLine("Total price before discount: " + totalPrice);
                            Console.WriteLine("Total price after discount: " + totalPriceAfterDiscount);
                            Console.WriteLine("Amount saved: " + Math.Abs(totalPrice - totalPriceAfterDiscount));

                        }
                        break;
                    //5. Upgrade Room 
                    case 5:
                        if (!isCheckedIn)
                        {
                            Console.WriteLine("You have to check-in first!!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter the room type: ");
                            addRoomType = Console.ReadLine();
                            if (addRoomType == "")
                            {
                                Console.WriteLine("Room type number can't be empty!!");
                                break;
                            }

                            Console.WriteLine("Enter the nightly rate: ");
                            addNightlyRate = Convert.ToDouble(Console.ReadLine());
                            if(addNightlyRate == 0)
                            {
                                Console.WriteLine("Nightly rate can't be 0!!");
                                break;
                            }


                            Console.WriteLine("The higher nightly rate: " + Math.Max(nightlyRate,addNightlyRate));
                            Console.WriteLine("The lower nightly rate: " + Math.Min(nightlyRate, addNightlyRate));
                            Console.WriteLine("The difference per night: " + Math.Abs(nightlyRate - addNightlyRate));

                            roomType = addRoomType;
                            nightlyRate = addNightlyRate;
                            roomNumber = random.Next(1, 101);

                        }
                        break;
                    //6. Add Room Service Note 
                    case 6:
                        if (!isCheckedIn)
                        {
                            Console.WriteLine("You have to check-in first!!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter the Service Room Note: ");
                            roomNotes = Console.ReadLine();
                            if(roomNotes == "")
                            {
                                Console.WriteLine("Service Room Note Can't Be Empty!!");
                                break;
                            }

                            roomNotes = roomNotes.Replace("[Name]", guestName);
                            roomNotes = roomNotes.Replace("[Room Number]", Convert.ToString(roomNumber));
                            roomNotes = roomNotes.Replace("[Room Type]", roomType);
                            roomNotes = roomNotes.Trim();
                            Console.WriteLine($"{roomNotes}");
                            Console.WriteLine("Total notes length: " + roomNotes.Length);
                            
                        }
                        break;
                    //7. Search Guest by Name 
                    case 7:
                        if (!isRegistered)
                        {
                            Console.WriteLine("You have to register first!!");
                            break;
                        }
                        Console.WriteLine("Enter the guest name to search: ");
                        addName = Console.ReadLine();
                        if (guestName.ToLower().Contains(addName))
                        {
                            Console.WriteLine("Name found!! it is " + guestName);
                        }
                        else
                        {
                            Console.WriteLine("Couldn't find the name!!");
                        }
                        break;
                    //8. Calculate Loyalty Points
                    case 8:
                        if (!isCheckedIn)
                        {
                            Console.WriteLine("You have to check-in first!!");
                            break;
                        }
                        else
                        {
                            loyaltyPoints = Math.Round(Math.Pow(numberOfNights,2));
                            Console.WriteLine("Your loyalty points = " + loyaltyPoints);
                        }
                            break;
                    //9. Print Receipt  
                    case 9:
                        if (!isCheckedIn)
                        {
                            Console.WriteLine("You have to check-in first!!");
                            break;
                        }
                        else
                        {

                            receipt = """
                            ==================================================
                                             HOTEL RECEIPT                    
                            ==================================================
                             Receipt Date:   [Receipt Date]
                             Room Number:    [Room Number]
                             Room Type:      [Room Type]
                             Guest Name:     [Guest Name]
                             Contact Phone:  [Phone Number]
                            --------------------------------------------------
                             Stay Details:
                               Check-In:     [Check-In]
                               Check-Out:    [Check-Out]
                               Total Nights: [Total Nights]
                            --------------------------------------------------
                             Billing Breakdowns:
                               Nightly Rate: [Nightly Rate] OMR
                               Base Total:   [Base Total] OMR
                               Discount Applied: [Discount Applied]
                            --------------------------------------------------
                             TOTAL AMOUNT:   [TOTAL AMOUNT] OMR
                            ==================================================
                                    Thank you for choosing your stay!         
                            ==================================================
                            """;

                            receipt = receipt.Replace("[Receipt Date]", DateTime.Now.ToString());
                            receipt = receipt.Replace("[Room Number]", Convert.ToString(roomNumber));
                            receipt = receipt.Replace("[Room Type]", roomType);
                            receipt = receipt.Replace("[Guest Name]", guestName);
                            receipt = receipt.Replace("[Phone Number]", guestPhone);
                            receipt = receipt.Replace("[Check-In]", checkInDate.ToString("dd-MM-yy"));
                            receipt = receipt.Replace("[Check-Out]", checkOutDate.ToString("dd-MM-yy"));
                            receipt = receipt.Replace("[Total Nights]", Convert.ToString(numberOfNights));
                            receipt = receipt.Replace("[Nightly Rate]", Convert.ToString(nightlyRate));
                            receipt = receipt.Replace("[Base Total]", Convert.ToString(totalPrice));
                            receipt = receipt.Replace("[Discount Applied]", Convert.ToString(discountPercentage));
                            receipt = receipt.Replace("[TOTAL AMOUNT]", Convert.ToString(totalPriceAfterDiscount));

                            Console.WriteLine(receipt);
                        }
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

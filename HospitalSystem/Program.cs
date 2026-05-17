using System.Xml.Linq;

namespace HospitalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Region 1 - adding system variables: 

            //Patient Variables
            string p1Name = ""; int p1Age = 0; string p1Email = ""; string p1PhoneNumber = ""; bool p1isActive = false;
            string p2Name = ""; int p2Age = 0; string p2Email = ""; string p2PhoneNumber = ""; bool p2isActive = false;


            //Counter Variables
            const int MAX_PATIENT = 2;
            int countPatient = 0;
            int displayNum = 0;


            //flags variables
            bool flag = false;

            //option variables
            int option;



            //holders variables
            string name;
            int age;
            string email;
            string phoneNumber;
            









            //Region 2 Main Menu
            while (flag == false)
            {
                Console.WriteLine("---Main Menu---");
                Console.WriteLine("""
                1. Add New Patient
                2. View All Patients
                3. Search for a Patient
                4. Update Patient info
                5. Delete Patient From the System
                0. Exit the System
                """);

                Console.WriteLine("Enter the number of services: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    //1. Add New Patient
                    case 1:
                        if (countPatient == MAX_PATIENT)
                        {
                            Console.WriteLine("Full there is no more space to add new patient!!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter the patient name: ");
                            name = Console.ReadLine();
                            if (name == "")
                            {
                                Console.WriteLine("Error, Name Can't be Empty!!");
                                break;
                            }
                            Console.WriteLine("Enter the patient age: ");
                            age = Convert.ToInt32(Console.ReadLine());
                            if (age < 0)
                            {
                                Console.WriteLine("Error, the age can't be negative");
                                break;
                            }
                            Console.WriteLine("Enter the patient email: ");
                            email = Console.ReadLine();
                            if (email == "")
                            {
                                Console.WriteLine("Error, Email Can't be Empty!!");
                                break;
                            }
                            Console.WriteLine("Enter the patient phone number: ");
                            phoneNumber = Console.ReadLine();
                            if (phoneNumber == "")
                            {
                                Console.WriteLine("Error, Email Can't be Empty!!");
                                break;
                            }


                            if (!p1isActive)
                            {
                                p1Name = name; p1Age = age; p1PhoneNumber = phoneNumber; p1Email = email; p1isActive = true;
                            }
                            else if (!p2isActive)
                            {
                                p2Name = name; p2Age = age; p2PhoneNumber = phoneNumber; p2Email = email; p2isActive = true;
                            }


                            countPatient ++;
                            Console.WriteLine("");
                            Console.WriteLine("Patient added successfully.");
                            
                            break;
                        }
                    //2. View All Patients
                    case 2:
                        
                        if (countPatient == 0)
                        {
                            Console.WriteLine("There is no registered patients!!");
                            break;
                        }
                        else
                        {
                            
                            if (p1isActive)
                            {
                                displayNum++;
                                Console.WriteLine($"{displayNum}. Patient Name: {p1Name} || Age: {p1Age} || Email: {p1Email} || Phone Number: {p1PhoneNumber}  "); 
                            }
                            if (p2isActive)
                            {
                                displayNum++;
                                Console.WriteLine($"{displayNum}. Patient Name: {p2Name} || Age: {p2Age} || Email: {p2Email} || Phone Number: {p2PhoneNumber}  ");
                            }
                        }
                        displayNum = 0;
                        break;
                    //3. Search for a Patient
                    case 3:
                        if (countPatient == 0)
                        {
                            Console.WriteLine("There is no registered patients!!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter the patient name: ");
                            name = Console.ReadLine();
                            if (p1isActive && p1Name == name)
                            {
                                Console.WriteLine($"Patient Name: {p1Name} || Age: {p1Age} || Email: {p1Email} || Phone Number: {p1PhoneNumber}  ");
                            }
                            else if(p2isActive && p2Name == name)
                            {
                                Console.WriteLine($"Patient Name: {p2Name} || Age: {p2Age} || Email: {p2Email} || Phone Number: {p2PhoneNumber}  ");
                            }
                            else
                            {
                                Console.WriteLine("The patient you searched for is not available!!");
                            }
                        }
                            break;
                    //4. Update Patient info
                    case 4:
                        break;
                    //5. Delete Patient From the System
                    case 5:
                        break;
                    case 0:
                        Console.WriteLine("Thank you for using our system");
                        flag = true;
                        break;
                    default: 
                        Console.WriteLine("Invalid Option");
                        break;
                }

                Console.WriteLine("Press any key to continue....");
                Console.ReadKey();
                Console.Clear();

            }
            




        }
    }
}

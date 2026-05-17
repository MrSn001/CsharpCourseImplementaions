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
                3. Update Patient info
                4. Delete Patient From the System
                0. Exit the System
                """);

                Console.WriteLine("Enter the number of services: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        break;
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
                                Console.WriteLine($"{displayNum}. Patient Name: {p1Name}, || Age: {p1Age} || Email: {p1Email} || Phone Number: {p1PhoneNumber}  "); 
                            }
                            if (p2isActive)
                            {
                                Console.WriteLine($"{displayNum}. Patient Name: {p2Name}, || Age: {p2Age} || Email: {p2Email} || Phone Number: {p2PhoneNumber}  ");
                            }
                        }
                        break;
                    case 3:
                        break;
                    case 4:
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

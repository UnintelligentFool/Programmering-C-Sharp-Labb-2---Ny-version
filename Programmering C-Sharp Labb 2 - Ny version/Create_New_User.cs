using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Ny_version {
    class Create_New_User {

        public static string[] newUsersStrings = new string[5];

        public static string newUsersFirstName;
        public static string newUsersLastName;
        public static string newUsersUsername;
        public static string newUsersPassword;
        public static string newUsersMembershipLevel;

        
        public Create_New_User() { //string name, string password

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine("             Så trevligt att ni vill bli våran kund.");
            Console.Write("             Vänligen bifoga följande information för att registreras hos oss.\n\n");
            Console.WriteLine("             Vilket är ditt förnamn?");

            newUsersFirstName = Console.ReadLine();
            newUsersStrings[0] += newUsersFirstName;

            Console.WriteLine("\n             Vilket är ditt efternamn?");

            newUsersLastName = Console.ReadLine();
            newUsersStrings[1] += newUsersLastName;

            Console.WriteLine("\n             Vilket användarnamn vill du använda? (Används vid inloggning.)");

            newUsersUsername = Console.ReadLine();
            newUsersStrings[2] += newUsersUsername;

            Console.WriteLine("\n             Vilket lösenord vill du använda?");

            newUsersPassword = Console.ReadLine();
            newUsersStrings[3] += newUsersPassword;

            DoYouWantPremiumServices();

        }

        public static void DoYouWantPremiumServices() {

            Console.WriteLine("\n             Vill du bli en av våra premium kunder?");
            Console.Write("             Svara något av följande: \"Nej\"/\"Bronze\"/\"Silver\"/\"Gold\"\n");

            newUsersMembershipLevel = Console.ReadLine().ToLower();

            if (newUsersMembershipLevel == "nej" || newUsersMembershipLevel == "bronze" || newUsersMembershipLevel == "silver" || newUsersMembershipLevel == "gold") {

                newUsersStrings[4] += newUsersMembershipLevel;

                ThankYouForCreatingAccount();

            } else {

                Console.WriteLine("Vänligen ange ett av de nämnda alternativen.\n");

                //Console.ReadKey();

                DoYouWantPremiumServices();

                /*newUsersMembershipLevel = Console.ReadLine().ToLower();

                if (newUsersMembershipLevel == "nej" || newUsersMembershipLevel == "bronze" || newUsersMembershipLevel == "silver" || newUsersMembershipLevel == "gold") {

                    newUsersStrings[4] += newUsersMembershipLevel;

                } else {

                    Console.WriteLine("Det är tyvärr inte ett ett av alternativen. \nDu misslyckades med att skapa ett användarkonto.");

                    Console.ReadKey();

                }*/

            }
            
            //Console.WriteLine("Donald Duck");

            //Console.ResetColor();

        }

        public static void ThankYouForCreatingAccount() {

            Console.WriteLine("Tack för att du skapade ett konto hos oss!");

            Program.IsSomeoneOnline = true;

            Program.UserOnline = newUsersUsername;

            Console.ResetColor();

            Console.Clear();

            //Program.MainMenu();
            
        }

    }
}

/*
 
 Jag får göra en array, eller så, här vilken hämtas av Main/huvudprogrammet som sedan kör en liten 
 metod som lägger till arrayen i en lista med användare som jag får skapa. Lägga till knattarna i samma lista.
 Kolla mot listan när man loggar in eller skapar nya konton.

 */























/*
public static void DoYouWantPremiumServices() {

    Console.WriteLine("\n             Vill du bli en av våra premium kunder?");
    Console.Write("             Svara något av följande: \"Nej\"/\"Bronze\"/\"Silver\"/\"Gold\"\n");

    newUsersMembershipLevel = Console.ReadLine().ToLower();

    if (newUsersMembershipLevel == "nej" || newUsersMembershipLevel == "bronze" || newUsersMembershipLevel == "silver" || newUsersMembershipLevel == "gold") {

        newUsersStrings[4] += newUsersMembershipLevel;

    } else {

        Console.WriteLine("Vänligen ange ett av de nämnda alternativen.");

        newUsersMembershipLevel = Console.ReadLine().ToLower();

        if (newUsersMembershipLevel == "nej" || newUsersMembershipLevel == "bronze" || newUsersMembershipLevel == "silver" || newUsersMembershipLevel == "gold") {

            newUsersStrings[4] += newUsersMembershipLevel;

        } else {

            Console.WriteLine("Det är tyvärr inte ett ett av alternativen. \nDu misslyckades med att skapa ett användarkonto.");

            Console.ReadKey();

        }

    }

    Console.ResetColor();

}

    }
} */
































//string name;

//string lastName;

//string vipMember; //4 värden, om jag implementerar det, "No"/"Bronze"/"Silver"/"Gold"

//string password;







/*Console.WriteLine("             So nice that you would like to become our customer.");
            Console.Write("             Please provide the following information to register with us.\n\n");*/






/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Try5 {
    class Create_New_User {
        public Create_New_User() { //string name, string password

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n");

            Console.WriteLine("             So nice that you would like to become our customer.");
            Console.Write("             Please provide the following information to register with us.\n\n");

            Console.WriteLine("             What is your first name?\n");

            string newUsersFirstName = Console.ReadLine();

            Console.WriteLine("             What is your last name?");

            string newUsersLastName = Console.ReadLine();

            Console.WriteLine("             What password would you like to use?");

            string newUsersPassword = Console.ReadLine();

            Console.WriteLine("             Are you interested in a premium membership?");
            Console.Write("             Valid answers are: \"No\"/\"Bronze\"/\"Silver\"/\"Gold\"\n");

            string newUsersMembershipLevel = Console.ReadLine();

            //string name;

            //string lastName;

            //string vipMember; //4 värden, om jag implementerar det, "No"/"Bronze"/"Silver"/"Gold"

            //string password;

            Console.ResetColor();

        }
    }
}

*/
//
//  Lab2 – Skapa en simpel butik
//  Skapa en konsollaplikation som skall agera som en enkel affär. När programmet körs så ska man få se
//  någon form av meny där man ska kunna välja att registrera ny kund eller logga in. Därefter ska ytterligare
//  en meny visas där man ska kunna välja att handla, se kundvagn eller gå till kassan.
//  
//  Om man väljer att handla ska man få upp minst 3 olika produkter att köpa (t.ex. Korv, Dricka och Äpple).
//  Man ska se pris för varje produkt och kunna lägga till vara i kundvagn.
//  
//  Kundvagnen ska visa alla produkter man lagt i den, styckpriset, antalet och totalpriset samt totala kostnaden
//  för hela kundvagnen. Kundvagnen skall sparas i kund och finnas tillgänglig när man loggar in.
//  
//  När man ska Registrera en ny kund ska man ange Namn och lösenord. Dessa ska sparas och namnet ska inte gå
//  att ändra.
//  
//  Väljer man Logga In så ska man skriva in namn och lösenord. Om användaren inte finns registrerad ska programmet
//  skriva ut att kunden inte finns och fråga ifall man vill registrera ny kund. Om lösenordet inte stämmer så ska
//  programmet skriva ut att lösenordet är fel och låta användaren försöka igen.
//  
//  Både kund och produkt ska vara separata klasser med Properties för information och metoder för att räkna ut
//  totalpris och verifiera lösenord.
//  
//  I klassen Kund skall det finnas en ToString() som skriver ut Namn, lösenord och kundvagnen på ett snyggt sätt.
//
//
//  Exempel:
//
//  public class Customer {
//      public string Name { get; private set; }
//
//      private string Password { get; set }
//
//        private List<Product> _cart;
//      public List<Product> Cart { get { return _cart; } }
//
//     public Kund(string name, string password) {
//            this.Name = name;
//            this.Password = password;
//            this._cart = new List<Product>();
//        }
//  }
//
//
//  Redovisning
//  Uppgiften ska lösas individuellt eller i par.
//  OBS! Väljer man att jobba i par skall man arbeta i samma repository. Det skall vara tydligt vem som gjort vad.
//  Lämna in uppgiften på ithsdistans med en kommentar med github-länken.
//  
//  Betygskriterier
//  För godkänt:
//  Koden ska fungera enligt ovan beskrivning.
//  Man ska kunna få ut korrekt totalpris och antal i kundvagnen.
//  ToString() ska vara implementerad.
//  Programmet skall fungera utan krasch.
//  Det skall gå att skapa ny kund, lägga till föremål i kundvagnen, titta i sin kundvagn och sedan fortsätta handla.
//  Log in ska fungera för minst 3 fördefinierade kunder.
//  Kund1: Namn = "Knatte", Password = "123"
//  Kund2: Namn = "Fnatte", Password = "321"
//  Kund3: Namn = "Tjatte", Password = "213"
//  Det skall gå att logga ut och in men inget krav på att skapade kunder skall finnas kvar emellan körningar.
//  För väl godkänt krävs även:
//  Koden ska vara väl strukturerad och lätt att förstå
//  Lösningen ska inte innehålla massa onödig kod.
//  Det ska vara skalbart och enkelt att utöka.
//  Man ska även implementera extrauppgiften enligt nedan.
//
//
//  OBS! Extra uppgift som krävs för VG!
//
//  Som Extra uppgift ska man på något sätt implementera 3 nivåer av kund (Gold, Silver och Bronze), dessa ska ha
//  olika mycket rabatt.
//  
//  Gold: 15 % rabatt på hela köpet
//  Silver: 10 % rabatt på hela köpet
//  Bronze: 5 % rabatt på hela köpet
//  Nivåerna skall implementeras med hjälp av arv av basklassen Kund.
//  
//  Programmet ska också spara alla registrerade kunder så att de går att använda emellan körningar. (OBS! Kundvagnar
//  behöver ej sparas) Tips: textfil.
//  
//  Man ska också kunna välja att se priser i minst 3 olika valutor (två ytterligare förutom SEK).


using Programmering_C_Sharp_Labb_2_Ny_version;
using System;
using System.Collections.Generic;

namespace Programmering_C_Sharp_Labb_2_Ny_version {
    class Program {
        
        //public Menu menu = new Menu(false);

        //bool firstMenu = true;

        /* public static User knatte = new User("Knatte", "123", "Knatte", "Anka", "Gold");
        public static User fnatte = new User("Fnatte", "321", "Knatte", "Anka", "Silver");
        public static User tjatte = new User("Tjatte", "213", "Knatte", "Anka", "Bronze"); */

        public static string[] knatte = new string[] { "Knatte", "123", "Knatte", "Anka", "Gold" };
        public static string[] fnatte = new string[] { "Fnatte", "321", "Fnatte", "Anka", "Silver" };
        public static string[] tjatte = new string[] { "Tjatte", "213", "Tjatte", "Anka", "Bronze" };

        public static List<string[]> listOfUsers = new List<string[]>() { knatte, fnatte, tjatte };

        public static List<string[]> shoppingCartList = new List<string[]>();

        /* public static bool isSomeoneOnline = Login_And_Logout.isSomeoneLoggedIn; */
        //public static bool isSomeoneOnline = false;
        private static bool isSomeoneOnline = false;
        public static bool IsSomeoneOnline {
            get { return isSomeoneOnline; }
            set { isSomeoneOnline = value; }
        }

        //public static string userOnline = "";
        private static string userOnline = "Quentin";
        public static string UserOnline {
            get { return userOnline; }
            set { userOnline = value; }
        }
        

        static void Main(string[] args) {

            GreetingUser();

            //Console.ReadKey();

        }

        public static void GreetingUser() {

            ShowOnlineCustomer showOnlineCustomer = new ShowOnlineCustomer(IsSomeoneOnline, UserOnline);

            Menu firstMenu = new Menu(true);

            //Greeting_User greeting_User = new Greeting_User();

            Keystrokes(true, listOfUsers);
            
        }

        public static void LoginAndLogout() {

            //Lite speciell metod...

            ShowOnlineCustomer showOnlineCustomer = new ShowOnlineCustomer(IsSomeoneOnline, UserOnline);//new ShowOnlineCustomer(isSomeoneOnline);

            //Menu firstMenu = new Menu(true);

            Login_And_Logout login_And_Logout = new Login_And_Logout(listOfUsers, IsSomeoneOnline, UserOnline);

            Keystrokes(true, listOfUsers);

        }

        public static void CreateNewUser() {

            //Menu mainMenu = new Menu(false);

            Create_New_User create_New_User = new Create_New_User();

            //Göra listOfUsers lista, sedan count på den, variabel för nummret på count = namn på user?
            //Eller hur får jag eget namn?
            //Använda Dictionary?
            //Create_New_User.newUsersStrings[]

            //string okay = Create_New_User.newUsersUsername;

            //Console.WriteLine("Before new User: " + listOfUsers.Count);
            //Console.ReadKey();

            User newCart = new User();

            User newUser = new User(Create_New_User.newUsersUsername, Create_New_User.newUsersPassword, Create_New_User.newUsersFirstName, Create_New_User.newUsersLastName, Create_New_User.newUsersMembershipLevel, shoppingCartList );

            //Console.WriteLine("After creating new user: " + listOfUsers.Count);
            //Console.ReadKey();

            MainMenu();

            Keystrokes(false, listOfUsers);

        }

        public static void MainMenu() {

            //Console.Clear();

            ShowOnlineCustomer showOnlineCustomer = new ShowOnlineCustomer(IsSomeoneOnline, UserOnline);

            Menu mainMenu = new Menu(false);

            //Main_Page main_Menu = new Main_Page();

            Keystrokes(false, listOfUsers);

        }

        public static void Books() {

            ShowOnlineCustomer showOnlineCustomer = new ShowOnlineCustomer(IsSomeoneOnline, UserOnline);

            Menu mainMenu = new Menu(false);

            Books_Page books_Page = new Books_Page();

            /*            foreach (string[] stringArray in Books_Page.listOfBooks) {
                            if() {
                            }
                        } */

//            string usersInput = Console.ReadLine().ToUpper();

            //Linq?

/*            for (int i = 0; i < Books_Page.listOfBooks.Count; i++) {

                if (int.TryParse(usersInput, out _)) {

                    //if (int.Parse(usersInput) == i + 101) {
                    if (int.Parse(usersInput) == int.Parse(Books_Page.listOfBooks[i][3])) {

                        //Books_Page.listOfBooks[i][3]

                        //Ersätt med att boken läggs i kundvagnen, gör sedan samma med spel och film.
                        Console.WriteLine("Hej!");

                        Console.Clear();

                        Books();

                    } else {

                        Console.Clear();

                        Books();

                    }

                }

            } */

            //Console.WriteLine(Books_Page.listOfBooks[1][1]);


            Keystrokes(false, listOfUsers);

        }

        public static void Games() {

            ShowOnlineCustomer showOnlineCustomer = new ShowOnlineCustomer(IsSomeoneOnline, UserOnline);

            Menu mainMenu = new Menu(false);

            Games_Page games_Page = new Games_Page();

            Keystrokes(false, listOfUsers);

        }

        public static void Movies() {

            ShowOnlineCustomer showOnlineCustomer = new ShowOnlineCustomer(IsSomeoneOnline, UserOnline);

            Menu mainMenu = new Menu(false);

            Movies_Page movies_Page = new Movies_Page();

            Keystrokes(false, listOfUsers);

        }

        public static void ViewShoppingCart() {

            ShowOnlineCustomer showOnlineCustomer = new ShowOnlineCustomer(IsSomeoneOnline, UserOnline);

            Menu mainMenu = new Menu(false);

            View_Shopping_Cart view_Shopping_Cart = new View_Shopping_Cart();

            Keystrokes(false, listOfUsers);

        }

        public static void CheckOut() {

            ShowOnlineCustomer showOnlineCustomer = new ShowOnlineCustomer(IsSomeoneOnline, UserOnline);

            Menu mainMenu = new Menu(false);

            Check_Out check_Out = new Check_Out();

            Keystrokes(false, listOfUsers);

        }

        public static void Keystrokes(bool firstmenu, List<string[]> listOfUsers) {

            string usersInput = Console.ReadLine().ToUpper();

            bool firstMenu = firstmenu;

            if (usersInput == "1" || usersInput == "2" || usersInput == "3" || usersInput == "4" || usersInput == "5" || usersInput == "K" || usersInput == "B" || usersInput == "L") {

                if (usersInput == "1" && firstMenu == true) {

                    Console.Clear();

                    LoginAndLogout();

                } else if (usersInput == "1" && firstMenu == false) {

                    Console.Clear();

                    Books();

                } else if (usersInput == "2" && firstMenu == true) {

                    Console.Clear();

                    CreateNewUser();

                } else if (usersInput == "2" && firstMenu == false) {

                    Console.Clear();

                    Games();

                } else if (usersInput == "3" && firstMenu == true) {

                    Console.Clear();

                    Menu showMenu = new Menu(false);
                    
                    Keystrokes(false, listOfUsers);
                    
                } else if (usersInput == "3" && firstMenu == false) {

                    Console.Clear();

                    Movies();

                } else if (usersInput == "4" && firstMenu == true) {

                    Keystrokes(firstMenu, listOfUsers);

                } else if (usersInput == "4" && firstMenu == false) {

                    Keystrokes(firstMenu, listOfUsers);

                } else if (usersInput == "5" && firstMenu == true) {

                    Keystrokes(firstMenu, listOfUsers);

                } else if (usersInput == "5" && firstMenu == false) {

                    Keystrokes(firstMenu, listOfUsers);

                } else if (usersInput == "K" && firstMenu == true) {

                    Keystrokes(firstMenu, listOfUsers);

                } else if (usersInput == "K" && firstMenu == false) {

                    Console.Clear();

                    ViewShoppingCart();

                } else if (usersInput == "B" && firstMenu == true) {

                    Keystrokes(firstMenu, listOfUsers);

                } else if (usersInput == "B" && firstMenu == false) {

                    Console.Clear();

                    CheckOut();

                } else if (usersInput == "L" && firstMenu == true) {

                    Keystrokes(firstMenu, listOfUsers);

                } else if (usersInput == "L" && firstMenu == false) {

                    Console.Clear();

                    LoginAndLogout();

                }

            } else {

                //int shoppingcartId = 0;

                for (int i = 0; i < Books_Page.listOfBooks.Count; i++) {

                    if (int.TryParse(usersInput, out _)) {

                        if (int.Parse(usersInput) == int.Parse(Books_Page.listOfBooks[i][3])) {

                            if (isSomeoneOnline == false) {

                                //shoppingCartList.Add(Books_Page.listOfBooks[i]);

                            } else {

                                

                            }

                            //Ersätt med att boken läggs i kundvagnen, gör sedan samma med spel och film.
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write("Tillagd i kundvagnen: ");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(Books_Page.listOfBooks[i][0] + "\n");
                            Console.ResetColor();

                            //shoppingCartList.Add(Books_Page.listOfBooks[i]);

                            //GALEN kod!!! Lägger till Bok, Spel samt Film i kundvagnen; tänkte att det bara skulle gälla böcker här och lägga till samma kod i de andra looparna. Men det fungerar ju redan som jag vill nu... Eller...? O.o

                            //User.UsersShoppingCart = shoppingCartList;

                            if(isSomeoneOnline == true) {

                                //User.iHateCarts.Add(Books_Page.listOfBooks[i]);
                                
/*/*//*//*///                                User.UsersShoppingCart.Add(Books_Page.listOfBooks[i]);

                                    //shoppingCartList.RemoveAt(0);

                            } else {

                                shoppingCartList.Add(Books_Page.listOfBooks[i]);

                            }

                            if(IsSomeoneOnline == true) { 

/*/*//*//*/                            for (int a = 0; a < User.UsersShoppingCart.Count; a++) {

                                //Console.WriteLine(shoppingCartList[a][0]);
/*/*//*//*///                                Console.WriteLine("Online cart: " + User.UsersShoppingCart[a][0]);

                            }

                            } else { 

                            for (int a = 0; a < shoppingCartList.Count; a++) {

                                Console.WriteLine("Offline cart: " + shoppingCartList[a][0]);
                                //Console.WriteLine(User.UsersShoppingCart[a][0]);

                            }

                            }

                            //shoppingcartId++;

                            //Console.Clear();

                        } else {

                            //Console.Clear();

                        }

                    }

                }

                for (int i = 0; i < Games_Page.listOfGames.Count; i++) {

                    if (int.TryParse(usersInput, out _)) {

                        if (int.Parse(usersInput) == int.Parse(Games_Page.listOfGames[i][3])) {

                            //shoppingCartList[shoppingcartId] = Games_Page.listOfGames[i];

                            shoppingCartList.Add(Games_Page.listOfGames[i]);

                            //Ersätt med att spelet läggs i kundvagnen, gör sedan samma med bok och film.
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write("Tillagd i kundvagnen: ");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(Games_Page.listOfGames[i][0] + "\n");
                            Console.ResetColor();

                            //shoppingcartId++;

                            //Console.Clear();

                        } else {

                            //Console.Clear();

                        }

                    }

                }

                for (int i = 0; i < Movies_Page.listOfMovies.Count; i++) {

                    if (int.TryParse(usersInput, out _)) {

                        if (int.Parse(usersInput) == int.Parse(Movies_Page.listOfMovies[i][3])) {

                            //shoppingCartList[shoppingcartId] = Movies_Page.listOfMovies[i];

                            shoppingCartList.Add(Movies_Page.listOfMovies[i]);

                            //Ersätt med att filmen läggs i kundvagnen, gör sedan samma med spel och bok.
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write("Tillagd i kundvagnen: ");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(Movies_Page.listOfMovies[i][0] + "\n");
                            Console.ResetColor();

                            //shoppingcartId++;

                            //Console.Clear();

                        } else {

                            //Console.Clear();

                        }

                    }

                }

                //Console.WriteLine(shoppingCartList.Count);

                //Console.WriteLine(shoppingCartList[0][0].ToString());// <--- Måste använda ToString(), detta är hur...

                /*Console.WriteLine(shoppingCartList[0][0].ToString());
                Console.WriteLine(shoppingCartList[0][1].ToString());
                Console.WriteLine(shoppingCartList[0][2].ToString());
                Console.WriteLine(shoppingCartList[0][3].ToString());*/
                
                Keystrokes(firstMenu, listOfUsers);

            }

        }

    }
}




/*
 
    Lika bra att lägga till en variabel som kollar vilken sida användaren är inne på när användaren handlar...
    Så att det bara går att handla boken med varunummer 102 på boksidan etcetera. Lägg till i Keystrokes metoden.
 
 */



/*

    För första menyn, introduktionssidan: Gör en array med de olika menyalternativen. Skriv en foreach. Innan foreach, bara "#" exempelvis. 
    Sedan foreach där startar och avslutar med "#". Fyll ut tomrum med mellanrum. Lägg in orden från arrayen med nummer "1", "2", "3" etcetera i mitten.
    Resultat en ram med ord och siffror för vad man skall skriva för olika alternativ. Antingen 1. Logga in eller 2. Ny användare.

    Skapa en metod för tangentbordstryckningar, vilken kollar om det är meny ett eller två. Skall också kolla produktsida och annat som kan kräva knapptryckningar.
    Kör meny och tangentbordstryckningar metoden till alla klasser.

*/























//Console.WriteLine("Hello and welcome to our store! \nAre you allready a customer with us?\n\nAnswer with \"Yes\" or \"No\"");

//string isUserANewUser = Console.ReadLine();
//isUserANewUser = isUserANewUser.ToLower();

//if (isUserANewUser == "yes") {

//    Console.WriteLine("\nWelcome back ");
//    MainMenu();

//    //Kör metod för inloggad användare

//} else if (isUserANewUser == "no") {

//    Console.WriteLine("\nPlease register yourself as a new user!");

//    CreateNewUser();

//    //Kör metod för att skapa ny användare

//} else {

//    Console.WriteLine("\nPlease provide a \"Yes\" or \"No\" as an answer to wheter you are allready a registered user with us!\n");

//    GreetingUser();

//}





















//public Menu menu = new Menu(true);

//Programmering_C_Sharp_Labb_2_Try2.Menu(true);